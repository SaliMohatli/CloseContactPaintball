using System;
using System.Windows.Forms;
using CloseContactPaintball.Data;

namespace CloseContactPaintball
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                // Ensure SQL Server LocalDB and CloseContactPaintball database are ready
                DatabaseHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Notice: Database auto-initialization message:\n{ex.Message}\n\n" +
                    "If LocalDB is not running, please make sure '(localdb)\\MSSQLLocalDB' is started, or run CloseContactPaintball.sql in SSMS.",
                    "Database Initialization",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            Application.Run(new MainForm());
        }    
    }
}