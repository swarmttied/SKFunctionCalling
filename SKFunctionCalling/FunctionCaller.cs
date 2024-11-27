using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;


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
            apiKey: "Ex5asRs0zorNv4iJjK5a4mBN2HyEltVMO0UaD4s0QhU2cV1b0QAaJQQJ99AKACYeBjFXJ3w3AAABACOGbEcZ");
        builder.Plugins.AddFromObject(new RoleService())
                       .AddFromObject(new UserService())
                       .AddFromObject(new UserRoleService());

        _sk = builder.Build();

        var instructions = @"You are Ana the Role Membership Agent in our team. You assist us with our requests on access and permissions";
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
        var messageContents = _chatService.GetStreamingChatMessageContentsAsync(
            _chatHistory,
            _openAIPromptExecutionSettings,
            kernel:_sk
            );

        string fullMessage = "";
        await foreach (var msg in messageContents)
        {
            Console.Write(msg.Content);
            fullMessage += msg.Content;
        }

        Console.WriteLine();

        return fullMessage;
    }
}
