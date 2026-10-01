CAREERLINK - Windows Forms front end for the SQL Server "CareerLink" database
=============================================================================
Built the way the T4 lecture teaches: 3-tier architecture + ADO.NET (Microsoft.Data.SqlClient).

SET UP (3 steps)
1. In SSMS, open Database\CareerLink_SQLServer.sql and press F5. This creates the CareerLink
   database with all tables and the starter data.
2. Open CareerLink.sln in Visual Studio. NuGet restores Microsoft.Data.SqlClient by itself.
   (The lecture uses .NET 9. If your Visual Studio is different, change <TargetFramework>
   in CareerLink\CareerLink.csproj, e.g. net8.0-windows.)
3. Open CareerLink\Repositories\Db.cs and check the connection string:
      Data Source=.                       (this computer, as in the lecture)
      Data Source=.\SQLEXPRESS            (SQL Server Express)
      Data Source=(localdb)\MSSQLLocalDB  (LocalDB)
   You can also copy the connectionString from Server Explorer -> your database -> Properties.
   Then press F5.

FIRST RUN
Click "Create new account". The FIRST account created becomes the Admin, and Admins see the
admin tools on the dashboard (Manage Users / Subjects / Streams / Careers).

PROJECT STRUCTURE  (Flow of control: Presentation -> Business Logic -> Data Access)
Models\            classes that hold data (User, Subject, Field, StudyStream, Career)
Repositories\      DATA ACCESS LAYER - SqlConnection / SqlCommand / SqlDataReader, @parameters
BusinessLogic\     BUSINESS LOGIC LAYER - validation rules, password hashing, calculations
*Form.cs           PRESENTATION LAYER - Windows Forms (never touch the database directly)

CRUD (same pattern as the lecture's Products Manager)
Manage Users      list + Add User (sign-up form) / Edit User / Delete User
Manage Subjects   list + search + Add / Edit / Delete
Manage Streams    list + Add / Edit / Delete   (requirements: one per line, "Mathematics: 60")
Manage Careers    list + Add / Edit / Delete   (subjects: one per line)
