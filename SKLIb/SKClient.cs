using Azure.Identity;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

namespace SKLIb
{
    public interface ISKClient
    {
        IFunctionCalled[]? Services { get; }

        event EventHandler<SKClient.RateExceededEventArgs>? RateExceeded;
        event EventHandler<SKClient.ResponseEventArgs>? ResponseReceived;

        Task RunAsync(string prompt);
    }

    public class SKClient : ISKClient
    {
        public class ResponseEventArgs : EventArgs
        {
            public string? Response { get; set; }
        }

        public class RateExceededEventArgs : EventArgs
        {
            public int WaitTimeInSeconds { get; set; }
        }

        public event EventHandler<ResponseEventArgs>? ResponseReceived;
        public event EventHandler<RateExceededEventArgs>? RateExceeded;

        ChatHistory _chatHistory;
        IChatCompletionService _chatService;
        OpenAIPromptExecutionSettings _openAIPromptExecutionSettings;
        readonly string _endpoint;
        readonly string _deployment;
        readonly string _instructions;


        public SKClient(string endpoint, string deployment, string instructions, IFunctionCalled[]? services = null)
        {
            _endpoint = endpoint;
            _deployment = deployment;
            _instructions = instructions;
            Services = services;
        }

        Kernel _kernel;
        private Kernel Kernel
        {
            get
            {
                if (_kernel != null)
                    return _kernel;

                var builder = Kernel.CreateBuilder();
                builder.AddAzureOpenAIChatCompletion(
                    deploymentName: _deployment,
                    endpoint: _endpoint,
                    credentials: new DefaultAzureCredential());


                _openAIPromptExecutionSettings = new();

                if (Services != null)
                {
                    foreach (var service in Services)
                        builder.Plugins.AddFromObject(service);
                    _openAIPromptExecutionSettings.ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions;
                }

                _kernel = builder.Build();

                _chatHistory = new ChatHistory();
                if (_instructions != null)
                {
                    _chatHistory.AddSystemMessage(_instructions);
                }
                _chatService = _kernel.GetRequiredService<IChatCompletionService>();
                return _kernel;
            }
        }

        public async Task RunAsync(string prompt)
        {
            _chatHistory.AddUserMessage(prompt);
            bool success = false;
            IReadOnlyList<ChatMessageContent>? messageContents = null;
            do
            {
                try
                {
                    messageContents = await _chatService.GetChatMessageContentsAsync(
                        _chatHistory,
                        _openAIPromptExecutionSettings,
                        kernel: Kernel);
                    success = true;
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("exceeded"))
                    {
                        //Console.WriteLine("Rate limit exceeded. Retrying after 30 seconds.");
                        var args = new RateExceededEventArgs { WaitTimeInSeconds = 30 };
                        RateExceeded?.Invoke(this, args);
                        Thread.Sleep(TimeSpan.FromSeconds(args.WaitTimeInSeconds));
                    }
                    else if (ex.Message.Contains("content_filter"))
                    {
                        var msg = "The response was filtered due to the prompt triggering Azure OpenAI's content management policy. Please modify your prompt and retry.";
                        ResponseReceived?.Invoke(this, new ResponseEventArgs { Response = msg });
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            while (!success);


            string fullMessage = "";
            if (messageContents != null)
            {
                foreach (var msg in messageContents)
                {
                    //Console.Write(msg.Content);
                    fullMessage += msg.Content;
                }
            }

            _chatHistory.AddAssistantMessage(fullMessage);

            ResponseReceived?.Invoke(this, new ResponseEventArgs { Response = fullMessage });
        }

        public IFunctionCalled[]? Services { get; private set; }
    }
}
