namespace SKFunctionCalling;

using static DbHelper;
using static RoleService;
using static Console;

public class Program
{
    public static async Task Main()
    {
        CreateDbIfNotExist();
        TruncateTables();
        AddRole("Admin");
        AddRole("Investigator");
        AddRole("Auditor");
        AddRole("Audit Manager");
        AddRole("Dev");
        AddRole("Tester");

        ForegroundColor = ConsoleColor.White;

        WriteLine(@"
------------------------------------------------------------------------------------------
This is a simple implementation of Function Calling in Semantic Kernel using ChatGPT.
Function Calling allows you to call functions in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands,""

Press enter to exit the chat.
------------------------------------------------------------------------------------------
");

        string prompt = "";

        WriteLine();

        var functionCaller = new FunctionCaller();
        while (true)
        {
            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine();
            if (string.IsNullOrWhiteSpace(prompt))
                break;
            ForegroundColor = ConsoleColor.DarkYellow;

            var response = await functionCaller.Run(prompt);                   


            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Bot > {response}");
        }
    }
}

