/* =====================================================================
   CareerLink - SQL Server database script
   ---------------------------------------------------------------------
   Creates the CareerLink database, all tables, and the starter data
   (fields, South African subjects Grades 9-12, streams, careers).

   HOW TO RUN
   1. Open this file in SQL Server Management Studio (SSMS).
   2. Connect to your server (e.g. (localdb)\MSSQLLocalDB or .\SQLEXPRESS).
   3. Press F5 (Execute).

   Safe to rerun for the supplied schema: tables are created only if missing,
   and starter rows are inserted individually when absent.
   All APS thresholds, career mappings, universities and opportunities are
   DEMONSTRATION DATA, not verified official admissions or live vacancies.
   ===================================================================== */

SET NOCOUNT ON;
GO

IF DB_ID(N'CareerLink') IS NULL
    CREATE DATABASE CareerLink;
GO

USE CareerLink;
GO

/* ---------------------------- TABLES ---------------------------- */

IF OBJECT_ID(N'dbo.Fields', N'U') IS NULL
CREATE TABLE dbo.Fields (
    FieldId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Fields PRIMARY KEY,
    FieldName NVARCHAR(100)     NOT NULL CONSTRAINT UQ_Fields_FieldName UNIQUE
);
GO

IF OBJECT_ID(N'dbo.Subjects', N'U') IS NULL
CREATE TABLE dbo.Subjects (
    SubjectId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Subjects PRIMARY KEY,
    SubjectName NVARCHAR(150)     NOT NULL CONSTRAINT UQ_Subjects_SubjectName UNIQUE,
    Category    NVARCHAR(100)     NOT NULL,
    GradeRange  NVARCHAR(50)      NOT NULL
);
GO

IF OBJECT_ID(N'dbo.Streams', N'U') IS NULL
CREATE TABLE dbo.Streams (
    StreamId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Streams PRIMARY KEY,
    FieldId    INT               NOT NULL CONSTRAINT FK_Streams_Fields REFERENCES dbo.Fields(FieldId),
    StreamName NVARCHAR(150)     NOT NULL,
    CONSTRAINT UQ_Streams_Field_Name UNIQUE (FieldId, StreamName)
);
GO

/* SubjectName here is a 'base' name: 'English' is met by English (Home Language)
   OR English (First Additional Language), etc. - so it is plain text, not a foreign key. */
IF OBJECT_ID(N'dbo.StreamRequirements', N'U') IS NULL
CREATE TABLE dbo.StreamRequirements (
    StreamId    INT           NOT NULL CONSTRAINT FK_StreamReq_Streams REFERENCES dbo.Streams(StreamId) ON DELETE CASCADE,
    SubjectName NVARCHAR(150) NOT NULL,
    MinPercent  INT           NOT NULL CONSTRAINT CK_StreamReq_Percent CHECK (MinPercent BETWEEN 0 AND 100),
    CONSTRAINT PK_StreamRequirements PRIMARY KEY (StreamId, SubjectName)
);
GO

IF OBJECT_ID(N'dbo.Careers', N'U') IS NULL
CREATE TABLE dbo.Careers (
    CareerId   INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Careers PRIMARY KEY,
    Keyword    NVARCHAR(100)     NOT NULL CONSTRAINT UQ_Careers_Keyword UNIQUE,
    CareerName NVARCHAR(150)     NOT NULL
);
GO

IF OBJECT_ID(N'dbo.CareerSubjects', N'U') IS NULL
CREATE TABLE dbo.CareerSubjects (
    CareerId    INT           NOT NULL CONSTRAINT FK_CareerSubjects_Careers REFERENCES dbo.Careers(CareerId) ON DELETE CASCADE,
    SubjectName NVARCHAR(150) NOT NULL,
    CONSTRAINT PK_CareerSubjects PRIMARY KEY (CareerId, SubjectName)
);
GO

/* Email is compared ignoring case (like COLLATE NOCASE in the SQLite version).
   PasswordHash / Answer hashes hold the "salt:hash" text made by PasswordHelper.
   Question/Answer columns are NULL for accounts created before security questions existed. */
IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId       INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
    FirstName    NVARCHAR(100)     NOT NULL,
    Surname      NVARCHAR(100)     NOT NULL,
    Email        NVARCHAR(200) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL CONSTRAINT UQ_Users_Email UNIQUE,
    PasswordHash NVARCHAR(200)     NOT NULL,
    UserType     NVARCHAR(50)      NOT NULL,
    Question1    NVARCHAR(200)     NULL,
    Answer1Hash  NVARCHAR(200)     NULL,
    Question2    NVARCHAR(200)     NULL,
    Answer2Hash  NVARCHAR(200)     NULL
);
GO

/* ------------------ INDEPENDENT, RE-RUNNABLE STARTER DATA ------------------ */
/* English Home Language is used for sample career mappings; the current
   recommendation algorithm compares exact subject names. To also support
   First Additional Language fairly, the C# matching algorithm should later
   normalize language variants instead of treating both as mandatory. */

/* Each group is inserted separately. Existing rows are preserved. */


INSERT INTO dbo.Fields (FieldName)
SELECT v.FieldName FROM (VALUES
(N'Engineering studies'),
        (N'Business'),
        (N'Hospitality'),
        (N'Social studies')
) AS v(FieldName)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Fields f WHERE f.FieldName=v.FieldName);
GO



INSERT INTO dbo.Subjects (SubjectName, Category, GradeRange)
SELECT v.SubjectName, v.Category, v.GradeRange FROM (VALUES
(N'Afrikaans (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Afrikaans (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Afrikaans (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'English (Home Language)', N'Languages', N'Grades 9-12'),
        (N'English (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'English (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiNdebele (Home Language)', N'Languages', N'Grades 9-12'),
        (N'isiNdebele (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiNdebele (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiXhosa (Home Language)', N'Languages', N'Grades 9-12'),
        (N'isiXhosa (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiXhosa (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiZulu (Home Language)', N'Languages', N'Grades 9-12'),
        (N'isiZulu (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'isiZulu (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Sepedi (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Sepedi (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Sepedi (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Sesotho (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Sesotho (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Sesotho (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Setswana (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Setswana (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Setswana (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'siSwati (Home Language)', N'Languages', N'Grades 9-12'),
        (N'siSwati (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'siSwati (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Tshivenda (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Tshivenda (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Tshivenda (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Xitsonga (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Xitsonga (First Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Xitsonga (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Arabic (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'French (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'German (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Gujarati (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Hebrew (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Hindi (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Italian (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Latin (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Mandarin (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Modern Greek (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Portuguese (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Serbian (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Spanish (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Tamil (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Telugu (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'Urdu (Second Additional Language)', N'Languages', N'Grades 9-12'),
        (N'South African Sign Language (Home Language)', N'Languages', N'Grades 9-12'),
        (N'Mathematics', N'Mathematics and Sciences', N'Grades 9-12'),
        (N'Mathematical Literacy', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Life Orientation', N'Life Skills', N'Grades 9-12'),
        (N'Physical Sciences', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Life Sciences', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Technical Mathematics', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Technical Sciences', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Geography', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Information Technology', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Computer Applications Technology', N'Mathematics and Sciences', N'Grades 10-12'),
        (N'Accounting', N'Commerce', N'Grades 10-12'),
        (N'Business Studies', N'Commerce', N'Grades 10-12'),
        (N'Economics', N'Commerce', N'Grades 10-12'),
        (N'History', N'Humanities', N'Grades 10-12'),
        (N'Religion Studies', N'Humanities', N'Grades 10-12'),
        (N'Dance Studies', N'Creative Arts', N'Grades 10-12'),
        (N'Design', N'Creative Arts', N'Grades 10-12'),
        (N'Dramatic Arts', N'Creative Arts', N'Grades 10-12'),
        (N'Music', N'Creative Arts', N'Grades 10-12'),
        (N'Visual Arts', N'Creative Arts', N'Grades 10-12'),
        (N'Consumer Studies', N'Services', N'Grades 10-12'),
        (N'Hospitality Studies', N'Services', N'Grades 10-12'),
        (N'Tourism', N'Services', N'Grades 10-12'),
        (N'Civil Technology', N'Engineering and Technology', N'Grades 10-12'),
        (N'Electrical Technology', N'Engineering and Technology', N'Grades 10-12'),
        (N'Mechanical Technology', N'Engineering and Technology', N'Grades 10-12'),
        (N'Engineering Graphics and Design', N'Engineering and Technology', N'Grades 10-12'),
        (N'Agricultural Sciences', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Agricultural Management Practices', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Agricultural Technology', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Equine Studies', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Maritime Economics', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Marine Sciences', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Nautical Science', N'Agriculture and Maritime', N'Grades 10-12'),
        (N'Natural Sciences', N'Grade 9 Learning Areas', N'Grade 9'),
        (N'Social Sciences', N'Grade 9 Learning Areas', N'Grade 9'),
        (N'Technology', N'Grade 9 Learning Areas', N'Grade 9'),
        (N'Economic and Management Sciences', N'Grade 9 Learning Areas', N'Grade 9'),
        (N'Creative Arts', N'Grade 9 Learning Areas', N'Grade 9')
) AS v(SubjectName, Category, GradeRange)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Subjects s WHERE s.SubjectName=v.SubjectName);
GO


INSERT INTO dbo.Streams (FieldId, StreamName)
    SELECT f.FieldId, v.StreamName
    FROM (VALUES
        (N'Engineering studies', N'Civil Engineering'),
        (N'Engineering studies', N'Electrical Engineering'),
        (N'Engineering studies', N'Mechanical Engineering'),
        (N'Business', N'Accounting'),
        (N'Business', N'Business Management'),
        (N'Business', N'Economics'),
        (N'Hospitality', N'Hospitality Management'),
        (N'Hospitality', N'Professional Cookery'),
        (N'Hospitality', N'Tourism Management'),
        (N'Social studies', N'Social Work'),
        (N'Social studies', N'Psychology'),
        (N'Social studies', N'Public Administration')
    ) AS v (FieldName, StreamName)
    JOIN dbo.Fields AS f ON f.FieldName = v.FieldName
WHERE NOT EXISTS (SELECT 1 FROM dbo.Streams existing WHERE existing.FieldId=f.FieldId AND existing.StreamName=v.StreamName);
GO


INSERT INTO dbo.StreamRequirements (StreamId, SubjectName, MinPercent)
    SELECT s.StreamId, v.SubjectName, v.MinPercent
    FROM (VALUES
        (N'Engineering studies', N'Civil Engineering', N'Mathematics', 60),
        (N'Engineering studies', N'Civil Engineering', N'Physical Sciences', 60),
        (N'Engineering studies', N'Electrical Engineering', N'Mathematics', 65),
        (N'Engineering studies', N'Electrical Engineering', N'Physical Sciences', 65),
        (N'Engineering studies', N'Mechanical Engineering', N'Mathematics', 60),
        (N'Engineering studies', N'Mechanical Engineering', N'Physical Sciences', 60),
        (N'Business', N'Accounting', N'Mathematics', 50),
        (N'Business', N'Accounting', N'Accounting', 60),
        (N'Business', N'Business Management', N'English', 50),
        (N'Business', N'Business Management', N'Business Studies', 50),
        (N'Business', N'Economics', N'Mathematics', 60),
        (N'Business', N'Economics', N'Economics', 60),
        (N'Hospitality', N'Hospitality Management', N'English', 50),
        (N'Hospitality', N'Professional Cookery', N'Consumer Studies', 50),
        (N'Hospitality', N'Tourism Management', N'Tourism', 50),
        (N'Hospitality', N'Tourism Management', N'English', 50),
        (N'Social studies', N'Social Work', N'English', 50),
        (N'Social studies', N'Social Work', N'Life Orientation', 50),
        (N'Social studies', N'Psychology', N'English', 60),
        (N'Social studies', N'Psychology', N'Life Sciences', 50),
        (N'Social studies', N'Public Administration', N'English', 50),
        (N'Social studies', N'Public Administration', N'History', 50)
    ) AS v (FieldName, StreamName, SubjectName, MinPercent)
    JOIN dbo.Fields  AS f ON f.FieldName = v.FieldName
    JOIN dbo.Streams AS s ON s.FieldId = f.FieldId AND s.StreamName = v.StreamName
WHERE NOT EXISTS (SELECT 1 FROM dbo.StreamRequirements existing WHERE existing.StreamId=s.StreamId AND existing.SubjectName=v.SubjectName);
GO



INSERT INTO dbo.Careers (Keyword, CareerName)
SELECT v.Keyword, v.CareerName FROM (VALUES
(N'engineer', N'Engineer'),
        (N'doctor', N'Doctor'),
        (N'nurse', N'Nurse'),
            (N'teacher', N'Teacher'),
        (N'lawyer', N'Lawyer'),
        (N'chef', N'Chef'),
        (N'hotel', N'Hotel Manager'),
        (N'programmer', N'Programmer'),
        (N'software', N'Software Developer'),
        (N'social work', N'Social Worker'),
        (N'pilot', N'Pilot'),
        (N'farmer', N'Farmer'),
        (N'architect', N'Architect'),
        (N'electrician', N'Electrician'),
        (N'artist', N'Artist / Designer')
) AS v(Keyword, CareerName)
WHERE NOT EXISTS (SELECT 1 FROM dbo.Careers c WHERE c.Keyword=v.Keyword);
GO


INSERT INTO dbo.CareerSubjects (CareerId, SubjectName)
    SELECT c.CareerId, v.SubjectName
    FROM (VALUES
        (N'engineer', N'Mathematics'),
        (N'engineer', N'Physical Sciences'),
        (N'engineer', N'English (Home Language)'),
        (N'doctor', N'Mathematics'),
        (N'doctor', N'Physical Sciences'),
        (N'doctor', N'Life Sciences'),
        (N'doctor', N'English (Home Language)'),
        (N'nurse', N'Life Sciences'),
        (N'nurse', N'Physical Sciences'),
        (N'nurse', N'English (Home Language)'),
        (N'accountant', N'Mathematics'),
        (N'accountant', N'Accounting'),
        (N'accountant', N'English (Home Language)'),
        (N'teacher', N'English (Home Language)'),
        (N'teacher', N'History'),
        (N'teacher', N'Life Orientation'),
        (N'lawyer', N'English (Home Language)'),
        (N'lawyer', N'History'),
        (N'lawyer', N'Mathematics'),
        (N'chef', N'Consumer Studies'),
        (N'chef', N'Hospitality Studies'),
        (N'chef', N'English (Home Language)'),
        (N'hotel', N'Tourism'),
        (N'hotel', N'Hospitality Studies'),
        (N'hotel', N'English (Home Language)'),
        (N'programmer', N'Mathematics'),
        (N'programmer', N'Information Technology'),
        (N'programmer', N'English (Home Language)'),
        (N'software', N'Mathematics'),
        (N'software', N'Information Technology'),
        (N'software', N'English (Home Language)'),
        (N'social work', N'English (Home Language)'),
        (N'social work', N'Life Orientation'),
        (N'social work', N'Life Sciences'),
        (N'pilot', N'Mathematics'),
        (N'pilot', N'Physical Sciences'),
        (N'pilot', N'English (Home Language)'),
        (N'farmer', N'Agricultural Sciences'),
        (N'farmer', N'Agricultural Management Practices'),
        (N'farmer', N'Mathematics'),
        (N'architect', N'Mathematics'),
        (N'architect', N'Engineering Graphics and Design'),
        (N'architect', N'Physical Sciences'),
        (N'electrician', N'Electrical Technology'),
        (N'electrician', N'Technical Mathematics'),
        (N'electrician', N'Technical Sciences'),
        (N'artist', N'Visual Arts'),
        (N'artist', N'Design'),
        (N'artist', N'English (Home Language)')
    ) AS v (Keyword, SubjectName)
    JOIN dbo.Careers AS c ON c.Keyword = v.Keyword
WHERE NOT EXISTS (
    SELECT 1 FROM dbo.CareerSubjects existing
    WHERE existing.CareerId=c.CareerId AND existing.SubjectName=v.SubjectName
);
GO


/* ------------------------- QUICK CHECKS -------------------------- */
SELECT 'Fields' AS TableName, COUNT(*) AS Rows FROM dbo.Fields
UNION ALL SELECT 'Subjects',           COUNT(*) FROM dbo.Subjects
UNION ALL SELECT 'Streams',            COUNT(*) FROM dbo.Streams
UNION ALL SELECT 'StreamRequirements', COUNT(*) FROM dbo.StreamRequirements
UNION ALL SELECT 'Careers',            COUNT(*) FROM dbo.Careers
UNION ALL SELECT 'CareerSubjects',     COUNT(*) FROM dbo.CareerSubjects
UNION ALL SELECT 'Users',              COUNT(*) FROM dbo.Users;
GO

/* =========================================================
   UNDERGRADUATE / OPPORTUNITY MODULE
   ========================================================= */

/* Additional fields used by the undergraduate course catalogue. */
INSERT INTO dbo.Fields (FieldName)
SELECT v.FieldName
FROM (VALUES
    (N'Information Technology'),
    (N'Engineering'),
    (N'Business and Management'),
    (N'Accounting and Finance'),
    (N'Education'),
    (N'Health Sciences'),
    (N'Law'),
    (N'Media and Communication'),
    (N'Environmental Science')
) AS v(FieldName)
WHERE NOT EXISTS (
    SELECT 1 FROM dbo.Fields f WHERE f.FieldName = v.FieldName
);
GO

/* ---------------------------- COURSES ---------------------------- */
IF OBJECT_ID(N'dbo.Courses', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Courses
    (
        CourseId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Courses PRIMARY KEY,
        CourseName NVARCHAR(150) NOT NULL,
        Institution NVARCHAR(150) NOT NULL,
        FieldId INT NOT NULL,
        CONSTRAINT FK_Courses_Fields
            FOREIGN KEY (FieldId) REFERENCES dbo.Fields(FieldId),
        CONSTRAINT UQ_Courses_Name_Institution
            UNIQUE (CourseName, Institution)
    );
END
GO

/* Demo course catalogue. These are application demo records, not an official
   institutional catalogue. */
INSERT INTO dbo.Courses (CourseName, Institution, FieldId)
SELECT v.CourseName, v.Institution, f.FieldId
FROM (VALUES
    (N'Diploma in Information Technology - Software Development', N'Nelson Mandela University', N'Information Technology'),
    (N'Diploma in Information Technology - Support Services', N'Nelson Mandela University', N'Information Technology'),
    (N'BSc Computer Science', N'Nelson Mandela University', N'Information Technology'),
    (N'Diploma in Management', N'Nelson Mandela University', N'Business and Management'),
    (N'Bachelor of Commerce in Business Management', N'Nelson Mandela University', N'Business and Management'),
    (N'Diploma in Human Resource Management', N'Nelson Mandela University', N'Business and Management'),
    (N'Bachelor of Commerce in Accounting', N'Nelson Mandela University', N'Accounting and Finance'),
    (N'Diploma in Financial Information Systems', N'Nelson Mandela University', N'Accounting and Finance'),
    (N'Bachelor of Engineering Technology in Electrical Engineering', N'Nelson Mandela University', N'Engineering'),
    (N'Bachelor of Engineering Technology in Mechanical Engineering', N'Nelson Mandela University', N'Engineering'),
    (N'Diploma in Civil Engineering', N'Nelson Mandela University', N'Engineering'),
    (N'Bachelor of Education', N'Nelson Mandela University', N'Education'),
    (N'Bachelor of Laws', N'Nelson Mandela University', N'Law'),
    (N'Diploma in Media Studies', N'Nelson Mandela University', N'Media and Communication')
) AS v(CourseName, Institution, FieldName)
JOIN dbo.Fields f ON f.FieldName = v.FieldName
WHERE NOT EXISTS (
    SELECT 1
    FROM dbo.Courses c
    WHERE c.CourseName = v.CourseName
      AND c.Institution = v.Institution
);
GO

/* ------------------------ STUDENT PROFILES ------------------------ */
IF OBJECT_ID(N'dbo.StudentProfiles', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.StudentProfiles
    (
        StudentProfileId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_StudentProfiles PRIMARY KEY,
        UserId INT NOT NULL,
        CourseId INT NOT NULL,
        YearOfStudy INT NOT NULL,
        CONSTRAINT FK_StudentProfiles_Users
            FOREIGN KEY (UserId) REFERENCES dbo.Users(UserId) ON DELETE CASCADE,
        CONSTRAINT FK_StudentProfiles_Courses
            FOREIGN KEY (CourseId) REFERENCES dbo.Courses(CourseId),
        CONSTRAINT UQ_StudentProfiles_User UNIQUE (UserId),
        CONSTRAINT CK_StudentProfiles_YearOfStudy CHECK (YearOfStudy BETWEEN 1 AND 10)
    );
END
GO

/* -------------------------- OPPORTUNITIES -------------------------- */
IF OBJECT_ID(N'dbo.Opportunities', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Opportunities
    (
        OpportunityId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Opportunities PRIMARY KEY,
        Title NVARCHAR(150) NOT NULL,
        Company NVARCHAR(150) NOT NULL,
        OpportunityType NVARCHAR(50) NOT NULL,
        Description NVARCHAR(MAX) NULL,
        Requirements NVARCHAR(MAX) NULL,
        Location NVARCHAR(150) NULL,
        ClosingDate DATE NULL,
        ApplicationURL NVARCHAR(500) NULL,
        IsActive BIT NOT NULL CONSTRAINT DF_Opportunities_IsActive DEFAULT 1,
        CreatedAt DATETIME2 NOT NULL CONSTRAINT DF_Opportunities_CreatedAt DEFAULT SYSDATETIME(),
        CONSTRAINT CK_Opportunities_Type CHECK
        (
            OpportunityType IN
            (
                N'Part-Time Job', N'Full-Time Job', N'Internship', N'Bursary',
                N'Learnership', N'Hackathon', N'Graduate Programme', N'Volunteer'
            )
        )
    );
END
GO

/* ---------------------- OPPORTUNITY COURSES ---------------------- */
IF OBJECT_ID(N'dbo.OpportunityCourses', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.OpportunityCourses
    (
        OpportunityId INT NOT NULL,
        CourseId INT NOT NULL,
        CONSTRAINT PK_OpportunityCourses PRIMARY KEY (OpportunityId, CourseId),
        CONSTRAINT FK_OpportunityCourses_Opportunities
            FOREIGN KEY (OpportunityId) REFERENCES dbo.Opportunities(OpportunityId) ON DELETE CASCADE,
        CONSTRAINT FK_OpportunityCourses_Courses
            FOREIGN KEY (CourseId) REFERENCES dbo.Courses(CourseId)
    );
END
GO

/* -------------------- OPPORTUNITY APPLICATIONS -------------------- */
IF OBJECT_ID(N'dbo.OpportunityApplications', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.OpportunityApplications
    (
        ApplicationId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_OpportunityApplications PRIMARY KEY,
        UserId INT NOT NULL,
        OpportunityId INT NOT NULL,
        ApplicationDate DATETIME2 NOT NULL
            CONSTRAINT DF_OpportunityApplications_ApplicationDate DEFAULT SYSDATETIME(),
        Status NVARCHAR(30) NOT NULL
            CONSTRAINT DF_OpportunityApplications_Status DEFAULT N'Applied',
        CONSTRAINT FK_OpportunityApplications_Users
            FOREIGN KEY (UserId) REFERENCES dbo.Users(UserId) ON DELETE CASCADE,
        CONSTRAINT FK_OpportunityApplications_Opportunities
            FOREIGN KEY (OpportunityId) REFERENCES dbo.Opportunities(OpportunityId) ON DELETE CASCADE,
        CONSTRAINT UQ_OpportunityApplications_UserOpportunity UNIQUE (UserId, OpportunityId),
        CONSTRAINT CK_OpportunityApplications_Status
            CHECK (Status IN (N'Applied', N'Under Review', N'Accepted', N'Rejected', N'Withdrawn'))
    );
END
GO

/* =========================================================
   DEMO OPPORTUNITY DATA
   Fictional organisations / URLs for demonstration purposes.
   Bursaries are intentionally NOT linked to undergraduate courses;
   CareerLink reserves bursaries for the high-school learner side.
   ========================================================= */
INSERT INTO dbo.Opportunities
    (Title, Company, OpportunityType, Description, Requirements, Location, ClosingDate, ApplicationURL)
SELECT v.Title, v.Company, v.OpportunityType, v.Description, v.Requirements,
       v.Location, v.ClosingDate, v.ApplicationURL
FROM (VALUES
    /* IT */
    (N'Software Development Internship', N'Cape Digital Labs', N'Internship', N'Gain practical experience developing web and software applications.', N'IT, Software Development or Computer Science student with programming fundamentals.', N'Cape Town', CAST('2026-11-30' AS date), N'https://example.com/software-internship'),
    (N'IT Support Internship', N'TechBridge Solutions', N'Internship', N'Assist with desktop support, troubleshooting and hardware configuration.', N'IT student with basic hardware, software and networking knowledge.', N'Gqeberha', CAST('2026-11-25' AS date), N'https://example.com/it-support-internship'),
    (N'Mobile App Development Internship', N'AppForge Africa', N'Internship', N'Work with developers building mobile applications and supporting APIs.', N'IT or Computer Science student with programming fundamentals.', N'Remote', CAST('2026-12-05' AS date), N'https://example.com/mobile-development'),
    (N'Junior Web Developer', N'Eastern Cape Digital', N'Part-Time Job', N'Assist with websites and internal web applications.', N'HTML, CSS and JavaScript knowledge; React is advantageous.', N'Gqeberha', CAST('2026-12-15' AS date), N'https://example.com/junior-web-developer'),
    (N'Junior Software Developer', N'AlgoWorks SA', N'Full-Time Job', N'Join a junior development team building business applications.', N'IT, Software Development or Computer Science qualification.', N'Gqeberha', CAST('2026-12-20' AS date), N'https://example.com/junior-software-developer'),
    (N'Cloud Support Learnership', N'CloudSkills Africa', N'Learnership', N'Structured training in cloud computing and technical support.', N'Interest in IT and cloud technologies.', N'South Africa', CAST('2026-12-18' AS date), N'https://example.com/cloud-learnership'),
    (N'Web Development Learnership', N'DevLaunch Academy', N'Learnership', N'Practical training in frontend and backend web development.', N'Basic programming knowledge and interest in software development.', N'Gqeberha', CAST('2026-12-22' AS date), N'https://example.com/web-learnership'),
    (N'National Student Coding Challenge', N'CodeConnect SA', N'Hackathon', N'Student teams build technology solutions to real-world challenges.', N'Open to IT and Computer Science students.', N'Online', CAST('2026-11-20' AS date), N'https://example.com/coding-challenge'),

    /* Business / HR */
    (N'Human Resources Internship', N'Ubuntu People Solutions', N'Internship', N'Assist with recruitment, employee records and HR administration.', N'HR or Business Management student.', N'Gqeberha', CAST('2026-12-01' AS date), N'https://example.com/hr-internship'),
    (N'Business Administration Intern', N'GrowthPath Consulting', N'Internship', N'Support administration, reporting and client service activities.', N'Business Management or Administration student.', N'Johannesburg', CAST('2026-12-08' AS date), N'https://example.com/business-internship'),
    (N'Junior HR Assistant', N'PeopleCore SA', N'Part-Time Job', N'Provide support with employee documentation and recruitment.', N'HR or Business student with good organisational skills.', N'Gqeberha', CAST('2026-12-15' AS date), N'https://example.com/hr-assistant'),
    (N'Business Administration Learnership', N'SkillsForward SA', N'Learnership', N'Workplace learning focused on administration and business operations.', N'Interest in business administration.', N'South Africa', CAST('2026-12-12' AS date), N'https://example.com/business-learnership'),

    /* Accounting / Finance */
    (N'Accounting Internship', N'LedgerPoint Advisory', N'Internship', N'Assist with reconciliations and financial records.', N'Accounting, Finance or Financial Information Systems student.', N'Gqeberha', CAST('2026-12-05' AS date), N'https://example.com/accounting-internship'),
    (N'Finance Graduate Programme', N'CapitalEdge SA', N'Graduate Programme', N'Graduate programme covering financial analysis and business finance.', N'Final-year or recently graduated Accounting or Finance student.', N'Johannesburg', CAST('2026-11-30' AS date), N'https://example.com/finance-graduate'),
    (N'Junior Accounts Assistant', N'BalanceWorks', N'Part-Time Job', N'Assist with invoices, records and bookkeeping.', N'Accounting or Finance student.', N'Gqeberha', CAST('2026-12-20' AS date), N'https://example.com/accounts-assistant'),

    /* Engineering */
    (N'Electrical Engineering Internship', N'PowerGrid Engineering', N'Internship', N'Support electrical systems and engineering projects.', N'Electrical Engineering student.', N'Gqeberha', CAST('2026-11-28' AS date), N'https://example.com/electrical-internship'),
    (N'Mechanical Engineering Internship', N'Industrial Dynamics SA', N'Internship', N'Work alongside engineers on mechanical and industrial projects.', N'Mechanical Engineering student.', N'East London', CAST('2026-12-04' AS date), N'https://example.com/mechanical-internship'),
    (N'Civil Engineering Student Intern', N'BuildAfrica Engineering', N'Internship', N'Assist with infrastructure and construction projects.', N'Civil Engineering student.', N'Gqeberha', CAST('2026-12-10' AS date), N'https://example.com/civil-internship'),
    (N'Junior Engineering Assistant', N'Eastern Engineering Group', N'Part-Time Job', N'Support project documentation and technical activities.', N'Engineering student or recent graduate.', N'Gqeberha', CAST('2026-12-20' AS date), N'https://example.com/engineering-assistant'),

    /* Education */
    (N'Learning Support Internship', N'BrightSchools Network', N'Internship', N'Assist teachers and learning support teams.', N'Education student.', N'Eastern Cape', CAST('2026-12-08' AS date), N'https://example.com/education-internship'),
    (N'Student Teaching Assistant', N'FutureLearn Academy', N'Part-Time Job', N'Assist educators with classroom activities and student support.', N'Education student with strong communication skills.', N'Gqeberha', CAST('2026-12-15' AS date), N'https://example.com/teaching-assistant'),
    (N'Community Tutoring Programme', N'LearnTogether', N'Volunteer', N'Support school learners through tutoring and mentoring.', N'Education students or students interested in tutoring.', N'Gqeberha', CAST('2026-12-20' AS date), N'https://example.com/community-tutoring'),

    /* Law */
    (N'Legal Services Internship', N'Mthetho Legal Group', N'Internship', N'Gain exposure to legal research and case preparation.', N'Law student.', N'Gqeberha', CAST('2026-12-03' AS date), N'https://example.com/legal-internship'),
    (N'Community Legal Support Volunteer', N'Access Justice Centre', N'Volunteer', N'Assist with administrative and legal research activities.', N'Law student interested in community legal services.', N'Gqeberha', CAST('2026-12-18' AS date), N'https://example.com/legal-volunteer'),

    /* Media */
    (N'Digital Media Internship', N'CreativeWave Media', N'Internship', N'Assist with digital campaigns, content creation and social media.', N'Media or Communication student.', N'Cape Town', CAST('2026-12-04' AS date), N'https://example.com/media-internship'),
    (N'Social Media Assistant', N'SocialSpark Agency', N'Part-Time Job', N'Assist with social media content and audience engagement.', N'Media or Communication student with strong writing skills.', N'Remote', CAST('2026-12-15' AS date), N'https://example.com/social-media-assistant'),
    (N'Digital Content Challenge', N'CreativeSA', N'Hackathon', N'Teams create innovative digital media campaigns.', N'Open to Media and Communication students.', N'Online', CAST('2026-11-25' AS date), N'https://example.com/media-challenge')
) AS v(Title, Company, OpportunityType, Description, Requirements, Location, ClosingDate, ApplicationURL)
WHERE NOT EXISTS
(
    SELECT 1
    FROM dbo.Opportunities o
    WHERE o.Title = v.Title AND o.Company = v.Company
);
GO

/* =========================================================
   LINK DEMO OPPORTUNITIES TO RELEVANT UNDERGRADUATE COURSES
   ========================================================= */

/* Information Technology */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Information Technology'
  AND o.Title IN
  (
      N'Software Development Internship', N'IT Support Internship',
      N'Mobile App Development Internship', N'Junior Web Developer',
      N'Junior Software Developer', N'Cloud Support Learnership',
      N'Web Development Learnership', N'National Student Coding Challenge'
  )
  AND NOT EXISTS
  (
      SELECT 1 FROM dbo.OpportunityCourses oc
      WHERE oc.OpportunityId = o.OpportunityId AND oc.CourseId = c.CourseId
  );
GO

/* Business and Management */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Business and Management'
  AND o.Title IN
  (N'Human Resources Internship', N'Business Administration Intern',
   N'Junior HR Assistant', N'Business Administration Learnership')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* Accounting and Finance */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Accounting and Finance'
  AND o.Title IN (N'Accounting Internship', N'Finance Graduate Programme', N'Junior Accounts Assistant')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* Engineering */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Engineering'
  AND o.Title IN
  (N'Electrical Engineering Internship', N'Mechanical Engineering Internship',
   N'Civil Engineering Student Intern', N'Junior Engineering Assistant')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* Education */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Education'
  AND o.Title IN (N'Learning Support Internship', N'Student Teaching Assistant', N'Community Tutoring Programme')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* Law */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Law'
  AND o.Title IN (N'Legal Services Internship', N'Community Legal Support Volunteer')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* Media and Communication */
INSERT INTO dbo.OpportunityCourses (OpportunityId, CourseId)
SELECT o.OpportunityId, c.CourseId
FROM dbo.Opportunities o
CROSS JOIN dbo.Courses c
JOIN dbo.Fields f ON f.FieldId = c.FieldId
WHERE f.FieldName = N'Media and Communication'
  AND o.Title IN (N'Digital Media Internship', N'Social Media Assistant', N'Digital Content Challenge')
  AND NOT EXISTS
  (SELECT 1 FROM dbo.OpportunityCourses oc WHERE oc.OpportunityId=o.OpportunityId AND oc.CourseId=c.CourseId);
GO

/* ------------------------- FINAL CHECKS ------------------------- */
SELECT 'Fields' AS TableName, COUNT(*) AS Rows FROM dbo.Fields
UNION ALL SELECT 'Subjects', COUNT(*) FROM dbo.Subjects
UNION ALL SELECT 'Streams', COUNT(*) FROM dbo.Streams
UNION ALL SELECT 'StreamRequirements', COUNT(*) FROM dbo.StreamRequirements
UNION ALL SELECT 'Careers', COUNT(*) FROM dbo.Careers
UNION ALL SELECT 'CareerSubjects', COUNT(*) FROM dbo.CareerSubjects
UNION ALL SELECT 'Users', COUNT(*) FROM dbo.Users
UNION ALL SELECT 'Courses', COUNT(*) FROM dbo.Courses
UNION ALL SELECT 'StudentProfiles', COUNT(*) FROM dbo.StudentProfiles
UNION ALL SELECT 'Opportunities', COUNT(*) FROM dbo.Opportunities
UNION ALL SELECT 'OpportunityCourses', COUNT(*) FROM dbo.OpportunityCourses
UNION ALL SELECT 'OpportunityApplications', COUNT(*) FROM dbo.OpportunityApplications;
GO

/* CareerLink Grade 12 extension. Run against the EXISTING database.
   Seeded institutions/courses are DEMONSTRATION DATA, not verified live admissions.
   Does not drop or overwrite existing tables or rows. */
USE [CareerLink];
GO
SET XACT_ABORT ON;
GO
BEGIN TRY
    BEGIN TRANSACTION;

    IF OBJECT_ID(N'dbo.Universities', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.Universities
        (
            UniversityId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_Universities PRIMARY KEY,
            UniversityName NVARCHAR(200) NOT NULL,
            Province NVARCHAR(100) NOT NULL,
            City NVARCHAR(100) NOT NULL,
            Website NVARCHAR(500) NULL,
            CONSTRAINT UQ_Universities_UniversityName UNIQUE (UniversityName)
        );
    END;

    IF OBJECT_ID(N'dbo.UniversityCourses', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.UniversityCourses
        (
            UniversityCourseId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_UniversityCourses PRIMARY KEY,
            UniversityId INT NOT NULL,
            CourseName NVARCHAR(200) NOT NULL,
            QualificationType NVARCHAR(80) NOT NULL,
            MinimumAPS INT NOT NULL,
            DurationYears INT NOT NULL,
            IsOpen BIT NOT NULL CONSTRAINT DF_UniversityCourses_IsOpen DEFAULT (0),
            CONSTRAINT FK_UniversityCourses_Universities FOREIGN KEY (UniversityId)
                REFERENCES dbo.Universities(UniversityId),
            CONSTRAINT CK_UniversityCourses_APS CHECK (MinimumAPS BETWEEN 0 AND 56),
            CONSTRAINT CK_UniversityCourses_Duration CHECK (DurationYears BETWEEN 1 AND 10),
            CONSTRAINT UQ_UniversityCourses_NameQualification UNIQUE
                (UniversityId, CourseName, QualificationType)
        );
    END;

    IF OBJECT_ID(N'dbo.CourseApplications', N'U') IS NULL
    BEGIN
        CREATE TABLE dbo.CourseApplications
        (
            ApplicationId INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_CourseApplications PRIMARY KEY,
            UserId INT NOT NULL,
            UniversityCourseId INT NOT NULL,
            ApplicationDate DATETIME2(7) NOT NULL
                CONSTRAINT DF_CourseApplications_Date DEFAULT (SYSDATETIME()),
            Status NVARCHAR(50) NOT NULL
                CONSTRAINT DF_CourseApplications_Status DEFAULT (N'Pending'),
            CONSTRAINT FK_CourseApplications_Users FOREIGN KEY (UserId)
                REFERENCES dbo.Users(UserId),
            CONSTRAINT FK_CourseApplications_UniversityCourses FOREIGN KEY (UniversityCourseId)
                REFERENCES dbo.UniversityCourses(UniversityCourseId),
            CONSTRAINT UQ_CourseApplications_UserCourse UNIQUE (UserId, UniversityCourseId),
            CONSTRAINT CK_CourseApplications_Status CHECK
                (Status IN (N'Pending', N'Under Review', N'Accepted', N'Rejected'))
        );
    END;

    /* DEMONSTRATION institutions; details are not live-verified. */
    DECLARE @Universities TABLE
    (
        UniversityName NVARCHAR(200), Province NVARCHAR(100),
        City NVARCHAR(100), Website NVARCHAR(500)
    );
    INSERT INTO @Universities VALUES
    (N'Nelson Mandela University', N'Eastern Cape', N'Gqeberha', N'https://www.mandela.ac.za'),
    (N'University of Cape Town', N'Western Cape', N'Cape Town', N'https://www.uct.ac.za'),
    (N'University of Pretoria', N'Gauteng', N'Pretoria', N'https://www.up.ac.za'),
    (N'Rhodes University', N'Eastern Cape', N'Makhanda', N'https://www.ru.ac.za'),
    (N'University of Johannesburg', N'Gauteng', N'Johannesburg', N'https://www.uj.ac.za');

    INSERT INTO dbo.Universities (UniversityName, Province, City, Website)
    SELECT s.UniversityName, s.Province, s.City, s.Website
    FROM @Universities s
    WHERE NOT EXISTS
        (SELECT 1 FROM dbo.Universities u WHERE u.UniversityName = s.UniversityName);

    /* DEMONSTRATION course names/APS/durations only.
       IsOpen=1 here means OPEN IN THE DEMO, not real-world admission availability. */
    DECLARE @Courses TABLE
    (
        UniversityName NVARCHAR(200), CourseName NVARCHAR(200),
        QualificationType NVARCHAR(80), MinimumAPS INT,
        DurationYears INT, IsOpen BIT
    );
    INSERT INTO @Courses VALUES
    (N'Nelson Mandela University', N'Diploma in Information Technology', N'Diploma', 24, 3, 1),
    (N'Nelson Mandela University', N'Bachelor of Commerce', N'Bachelor''s Degree', 30, 3, 1),
    (N'Nelson Mandela University', N'Higher Certificate in Business Studies', N'Higher Certificate', 20, 1, 0),
    (N'University of Cape Town', N'Bachelor of Science', N'Bachelor''s Degree', 36, 3, 1),
    (N'University of Cape Town', N'Bachelor of Commerce', N'Bachelor''s Degree', 35, 3, 0),
    (N'University of Pretoria', N'Bachelor of Engineering', N'Bachelor''s Degree', 36, 4, 1),
    (N'University of Pretoria', N'Bachelor of Science', N'Bachelor''s Degree', 32, 3, 1),
    (N'Rhodes University', N'Bachelor of Arts', N'Bachelor''s Degree', 28, 3, 1),
    (N'Rhodes University', N'Bachelor of Science', N'Bachelor''s Degree', 30, 3, 0),
    (N'University of Johannesburg', N'Diploma in Business Management', N'Diploma', 24, 3, 1),
    (N'University of Johannesburg', N'Bachelor of Commerce', N'Bachelor''s Degree', 30, 3, 1),
    (N'University of Johannesburg', N'Higher Certificate in Information Technology', N'Higher Certificate', 20, 1, 1);

    INSERT INTO dbo.UniversityCourses
        (UniversityId, CourseName, QualificationType, MinimumAPS, DurationYears, IsOpen)
    SELECT u.UniversityId, s.CourseName, s.QualificationType,
           s.MinimumAPS, s.DurationYears, s.IsOpen
    FROM @Courses s
    INNER JOIN dbo.Universities u ON u.UniversityName = s.UniversityName
    WHERE NOT EXISTS
    (
        SELECT 1 FROM dbo.UniversityCourses c
        WHERE c.UniversityId = u.UniversityId
          AND c.CourseName = s.CourseName
          AND c.QualificationType = s.QualificationType
    );

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO

/* Verify stats expected by Grade12Dashboard */
SELECT (SELECT COUNT(*) FROM dbo.Universities) AS TotalUniversities,
       (SELECT COUNT(*) FROM dbo.UniversityCourses WHERE IsOpen = 1) AS OpenDemoCourses,
       (SELECT COUNT(*) FROM dbo.CourseApplications) AS TotalCourseApplications;
GO
SELECT TOP (20) u.UniversityName, c.CourseName, c.QualificationType,
       c.MinimumAPS, c.DurationYears, c.IsOpen
FROM dbo.UniversityCourses c
JOIN dbo.Universities u ON u.UniversityId = c.UniversityId
ORDER BY u.UniversityName, c.CourseName;
GO


INSERT INTO dbo.Careers (Keyword, CareerName)
SELECT v.Keyword, v.CareerName
FROM (VALUES
    (N'civil-engineer', N'Civil Engineer'),
    (N'data-analyst', N'Data Analyst'),
    (N'journalist', N'Journalist')
) v(Keyword, CareerName)
WHERE NOT EXISTS (
    SELECT 1 FROM dbo.Careers c
    WHERE c.Keyword = v.Keyword
);
GO

INSERT INTO dbo.CareerSubjects (CareerId, SubjectName)
SELECT c.CareerId, v.SubjectName
FROM (VALUES
    (N'software', N'Mathematics'),
    (N'software', N'Information Technology'),
    (N'civil-engineer', N'Mathematics'),
    (N'civil-engineer', N'Physical Sciences'),
    (N'data-analyst', N'Mathematics'),
    (N'data-analyst', N'Information Technology'),
    (N'accountant', N'Accounting'),
    (N'accountant', N'Mathematics'),
    (N'doctor', N'Life Sciences'),
    (N'doctor', N'Physical Sciences'),
    (N'doctor', N'Mathematics'),
    (N'journalist', N'English (Home Language)'),
    (N'journalist', N'History')
) v(Keyword, SubjectName)
INNER JOIN dbo.Careers c
    ON c.Keyword = v.Keyword
INNER JOIN dbo.Subjects s
    ON s.SubjectName = v.SubjectName
WHERE NOT EXISTS (
    SELECT 1
    FROM dbo.CareerSubjects cs
    WHERE cs.CareerId = c.CareerId
      AND cs.SubjectName = v.SubjectName
);
GO
