using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Azure.Identity;


namespace SKFunctionCalling;

public class FunctionCaller
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

    readonly ChatHistory _chatHistory;
    readonly IChatCompletionService _chatService;
    readonly OpenAIPromptExecutionSettings _openAIPromptExecutionSettings;
    readonly Kernel _sk;
    public FunctionCaller(string AIendpoint, string AIdeployment, string? instructions=null, IFunctionCalled[]? services=null)
    {
        var builder = Kernel.CreateBuilder();
        builder.AddAzureOpenAIChatCompletion(
            deploymentName: AIdeployment,
            endpoint: AIendpoint,
            credentials: new AzureCliCredential());


        _openAIPromptExecutionSettings = new();

        // Use this if you prefer API key (not recommended)
        //builder.AddAzureOpenAIChatCompletion(
        //   deploymentName: AIdeployment,
        //   endpoint: AIendpoint,
        //   apiKey: "key here");

        //builder.Plugins.AddFromType<RoleService>()
        //               .AddFromType<UserService>()
        //               .AddFromType<UserRoleService>()
        //               .AddFromType<NotificationService>();
        if (services != null)
        {
            Services = services;
            foreach (var service in services)
                builder.Plugins.AddFromObject(service);
            _openAIPromptExecutionSettings.ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions;
        }

        _sk = builder.Build();

        instructions ??= @"You are the Role Membership Agent. You assist with user user access needs.
You will introduce yourself before executing the first command. If there is commands you cannot comply, let the user know.

If no function in this application is called, tell the user the request is beyond the scope of your responsibilities.
";
        _chatHistory = new ChatHistory(instructions);

        _chatService = _sk.GetRequiredService<IChatCompletionService>();
    }

    public async Task Run(string prompt)
    {
        _chatHistory.AddUserMessage(prompt);
        bool success = false;
        IReadOnlyList<ChatMessageContent> messageContents = null;
        do
        {  try
            {
                messageContents = await _chatService.GetChatMessageContentsAsync(
                    _chatHistory,
                    _openAIPromptExecutionSettings,
                    kernel: _sk);
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
        foreach (var msg in messageContents)
        {            
            //Console.Write(msg.Content);
            fullMessage += msg.Content;
        }

        _chatHistory.AddAssistantMessage(fullMessage);
       
        ResponseReceived?.Invoke(this, new ResponseEventArgs { Response = fullMessage });
    }

    public IFunctionCalled[]? Services { get; private set; }
}
