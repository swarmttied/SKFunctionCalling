namespace SKQueryGen;


using static Console;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text;
using SKFunctionCalling;
using System.Text.RegularExpressions;

public class Program
{
    public static async Task Main()
    {
        var dbConStr = "Server=tcp:giobsql.database.windows.net,1433;Initial Catalog=BlueCorner;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";
        var schemaInfo = DbSchemaHelper.PrintDatabaseSchema(dbConStr);

        string instructions = $"You are the Query Genarator for role membership. Your task is convert the user input to SQL query based on the database schema below. You ensure that the constraints and rules are followed to maintain data integrity. \n\n {schemaInfo}";


        var configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
        string endpoint = configuration["endpoint"] ?? "";
        string deployment = configuration["deployment"] ?? "";

        ForegroundColor = ConsoleColor.White;

        WriteLine(
$@"---------------------------------------------------------------------------------------
This is a simple implementation of Semantic Kernel to translate natural language into SQL
query and run it against a database. You may start with ""Tell me about the database"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ");



        string prompt = "Hi. Who are you and what can you do for me?";
        var functionCaller = new FunctionCaller(AIendpoint: endpoint, AIdeployment: deployment, instructions: instructions);
        functionCaller.ResponseReceived += FunctionCaller_ResponseReceived;
        functionCaller.RateExceeded += FunctionCaller_RateExceeded;
        while (true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;

            await functionCaller.Run(prompt);

            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(prompt))
                continue;

            if (prompt.Trim().ToLower() == "exit")
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
        var response = e.Response ?? "";

        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Bot > {response}");

        string[] sqlQueries = ExtractSql(response);
        var dbConStr = "Server=tcp:giobsql.database.windows.net,1433;Initial Catalog=BlueCorner;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;Authentication=\"Active Directory Default\";";
        try
        {
            foreach (var qry in sqlQueries) 
            { 
                DataTable tbl = DbSchemaHelper.RunQuery(dbConStr, qry);
                string qryResult = ConvertToString(tbl);
                ForegroundColor = ConsoleColor.DarkYellow;
                WriteLine($"System > {qryResult}");
            }
        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("syntax"))
                return;
            
            // Display only constraint errors
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"System > ERROR! {ex.Message}");
        }
    }


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

    static string ConvertToString(DataTable dataTable)
    {
        if (dataTable.Rows.Count == 0)
            return "Empty result";

        var sb = new StringBuilder("| ");
        foreach (DataColumn column in dataTable.Columns)
        {
            sb.Append($"{column.ColumnName} | ");
        }
        sb.AppendLine();

        foreach (DataRow row in dataTable.Rows)
        {
            sb.Append("| ");
            foreach (DataColumn column in dataTable.Columns)
            {
                sb.Append($"{row[column]} | ");
            }
            sb.AppendLine();
        }
        sb.Append($"\nRows: {dataTable.Rows.Count}\n");
        return sb.ToString();
    }
}

