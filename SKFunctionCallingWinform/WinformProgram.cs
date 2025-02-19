using SKFunctionCalling;
using SKLib;
using SKLIb;
using static SKFunctionCalling.DbHelper;
using static SKFunctionCalling.RoleService;
using static System.Configuration.ConfigurationManager;


namespace SKFunctionCallingWinform;

internal static class WinformProgram
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
#if RESET
        ResetDb();
        Console.WriteLine("DB is reset");
#endif
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        string endpoint = AppSettings["endpoint"];
        string deployment = AppSettings["deployment"];
        IFunctionCalled[] services = { new RoleService(),
                              new UserService(),
                              new UserRoleService(),
                              new NotificationService() };
        var instructions = @"You are the Role Membership Agent. You assist with user user access needs.
You will introduce yourself before executing the first command. If there is commands you cannot comply, let the user know.

If no function in this application is called, tell the user the request is beyond the scope of your responsibilities.
";
        SKClient functionCaller = new(endpoint, deployment, instructions, services);
        var chatBanner =
 @$"
---------------------------------------------------------------------------------------------------------
                                    Function Calling

This is a simple implementation of Function Calling in Semantic Kernel using AzureOpenAI.
Function Calling allows you to call function in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
--------------------------------------------------------------------------------------------------------";

        string dbConStr = AppSettings["dbConStr"];        
        SqlServerDbHelper dbHelper = new(dbConStr);
        var queryGenInstructions = GetQueryGenInstructions(dbHelper);
        SKClient queryGen = new(endpoint, deployment, queryGenInstructions);
        var queryGenBanner =
$@"
------------------------------------------------------------------------------------------
                                   Query Generator 

This is a simple implementation of Semantic Kernel to translate natural language into SQL
query and run it against a database. You may start with ""Tell me about the database"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
------------------------------------------------------------------------------------------
    ";
        Application.Run(new Form1(functionCaller ,chatBanner, queryGen, dbHelper, queryGenBanner));
    }

    static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
    {
        Exception ex = (Exception)e.ExceptionObject;
        MessageBox.Show($"Unhandled exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        // Log the exception or handle it as needed
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

    static string GetQueryGenInstructions(IDbHelper dbHelper)
    {
        string schemaInfo = dbHelper.GetDbSchema("SK");
        string instructions = $"You are the Query Genarator for role membership. Your task is convert the user input to SQL query based on the database schema below. You ensure that the constraints and rules are followed to maintain data integrity. \n\n {schemaInfo}";
        return instructions;
    }
}