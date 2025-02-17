using SKFunctionCalling;
using SKLIb;
using static SKFunctionCalling.DbHelper;
using static SKFunctionCalling.RoleService;
using static System.Configuration.ConfigurationManager;


namespace SKFunctionCallingWinform;

internal static class Program
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
 @$"-----------------------------------------------------------------------------------------------------
This is a simple implementation of Function Calling in Semantic Kernel using AzureOpenAI.
Function Calling allows you to call function in your applications using natural language.
You may start by introducing youself or asking questions like ""What can you do for me?"" 
or ""Show me some commands""

Endpoint: {endpoint} 
   Model: {deployment}
--------------------------------------------------------------------------------------------------------";
        Application.Run(new Form1(functionCaller ,chatBanner));
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
}