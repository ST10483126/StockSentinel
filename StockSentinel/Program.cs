using StockSentinel.Data;

namespace StockSentinel;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            DbSeeder.SeedAsync().Wait();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database seeding failed: {ex.Message}");
        }

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}