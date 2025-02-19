using Azure.Identity;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using System.Text.RegularExpressions;

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
            public string[] SqlQueries { get; set; } = Array.Empty<string>();
        }

        public class RateExceededEventArgs : EventArgs
        {
            public int WaitTimeInSeconds { get; set; }
        }

        public event EventHandler<ResponseEventArgs>? ResponseReceived;
        public event EventHandler<RateExceededEventArgs>? RateExceeded;

        readonly ChatHistory _chatHistory;
        readonly IChatCompletionService _chatService;
        readonly OpenAIPromptExecutionSettings _openAIPromptExecutionSettings;
        readonly Kernel _kernel;


        public SKClient(string endpoint, string deployment, string instructions, IFunctionCalled[]? services = null)
        {
            var builder = Kernel.CreateBuilder();
            builder.AddAzureOpenAIChatCompletion(
                deploymentName: deployment,
                endpoint: endpoint,
                credentials: new AzureCliCredential());


            _openAIPromptExecutionSettings = new();

            if (services != null)
            {
                Services = services;
                foreach (var service in Services)
                    builder.Plugins.AddFromObject(service);
                _openAIPromptExecutionSettings.ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions;
            }

            _kernel = builder.Build();

            _chatHistory = new ChatHistory();
            if (instructions != null)
            {
                _chatHistory.AddSystemMessage(instructions);
            }
            _chatService = _kernel.GetRequiredService<IChatCompletionService>();
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
                        kernel: _kernel);
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

            ResponseReceived?.Invoke(this, new ResponseEventArgs { Response = fullMessage, SqlQueries=ExtractSql(fullMessage) });
        }

        public IFunctionCalled[]? Services { get; private set; }

        static string[] ExtractSql(string response)
        {
            string pattern = @"(?<=```sql)(.*?)(?=```)";
            var matches = Regex.Matches(response, pattern, RegexOptions.Singleline);
            string[] sqlQueries = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                sqlQueries[i] = matches[i].Value.Trim();
            }
            return sqlQueries;
        }
    }
}
