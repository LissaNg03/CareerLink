
using System;
using System.Windows.Forms;
using CareerLink.Data;
using CareerLink.Models;
using CareerLink.Forms.HighSchoolForms;

namespace CareerLink
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.SetUnhandledExceptionMode(
                UnhandledExceptionMode.CatchException);

            Application.ThreadException += (sender, e) =>
                MessageBox.Show(
                    "Something went wrong:\n\n" +
                    e.Exception.Message,
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            string error;

            if (!Db.TryConnect(out error))
            {
                MessageBox.Show(
                    "Could not connect to the CareerLink database.\n\n" +
                    error +
                    "\n\nPlease check that:\n" +
                    "1. SQL Server is running,\n" +
                    "2. you ran CareerLink_SQLServer.sql in SSMS, and\n" +
                    "3. the connection string in Data\\Db.cs matches your server name.",
                    "CareerLink",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            while (true)
            {
                // LOGIN
                Application.Run(new LogInForm());

                if (Session.CurrentUser == null)
                    return;

                // UNDERGRADUATE
                if (Session.CurrentUser.UserType ==
                    UserTypes.Undergraduate)
                {
                    var graduatePortal = new Graduate_Portal();

                    Application.Run(graduatePortal);

                    if (!graduatePortal.LogoutRequested)
                        return;

                    Session.CurrentUser = null;
                    continue;
                }

                // MATRICULANT (GRADE 12)
                // MATRICULANT (GRADE 12)
                else if (string.Equals(
                    Session.CurrentUser.UserType?.Trim(),
                    "Matriculant (Grade 12)",
                    StringComparison.OrdinalIgnoreCase))
                {
                    var grade12Dashboard = new Grade12Dashboard();

                    Application.Run(grade12Dashboard);

                    if (!grade12Dashboard.LogoutRequested)
                        return;

                    Session.CurrentUser = null;

                    continue;
                }

                // OTHER USER TYPES
                else
                {
                    var dashboard = new DashboardForm();

                    Application.Run(dashboard);

                    if (!dashboard.LogoutRequested)
                        return;

                    Session.CurrentUser = null;
                    continue;
                }
            }
        }
    }
}
