namespace SKFunctionCalling;

using Microsoft.SemanticKernel;
using static DbHelper;
using static Console;

public class Program
{
    public static async Task Main()
    {
        CreateDbIfNotExist();
        TruncateTables();

        ResetColor();

        WriteLine(@"
You may start by asking what the app can do. 

Press enter to exit the chat.
");

        string prompt = "";

        WriteLine();

        var functionCaller = new FunctionCaller();
        while (true)
        {
            ResetColor();
            Write("You > ");

            prompt = ReadLine();
            if (string.IsNullOrWhiteSpace(prompt))
                break;
            ForegroundColor = ConsoleColor.Green;

            var response = await functionCaller.Run(prompt);                   


            ForegroundColor = ConsoleColor.Blue;
            WriteLine($"Bot > {response}");
        }
    }
}

