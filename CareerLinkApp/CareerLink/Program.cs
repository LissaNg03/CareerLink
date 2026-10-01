using System;
using System.Windows.Forms;
using CareerLink.Repositories;

namespace CareerLink
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) =>
                MessageBox.Show("Something went wrong:\n\n" + e.Exception.Message,
                                "CareerLink", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            string error;
            if (!Db.TryConnect(out error))
            {
                MessageBox.Show(
                    "Could not connect to the CareerLink database.\n\n" + error + "\n\n" +
                    "Please check that:\n" +
                    "1. SQL Server is running,\n" +
                    "2. you ran CareerLink_SQLServer.sql in SSMS, and\n" +
                    "3. the connection string in Repositories\\Db.cs matches your server name.",
                    "CareerLink", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            while (true)
            {
                
                Application.Run(new MainForm());

                if (Session.CurrentUser == null)
                    return;                      

                
                var dashboard = new DashboardForm();
                Application.Run(dashboard);

                if (!dashboard.LogoutRequested)
                    return;                      

                Session.CurrentUser = null;      
            }
        }
    }
}
