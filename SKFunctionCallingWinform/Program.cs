using static SKFunctionCalling.DbHelper;
using static SKFunctionCalling.RoleService;


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
#endif
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
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