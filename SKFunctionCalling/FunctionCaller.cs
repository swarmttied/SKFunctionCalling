using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Azure.Identity;


namespace SKFunctionCalling;

internal class FunctionCaller
{
    readonly ChatHistory _chatHistory;
    readonly IChatCompletionService _chatService;
    readonly OpenAIPromptExecutionSettings _openAIPromptExecutionSettings;
    readonly Kernel _sk;
    public FunctionCaller()
    {
        var builder = Kernel.CreateBuilder();
        builder.AddAzureOpenAIChatCompletion(
            deploymentName: "gpt-4o",
            endpoint: "https://gbb-open-ai.openai.azure.com/",
            credentials: new DefaultAzureCredential());

        // Use this if you prefer API key
        //builder.AddAzureOpenAIChatCompletion(
        //   deploymentName: "gpt-4o",
        //   endpoint: "https://gbb-open-ai.openai.azure.com/",
        //   apiKey: "<your key here>");

        builder.Plugins.AddFromType<RoleService>()
                       .AddFromType<UserService>()
                       .AddFromType<UserRoleService>();

        _sk = builder.Build();

        var instructions = @"Your name is Sissy the Role Membership Agent in our team. You assist us with our requests on access and permissions.
You will introduce yourself before executing the first command. If there is commands you cannot comply, let the user know.

If no function in this application is called, tell the user the request is beyond the scope of your responsibilities.
";
        _chatHistory = new ChatHistory(instructions);

        _openAIPromptExecutionSettings = new()
        {
            ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
        };

        _chatService = _sk.GetRequiredService<IChatCompletionService>();
    }

    public async Task<string> Run(string prompt)
    {
        _chatHistory.AddUserMessage(prompt);
        var messageContents = await _chatService.GetChatMessageContentsAsync(
            _chatHistory,
            _openAIPromptExecutionSettings,
            kernel:_sk
            ); 

        string fullMessage = "";
        foreach (var msg in messageContents)
        {            
            Console.Write(msg.Content);
            fullMessage += msg.Content;
        }

        Console.WriteLine();
        _chatHistory.AddAssistantMessage(fullMessage);
        return fullMessage;
    }
}
