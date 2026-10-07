/* =====================================================================
   CareerLink - SQL Server database script
   ---------------------------------------------------------------------
   Creates the CareerLink database, all tables, and the starter data
   (fields, South African subjects Grades 9-12, streams, careers).

   HOW TO RUN
   1. Open this file in SQL Server Management Studio (SSMS).
   2. Connect to your server (e.g. (localdb)\MSSQLLocalDB or .\SQLEXPRESS).
   3. Press F5 (Execute).

   Safe to run more than once: tables are only created if missing and the
   starter data is only inserted when the database is empty.
   The streams / percentages / careers are EXAMPLE rules - edit as needed.
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

/* -------------------------- STARTER DATA -------------------------- */

IF NOT EXISTS (SELECT 1 FROM dbo.Fields)
BEGIN
    SET XACT_ABORT ON;
    BEGIN TRANSACTION;

    /* Fields */
    INSERT INTO dbo.Fields (FieldName) VALUES
        (N'Engineering studies'),
        (N'Business'),
        (N'Hospitality'),
        (N'Social studies');

    /* Subjects (South African CAPS curriculum, Grades 9-12) */
    INSERT INTO dbo.Subjects (SubjectName, Category, GradeRange) VALUES
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
        (N'Creative Arts', N'Grade 9 Learning Areas', N'Grade 9');

    /* Streams */
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
    JOIN dbo.Fields AS f ON f.FieldName = v.FieldName;

    /* Stream requirements (minimum % per subject) */
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
    JOIN dbo.Streams AS s ON s.FieldId = f.FieldId AND s.StreamName = v.StreamName;

    /* Careers (Keyword is matched inside what the learner types) */
    INSERT INTO dbo.Careers (Keyword, CareerName) VALUES
        (N'engineer', N'Engineer'),
        (N'doctor', N'Doctor'),
        (N'nurse', N'Nurse'),
        (N'accountant', N'Accountant'),
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
        (N'artist', N'Artist / Designer');

    /* Subjects needed for each career */
    INSERT INTO dbo.CareerSubjects (CareerId, SubjectName)
    SELECT c.CareerId, v.SubjectName
    FROM (VALUES
        (N'engineer', N'Mathematics'),
        (N'engineer', N'Physical Sciences'),
        (N'engineer', N'English'),
        (N'doctor', N'Mathematics'),
        (N'doctor', N'Physical Sciences'),
        (N'doctor', N'Life Sciences'),
        (N'doctor', N'English'),
        (N'nurse', N'Life Sciences'),
        (N'nurse', N'Physical Sciences or Mathematics'),
        (N'nurse', N'English'),
        (N'accountant', N'Mathematics'),
        (N'accountant', N'Accounting'),
        (N'accountant', N'English'),
        (N'teacher', N'English'),
        (N'teacher', N'Subjects you want to teach'),
        (N'teacher', N'Life Orientation'),
        (N'lawyer', N'English'),
        (N'lawyer', N'History'),
        (N'lawyer', N'Any Mathematics option'),
        (N'chef', N'Consumer Studies'),
        (N'chef', N'Hospitality Studies'),
        (N'chef', N'English'),
        (N'hotel', N'Tourism'),
        (N'hotel', N'Hospitality Studies'),
        (N'hotel', N'English'),
        (N'programmer', N'Mathematics'),
        (N'programmer', N'Information Technology'),
        (N'programmer', N'English'),
        (N'software', N'Mathematics'),
        (N'software', N'Information Technology'),
        (N'software', N'English'),
        (N'social work', N'English'),
        (N'social work', N'Life Orientation'),
        (N'social work', N'Life Sciences'),
        (N'pilot', N'Mathematics'),
        (N'pilot', N'Physical Sciences'),
        (N'pilot', N'English'),
        (N'farmer', N'Agricultural Sciences'),
        (N'farmer', N'Agricultural Management Practices'),
        (N'farmer', N'Mathematics or Mathematical Literacy'),
        (N'architect', N'Mathematics'),
        (N'architect', N'Engineering Graphics and Design'),
        (N'architect', N'Physical Sciences'),
        (N'electrician', N'Electrical Technology'),
        (N'electrician', N'Technical Mathematics'),
        (N'electrician', N'Technical Sciences'),
        (N'artist', N'Visual Arts'),
        (N'artist', N'Design'),
        (N'artist', N'English')
    ) AS v (Keyword, SubjectName)
    JOIN dbo.Careers AS c ON c.Keyword = v.Keyword;

    COMMIT TRANSACTION;
END
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

CREATE TABLE Courses
(
    CourseId INT IDENTITY(1,1) PRIMARY KEY,

    CourseName NVARCHAR(150) NOT NULL,

    Institution NVARCHAR(150) NOT NULL,

    FieldId INT NOT NULL,

    CONSTRAINT FK_Courses_Fields
        FOREIGN KEY (FieldId)
        REFERENCES Fields(FieldId),

    CONSTRAINT UQ_Courses_Name_Institution
        UNIQUE (CourseName, Institution)
);

GO 

CREATE TABLE StudentProfiles
(
    StudentProfileId INT IDENTITY(1,1) PRIMARY KEY,

    UserId INT NOT NULL,

    CourseId INT NOT NULL,

    YearOfStudy INT NOT NULL,

    CONSTRAINT FK_StudentProfiles_Users
        FOREIGN KEY (UserId)
        REFERENCES Users(UserId),

    CONSTRAINT FK_StudentProfiles_Courses
        FOREIGN KEY (CourseId)
        REFERENCES Courses(CourseId),

    CONSTRAINT UQ_StudentProfiles_User
        UNIQUE (UserId),

    CONSTRAINT CK_StudentProfiles_YearOfStudy
        CHECK (YearOfStudy BETWEEN 1 AND 10)
);

GO
IF NOT EXISTS (
    SELECT 1
    FROM dbo.Fields
    WHERE FieldName = N'Information Technology'
)
BEGIN
    INSERT INTO dbo.Fields (FieldName)
    VALUES (N'Information Technology');
END
GO

DECLARE @ITFieldId INT;

SELECT @ITFieldId = FieldId
FROM dbo.Fields
WHERE FieldName = N'Information Technology';

INSERT INTO dbo.Courses
    (CourseName, Institution, FieldId)
VALUES
(
    N'Diploma in Information Technology - Software Development',
    N'Nelson Mandela University',
    @ITFieldId
),
(
    N'Diploma in Information Technology - Support Services',
    N'Nelson Mandela University',
    @ITFieldId
),
(
    N'BSc Computer Science',
    N'Nelson Mandela University',
    @ITFieldId
);

/* =========================================================
   OPPORTUNITIES
   Stores all opportunity types in one table:
   Jobs, Internships, Bursaries, Learnerships, Hackathons, etc.
   ========================================================= */

IF OBJECT_ID('dbo.Opportunities', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Opportunities
    (
        OpportunityId INT IDENTITY(1,1) PRIMARY KEY,

        Title NVARCHAR(150) NOT NULL,

        Company NVARCHAR(150) NOT NULL,

        OpportunityType NVARCHAR(50) NOT NULL,

        Description NVARCHAR(MAX) NULL,

        Requirements NVARCHAR(MAX) NULL,

        Location NVARCHAR(150) NULL,

        ClosingDate DATE NULL,

        ApplicationURL NVARCHAR(500) NULL,

        IsActive BIT NOT NULL
            CONSTRAINT DF_Opportunities_IsActive
            DEFAULT 1,

        CreatedAt DATETIME2 NOT NULL
            CONSTRAINT DF_Opportunities_CreatedAt
            DEFAULT SYSDATETIME(),

        CONSTRAINT CK_Opportunities_Type
            CHECK (
                OpportunityType IN
                (
                    'Part-Time Job',
                    'Full-Time Job',
                    'Internship',
                    'Bursary',
                    'Learnership',
                    'Hackathon',
                    'Graduate Programme',
                    'Volunteer'
                )
            )
    );
END
GO


/* =========================================================
   OPPORTUNITY COURSES
   Connects opportunities to the courses they are relevant to.
   
   One opportunity can target many courses.
   One course can have many opportunities.
   ========================================================= */

IF OBJECT_ID('dbo.OpportunityCourses', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.OpportunityCourses
    (
        OpportunityId INT NOT NULL,
        CourseId INT NOT NULL,

        CONSTRAINT PK_OpportunityCourses
            PRIMARY KEY (OpportunityId, CourseId),

        CONSTRAINT FK_OpportunityCourses_Opportunities
            FOREIGN KEY (OpportunityId)
            REFERENCES dbo.Opportunities(OpportunityId)
            ON DELETE CASCADE,

        CONSTRAINT FK_OpportunityCourses_Courses
            FOREIGN KEY (CourseId)
            REFERENCES dbo.Courses(CourseId)
    );
END
GO

ALTER TABLE StudentProfiles
DROP CONSTRAINT FK_StudentProfiles_Users;
GO

ALTER TABLE StudentProfiles
ADD CONSTRAINT FK_StudentProfiles_Users
FOREIGN KEY (UserId)
REFERENCES Users(UserId)
ON DELETE CASCADE;
GO

ALTER TABLE OpportunityApplications
DROP CONSTRAINT FK_OpportunityApplications_Users;
GO

ALTER TABLE OpportunityApplications
ADD CONSTRAINT FK_OpportunityApplications_Users
FOREIGN KEY (UserId)
REFERENCES Users(UserId)
ON DELETE CASCADE;
GO

