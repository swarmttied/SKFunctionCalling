namespace SKFunctionCalling;

using static DbHelper;
using static RoleService;
using static Console;
using Microsoft.Extensions.Configuration;

public class Program
{
    public static async Task Main()
    {
        var configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
        string endpoint = configuration["endpoint"];
        string deployment = configuration["deployment"];
        string dbPath = configuration["dbPath"];

#if RESET
        ResetDb();
#endif

        ForegroundColor = ConsoleColor.White;

        WriteLine($@"
------------------------------------------------------------------------------------------
This is a simple implementation of Function Calling in Semantic Kernel using AzureOpenAI.
Function Calling allows you to call function in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands""

Type ""exit"" to exit the app.

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ");



        string prompt = "Hello. What is your name?";
        var functionCaller = new FunctionCaller(AIendpoint: endpoint, AIdeployment: deployment);
        while (true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;

            var response = await functionCaller.Run(prompt);


            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Bot > {response}");

            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine();
            if (string.IsNullOrWhiteSpace(prompt))
                continue;


            if (prompt.Contains("exit"))
                break;
        }
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

