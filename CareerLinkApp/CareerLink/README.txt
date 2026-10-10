Grade 12 Portal - CareerLink / StudentSuccess7

Files:
01_Grade12Portal.sql - SQL Server tables and sample universities (sample courses only)
Db.cs - ADO.NET connection helper
Grade12Dashboard.cs - Dashboard UI and event handlers
UniversitiesForm.cs - University directory
AvailableCoursesForm.cs - Course browsing
CourseApplicationForm.cs - Application submission
MyApplicationsForm.cs - Application review

Set Db.ConnectionString to your SQL Server database. Pass the authenticated Users.UserId into new Grade12Dashboard(userId, firstName). The forms are constructed in code, so do not add designer files for them.

Application records are INTERNAL DEMO RECORDS, not actual university submissions. Course examples and APS thresholds are fictional and must be verified before public use.
