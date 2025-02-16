namespace SKFunctionCalling;

using static DbHelper;
using static RoleService;
using static Console;
using Microsoft.Extensions.Configuration;

public class Program
{
    public static async Task Main()
    {
        var dbConStr = "Server=tcp:giobsql.database.windows.net,1433;Initial Catalog=BlueCorner;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";
        DbSchemaHelper.PrintDatabaseSchema(dbConStr);   


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
$@"---------------------------------------------------------------------------------------
This is a simple implementation of Function Calling in Semantic Kernel using AzureOpenAI.
Function Calling allows you to call function in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ");



        string prompt = "Hello. What is your name?";
        IFunctionCalled[] services = { new RoleService(), 
                              new UserService(), 
                              new UserRoleService(), 
                              new NotificationService() };
        var functionCaller = new FunctionCaller(AIendpoint: endpoint, AIdeployment: deployment, services: services);
        functionCaller.ResponseReceived += FunctionCaller_ResponseReceived;
        functionCaller.RateExceeded += FunctionCaller_RateExceeded;
        while (true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;

            await functionCaller.Run(prompt);

            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine();
            if (string.IsNullOrWhiteSpace(prompt))
                continue;

            if (prompt.Contains("exit"))
                break;
        }
    }

    private static void FunctionCaller_RateExceeded(object? sender, FunctionCaller.RateExceededEventArgs e)
    {
        int sec = 10;
        e.WaitTimeInSeconds = sec;
        Console.WriteLine($"Rate limit exceeded. Retrying after {sec} seconds.");

    }

    private static void FunctionCaller_ResponseReceived(object? sender, FunctionCaller.ResponseEventArgs e)
    {
        var response = e.Response;

        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Bot > {response}");

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

