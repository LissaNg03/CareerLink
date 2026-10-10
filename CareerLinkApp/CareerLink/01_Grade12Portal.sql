-- Run in your EXISTING CareerLink database. Adjust USE as needed.
-- USE [CareerLinkDB];
-- GO
IF OBJECT_ID('dbo.Universities','U') IS NULL
BEGIN
 CREATE TABLE dbo.Universities(
 UniversityId INT IDENTITY(1,1) PRIMARY KEY,
 UniversityName NVARCHAR(180) NOT NULL UNIQUE,
 Province NVARCHAR(80) NOT NULL,
 Website NVARCHAR(300) NULL
 );
END;
IF OBJECT_ID('dbo.UniversityCourses','U') IS NULL
BEGIN
 CREATE TABLE dbo.UniversityCourses(
 CourseId INT IDENTITY(1,1) PRIMARY KEY,
 UniversityId INT NOT NULL REFERENCES dbo.Universities(UniversityId),
 CourseName NVARCHAR(180) NOT NULL,
 Faculty NVARCHAR(120) NULL,
 QualificationType NVARCHAR(60) NULL,
 MinimumAPS INT NULL CHECK (MinimumAPS BETWEEN 0 AND 60),
 DurationYears INT NULL CHECK (DurationYears BETWEEN 1 AND 10),
 IsOpen BIT NOT NULL DEFAULT 1,
 IsIllustrative BIT NOT NULL DEFAULT 1,
 CONSTRAINT UQ_UniversityCourses UNIQUE(UniversityId,CourseName)
 );
END;
IF OBJECT_ID('dbo.CourseApplications','U') IS NULL
BEGIN
 CREATE TABLE dbo.CourseApplications(
 ApplicationId INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT NOT NULL,
 CourseId INT NOT NULL REFERENCES dbo.UniversityCourses(CourseId),
 ApplicationDate DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
 Status NVARCHAR(30) NOT NULL DEFAULT 'Submitted',
 ApplicantAPS INT NULL CHECK (ApplicantAPS BETWEEN 0 AND 60),
 Notes NVARCHAR(500) NULL,
 CONSTRAINT CK_CourseApplications_Status CHECK (Status IN ('Submitted','Under Review','Accepted','Rejected','Withdrawn')),
 CONSTRAINT UQ_CourseApplications UNIQUE(UserId,CourseId)
 );
 CREATE INDEX IX_CourseApplications_UserId ON dbo.CourseApplications(UserId);
END;
-- Adapt the FK below if your Users primary key/table differs.
IF OBJECT_ID('dbo.Users','U') IS NOT NULL
 AND COL_LENGTH('dbo.Users','UserId') IS NOT NULL
 AND NOT EXISTS(SELECT 1 FROM sys.foreign_keys WHERE name='FK_CourseApplications_Users')
BEGIN
 ALTER TABLE dbo.CourseApplications WITH CHECK
 ADD CONSTRAINT FK_CourseApplications_Users FOREIGN KEY(UserId) REFERENCES dbo.Users(UserId);
END;
MERGE dbo.Universities AS t
USING (VALUES
 (N'Nelson Mandela University',N'Eastern Cape',N'https://www.mandela.ac.za'),
 (N'University of Cape Town',N'Western Cape',N'https://www.uct.ac.za'),
 (N'University of Pretoria',N'Gauteng',N'https://www.up.ac.za'),
 (N'University of the Witwatersrand',N'Gauteng',N'https://www.wits.ac.za'),
 (N'University of Johannesburg',N'Gauteng',N'https://www.uj.ac.za'),
 (N'Rhodes University',N'Eastern Cape',N'https://www.ru.ac.za')) AS s(UniversityName,Province,Website)
ON t.UniversityName=s.UniversityName
WHEN NOT MATCHED THEN INSERT(UniversityName,Province,Website) VALUES(s.UniversityName,s.Province,s.Website);
-- These course/APS combinations are illustrative placeholders, NOT official admission requirements.
INSERT INTO dbo.UniversityCourses(UniversityId,CourseName,Faculty,QualificationType,MinimumAPS,DurationYears)
SELECT u.UniversityId, v.CourseName,v.Faculty,v.QualificationType,v.MinimumAPS,v.DurationYears
FROM (VALUES
 (N'Nelson Mandela University',N'Diploma in Information Technology',N'Computing',N'Diploma',28,3),
 (N'Nelson Mandela University',N'Bachelor of Commerce',N'Business',N'Degree',34,3),
 (N'University of Cape Town',N'Bachelor of Science',N'Science',N'Degree',38,3),
 (N'University of Pretoria',N'Bachelor of Education',N'Education',N'Degree',32,4),
 (N'University of Johannesburg',N'Diploma in Business Management',N'Business',N'Diploma',26,3),
 (N'Rhodes University',N'Bachelor of Arts',N'Humanities',N'Degree',32,3)) v(UniversityName,CourseName,Faculty,QualificationType,MinimumAPS,DurationYears)
JOIN dbo.Universities u ON u.UniversityName=v.UniversityName
WHERE NOT EXISTS (SELECT 1 FROM dbo.UniversityCourses c WHERE c.UniversityId=u.UniversityId AND c.CourseName=v.CourseName);
