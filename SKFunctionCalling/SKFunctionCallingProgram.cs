namespace SKFunctionCalling;

using static DbHelper;
using static RoleService;
using static Console;
using Microsoft.Extensions.Configuration;
using SKLIb;

public class SKFunctionCallingProgram
{
    public static async Task Main()
    {
        var configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
        string endpoint = configuration["endpoint"];
        string deployment = configuration["deployment"];

#if RESET
        ResetDb();
        Console.WriteLine("DB is reset.");
#endif

        ForegroundColor = ConsoleColor.White;

        WriteLine(
$@"
------------------------------------------------------------------------------------------
                                    Function Calling

This is a simple implementation of Function Calling in Semantic Kernel using AzureOpenAI.
Function Calling allows you to call function in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ");

        var instructions = @"You are the Role Membership Agent. You assist with user user access needs.
You will introduce yourself before executing the first command. If there is commands you cannot comply, let the user know.

If no function in this application is called, tell the user the request is beyond the scope of your responsibilities.
";

        string prompt = "Hello. What is your name?";
        SKLIb.IFunctionCalled[] services = { new RoleService(),
                              new UserService(),
                              new UserRoleService(),
                              new NotificationService() };
        var functionCaller = new SKClient(endpoint, deployment, instructions, services);
        functionCaller.ResponseReceived += FunctionCaller_ResponseReceived;
        functionCaller.RateExceeded += FunctionCaller_RateExceeded;
        while (true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;

            await functionCaller.RunAsync(prompt);

            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine();
            if (string.IsNullOrWhiteSpace(prompt))
                continue;

            if (prompt.Trim().ToLower() == "exit")
                break;
        }
    }

    private static void FunctionCaller_RateExceeded(object? sender, SKClient.RateExceededEventArgs e)
    {
        var seconds = 10;
        e.WaitTimeInSeconds = seconds;
        WriteLine($"Rate limit exceeded. Retrying after {seconds} seconds.");
    }

    private static void FunctionCaller_ResponseReceived(object? sender, SKClient.ResponseEventArgs e)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Bot > {e.Response}");
    }

    private static void ResetDb()
    {
        CreateDbIfNotExist();
        TruncateTables();
        AddRole("Admin");
        AddRole("Investigator");
        AddRole("Auditor");
        AddRole("Audit Manager");
        AddRole("Dev");
        AddRole("Tester");
    }
}

