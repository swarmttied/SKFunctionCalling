namespace SKQueryGen;


using Microsoft.Extensions.Configuration;
using SKFunctionCalling;
using SKLib;
using SKLIb;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using static Console;
using static SKFunctionCalling.DbHelper;
using static SKFunctionCalling.RoleService;

public class SKQueryGenProgram
{
    public static async Task Main()
    {
#if RESET
        ResetDb();
        WriteLine("DB is reset.");
#endif

        var program = new SKQueryGenProgram();
        await program.RunAsync();
    }

    IDbHelper _dbHelper = null!;
    async Task RunAsync()
    {
        var configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .Build();
        string endpoint = configuration["endpoint"] ?? "";
        string deployment = configuration["deployment"] ?? "";
        string dbConStr = configuration["dbConStr"] ?? "";

        ///_dbHelper = new SqlServerDbHelper(dbConStr);
        //string schemaInfo = _dbHelper.GetDbSchema(tableSchema: "SK");

        _dbHelper = new SqliteDbHelper(DbHelper.GetDbConStr());
        string schemaInfo = _dbHelper.GetDbSchema();

        string instructions = $"You are the Query Genarator for role membership. Your task is convert the user input to SQL query based on the database schema below. You ensure that the constraints and rules are followed to maintain data integrity. \n\n {schemaInfo}";

        ForegroundColor = ConsoleColor.White;

        WriteLine(
$@"
------------------------------------------------------------------------------------------
                                   Query Generator 

This is a simple implementation of Semantic Kernel to translate natural language into SQL
query and run it against a database. You may start with ""Tell me about the database"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ");

        string prompt = "Hi. Who are you and what can you do for me?";
        ISKClient functionCaller = new SKClient(endpoint, deployment, instructions);
        functionCaller.ResponseReceived += FunctionCaller_ResponseReceived;
        functionCaller.RateExceeded += FunctionCaller_RateExceeded;
        while (true)
        {
            ForegroundColor = ConsoleColor.DarkYellow;

            await functionCaller.RunAsync(prompt);

            ForegroundColor = ConsoleColor.White;
            Write("You > ");

            prompt = ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(prompt))
                continue;

            if (prompt.Trim().ToLower() == "exit")
                break;
        }
    }

    #region Event handlers

    void FunctionCaller_RateExceeded(object? sender, SKClient.RateExceededEventArgs e)
    {
        int sec = 10;
        e.WaitTimeInSeconds = sec;
        Console.WriteLine($"Rate limit exceeded. Retrying after {sec} seconds.");

    }

    void FunctionCaller_ResponseReceived(object? sender, SKClient.ResponseEventArgs e)
    {
        var response = e.Response ?? "";

        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Bot > {response}");

        string[] sqlQueries = ExtractSql(response);
        try
        {
            foreach (var qry in sqlQueries)
            {
                DataTable tbl = _dbHelper.RunQuery(qry);
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

    #endregion

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

    static void ResetDb()
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

