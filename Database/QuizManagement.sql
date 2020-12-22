/*
 Navicat Premium Data Transfer

 Source Server         : MSSQLServer
 Source Server Type    : SQL Server
 Source Server Version : 15004073
 Source Host           : localhost:1433
 Source Catalog        : QuizManagementDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15004073
 File Encoding         : 65001

 Date: 22/12/2020 20:34:49
*/


-- ----------------------------
-- Table structure for Answer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Answer]') AND type IN ('U'))
	DROP TABLE [dbo].[Answer]
GO

CREATE TABLE [dbo].[Answer] (
  [answerID] int  IDENTITY NOT NULL,
  [description] nvarchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [questionID] int  NULL,
  [isCorrect] bit  NULL
)
GO

ALTER TABLE [dbo].[Answer] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Answer
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Answer] ON
GO

SET IDENTITY_INSERT [dbo].[Answer] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for AnswerPracticeQuestion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AnswerPracticeQuestion]') AND type IN ('U'))
	DROP TABLE [dbo].[AnswerPracticeQuestion]
GO

CREATE TABLE [dbo].[AnswerPracticeQuestion] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [practiceQuestionID] int  NOT NULL,
  [dateAttempt] date  NOT NULL,
  [isCorrect] bit  NULL
)
GO

ALTER TABLE [dbo].[AnswerPracticeQuestion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AnswerPracticeQuestion
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for AnswerQuestion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AnswerQuestion]') AND type IN ('U'))
	DROP TABLE [dbo].[AnswerQuestion]
GO

CREATE TABLE [dbo].[AnswerQuestion] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [questionID] int  NOT NULL,
  [dateAttempt] date  NOT NULL,
  [isCorrect] bit  NULL
)
GO

ALTER TABLE [dbo].[AnswerQuestion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AnswerQuestion
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Class
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Class]') AND type IN ('U'))
	DROP TABLE [dbo].[Class]
GO

CREATE TABLE [dbo].[Class] (
  [classID] int  IDENTITY NOT NULL,
  [schoolLevelID] int  NULL,
  [name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Class] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Class
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Class] ON
GO

INSERT INTO [dbo].[Class] ([classID], [schoolLevelID], [name]) VALUES (N'0', N'0', N'10A1')
GO

INSERT INTO [dbo].[Class] ([classID], [schoolLevelID], [name]) VALUES (N'1', N'1', N'11A1')
GO

INSERT INTO [dbo].[Class] ([classID], [schoolLevelID], [name]) VALUES (N'2', N'2', N'12A1')
GO

SET IDENTITY_INSERT [dbo].[Class] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Exam
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Exam]') AND type IN ('U'))
	DROP TABLE [dbo].[Exam]
GO

CREATE TABLE [dbo].[Exam] (
  [examID] int  IDENTITY NOT NULL,
  [description] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [type] bit  NULL,
  [createBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [lastModifiedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Exam] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Exam
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Exam] ON
GO

SET IDENTITY_INSERT [dbo].[Exam] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for ExamQuiz
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamQuiz]') AND type IN ('U'))
	DROP TABLE [dbo].[ExamQuiz]
GO

CREATE TABLE [dbo].[ExamQuiz] (
  [quizID] int  NOT NULL,
  [examID] int  NOT NULL
)
GO

ALTER TABLE [dbo].[ExamQuiz] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of ExamQuiz
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for FormControl
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[FormControl]') AND type IN ('U'))
	DROP TABLE [dbo].[FormControl]
GO

CREATE TABLE [dbo].[FormControl] (
  [form] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [control] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[FormControl] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of FormControl
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for PracticeAnswer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PracticeAnswer]') AND type IN ('U'))
	DROP TABLE [dbo].[PracticeAnswer]
GO

CREATE TABLE [dbo].[PracticeAnswer] (
  [practiceAnswerID] int  IDENTITY NOT NULL,
  [description] nvarchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [practiceQuestionID] int  NULL,
  [isCorrect] bit  NULL
)
GO

ALTER TABLE [dbo].[PracticeAnswer] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PracticeAnswer
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[PracticeAnswer] ON
GO

SET IDENTITY_INSERT [dbo].[PracticeAnswer] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for PracticeQuestion
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PracticeQuestion]') AND type IN ('U'))
	DROP TABLE [dbo].[PracticeQuestion]
GO

CREATE TABLE [dbo].[PracticeQuestion] (
  [practiceQuestionID] int  IDENTITY NOT NULL,
  [description] nvarchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [questionLevelID] int  NULL,
  [subjectID] int  NULL,
  [schoolLevelID] int  NULL,
  [contribBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [verifyBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[PracticeQuestion] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PracticeQuestion
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[PracticeQuestion] ON
GO

SET IDENTITY_INSERT [dbo].[PracticeQuestion] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for PracticeQuestionQuiz
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PracticeQuestionQuiz]') AND type IN ('U'))
	DROP TABLE [dbo].[PracticeQuestionQuiz]
GO

CREATE TABLE [dbo].[PracticeQuestionQuiz] (
  [practiceQuestionID] int  NOT NULL,
  [quizID] int  NOT NULL
)
GO

ALTER TABLE [dbo].[PracticeQuestionQuiz] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PracticeQuestionQuiz
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Question
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Question]') AND type IN ('U'))
	DROP TABLE [dbo].[Question]
GO

CREATE TABLE [dbo].[Question] (
  [questionID] int  IDENTITY NOT NULL,
  [description] nvarchar(1000) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [questionLevelID] int  NULL,
  [subjectID] int  NULL,
  [schoolLevelID] int  NULL,
  [createBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [lastModifiedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Question] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Question
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Question] ON
GO

SET IDENTITY_INSERT [dbo].[Question] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for QuestionLevel
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionLevel]') AND type IN ('U'))
	DROP TABLE [dbo].[QuestionLevel]
GO

CREATE TABLE [dbo].[QuestionLevel] (
  [questionLevelID] int  IDENTITY NOT NULL,
  [description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[QuestionLevel] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of QuestionLevel
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[QuestionLevel] ON
GO

SET IDENTITY_INSERT [dbo].[QuestionLevel] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for QuestionQuiz
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[QuestionQuiz]') AND type IN ('U'))
	DROP TABLE [dbo].[QuestionQuiz]
GO

CREATE TABLE [dbo].[QuestionQuiz] (
  [questionID] int  NOT NULL,
  [quizID] int  NOT NULL
)
GO

ALTER TABLE [dbo].[QuestionQuiz] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of QuestionQuiz
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Quiz
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Quiz]') AND type IN ('U'))
	DROP TABLE [dbo].[Quiz]
GO

CREATE TABLE [dbo].[Quiz] (
  [quizID] int  IDENTITY NOT NULL,
  [length] int  NULL,
  [type] bit  NULL,
  [createBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [lastModifiedBy] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Quiz] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Quiz
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Quiz] ON
GO

SET IDENTITY_INSERT [dbo].[Quiz] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Role
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type IN ('U'))
	DROP TABLE [dbo].[Role]
GO

CREATE TABLE [dbo].[Role] (
  [roleID] int  NOT NULL,
  [description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Role] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Role
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[Role] VALUES (N'0', N'Admin')
GO

INSERT INTO [dbo].[Role] VALUES (N'1', N'Teacher')
GO

INSERT INTO [dbo].[Role] VALUES (N'2', N'Student')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for RoleFormControl
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleFormControl]') AND type IN ('U'))
	DROP TABLE [dbo].[RoleFormControl]
GO

CREATE TABLE [dbo].[RoleFormControl] (
  [roleID] int  NOT NULL,
  [form] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [control] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [invisible] bit  NULL,
  [disable] bit  NULL
)
GO

ALTER TABLE [dbo].[RoleFormControl] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoleFormControl
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for RoleForSignup
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[RoleForSignup]') AND type IN ('U'))
	DROP TABLE [dbo].[RoleForSignup]
GO

CREATE TABLE [dbo].[RoleForSignup] (
  [roleID] int  NOT NULL,
  [description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[RoleForSignup] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of RoleForSignup
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[RoleForSignup] VALUES (N'1', N'Teacher')
GO

INSERT INTO [dbo].[RoleForSignup] VALUES (N'2', N'Student')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for SchoolLevel
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SchoolLevel]') AND type IN ('U'))
	DROP TABLE [dbo].[SchoolLevel]
GO

CREATE TABLE [dbo].[SchoolLevel] (
  [schoolLevelID] int  IDENTITY NOT NULL,
  [description] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[SchoolLevel] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of SchoolLevel
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[SchoolLevel] ON
GO

INSERT INTO [dbo].[SchoolLevel] ([schoolLevelID], [description]) VALUES (N'0', N'Khối 10')
GO

INSERT INTO [dbo].[SchoolLevel] ([schoolLevelID], [description]) VALUES (N'1', N'Khối 11')
GO

INSERT INTO [dbo].[SchoolLevel] ([schoolLevelID], [description]) VALUES (N'2', N'Khối 12')
GO

SET IDENTITY_INSERT [dbo].[SchoolLevel] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type IN ('U'))
	DROP TABLE [dbo].[Student]
GO

CREATE TABLE [dbo].[Student] (
  [studentID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [dateOfBirth] date  NULL,
  [classID] int  NULL
)
GO

ALTER TABLE [dbo].[Student] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Student
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[Student] VALUES (N'1760169', N'Lê Anh Tài', N'1994-12-12', N'2')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for StudentUser
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentUser]') AND type IN ('U'))
	DROP TABLE [dbo].[StudentUser]
GO

CREATE TABLE [dbo].[StudentUser] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [studentID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[StudentUser] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of StudentUser
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Subject
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type IN ('U'))
	DROP TABLE [dbo].[Subject]
GO

CREATE TABLE [dbo].[Subject] (
  [subjectID] int  IDENTITY NOT NULL,
  [name] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Subject] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Subject
-- ----------------------------
BEGIN TRANSACTION
GO

SET IDENTITY_INSERT [dbo].[Subject] ON
GO

SET IDENTITY_INSERT [dbo].[Subject] OFF
GO

COMMIT
GO


-- ----------------------------
-- Table structure for TakeQuiz
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TakeQuiz]') AND type IN ('U'))
	DROP TABLE [dbo].[TakeQuiz]
GO

CREATE TABLE [dbo].[TakeQuiz] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [quizID] int  NOT NULL,
  [dateAttempt] date  NOT NULL,
  [grade] float(53)  NULL
)
GO

ALTER TABLE [dbo].[TakeQuiz] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TakeQuiz
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for TakeQuizInExam
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TakeQuizInExam]') AND type IN ('U'))
	DROP TABLE [dbo].[TakeQuizInExam]
GO

CREATE TABLE [dbo].[TakeQuizInExam] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [examID] int  NOT NULL,
  [quizID] int  NOT NULL,
  [schedule] datetime  NULL
)
GO

ALTER TABLE [dbo].[TakeQuizInExam] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TakeQuizInExam
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for Teacher
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type IN ('U'))
	DROP TABLE [dbo].[Teacher]
GO

CREATE TABLE [dbo].[Teacher] (
  [teacherID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [name] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [dateOfBirth] date  NULL
)
GO

ALTER TABLE [dbo].[Teacher] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Teacher
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[Teacher] VALUES (N'1760169', N'Lê Anh Tài', N'1994-12-12')
GO

COMMIT
GO


-- ----------------------------
-- Table structure for TeacherUser
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TeacherUser]') AND type IN ('U'))
	DROP TABLE [dbo].[TeacherUser]
GO

CREATE TABLE [dbo].[TeacherUser] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [teacherID] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[TeacherUser] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of TeacherUser
-- ----------------------------
BEGIN TRANSACTION
GO

COMMIT
GO


-- ----------------------------
-- Table structure for User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type IN ('U'))
	DROP TABLE [dbo].[User]
GO

CREATE TABLE [dbo].[User] (
  [username] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [password] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [roleID] int  NULL
)
GO

ALTER TABLE [dbo].[User] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of User
-- ----------------------------
BEGIN TRANSACTION
GO

INSERT INTO [dbo].[User] VALUES (N'admin', N'', N'0')
GO

COMMIT
GO


-- ----------------------------
-- Auto increment value for Answer
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Answer
-- ----------------------------
ALTER TABLE [dbo].[Answer] ADD CONSTRAINT [Answer_PK] PRIMARY KEY CLUSTERED ([answerID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AnswerPracticeQuestion
-- ----------------------------
ALTER TABLE [dbo].[AnswerPracticeQuestion] ADD CONSTRAINT [AnswerPracticeQuestion_PK] PRIMARY KEY CLUSTERED ([username], [practiceQuestionID], [dateAttempt])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AnswerQuestion
-- ----------------------------
ALTER TABLE [dbo].[AnswerQuestion] ADD CONSTRAINT [AnswerQuestion_PK] PRIMARY KEY CLUSTERED ([username], [questionID], [dateAttempt])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Class
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Class]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table Class
-- ----------------------------
ALTER TABLE [dbo].[Class] ADD CONSTRAINT [Class_PK] PRIMARY KEY CLUSTERED ([classID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Exam
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Exam
-- ----------------------------
ALTER TABLE [dbo].[Exam] ADD CONSTRAINT [Exam_PK] PRIMARY KEY CLUSTERED ([examID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ExamQuiz
-- ----------------------------
ALTER TABLE [dbo].[ExamQuiz] ADD CONSTRAINT [ExamQuiz_PK] PRIMARY KEY CLUSTERED ([quizID], [examID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table FormControl
-- ----------------------------
ALTER TABLE [dbo].[FormControl] ADD CONSTRAINT [FormControl_PK] PRIMARY KEY CLUSTERED ([form], [control])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for PracticeAnswer
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PracticeAnswer
-- ----------------------------
ALTER TABLE [dbo].[PracticeAnswer] ADD CONSTRAINT [PracticeAnswer_PK] PRIMARY KEY CLUSTERED ([practiceAnswerID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for PracticeQuestion
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table PracticeQuestion
-- ----------------------------
ALTER TABLE [dbo].[PracticeQuestion] ADD CONSTRAINT [PracticeQuestion_PK] PRIMARY KEY CLUSTERED ([practiceQuestionID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PracticeQuestionQuiz
-- ----------------------------
ALTER TABLE [dbo].[PracticeQuestionQuiz] ADD CONSTRAINT [PracticeQuestionQuiz_PK] PRIMARY KEY CLUSTERED ([practiceQuestionID], [quizID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Question
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Question
-- ----------------------------
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [Question_PK] PRIMARY KEY CLUSTERED ([questionID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for QuestionLevel
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table QuestionLevel
-- ----------------------------
ALTER TABLE [dbo].[QuestionLevel] ADD CONSTRAINT [QuestionLevel_PK] PRIMARY KEY CLUSTERED ([questionLevelID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table QuestionQuiz
-- ----------------------------
ALTER TABLE [dbo].[QuestionQuiz] ADD CONSTRAINT [QuestionQuiz_PK] PRIMARY KEY CLUSTERED ([questionID], [quizID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Quiz
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Quiz
-- ----------------------------
ALTER TABLE [dbo].[Quiz] ADD CONSTRAINT [Quiz_PK] PRIMARY KEY CLUSTERED ([quizID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Role
-- ----------------------------
ALTER TABLE [dbo].[Role] ADD CONSTRAINT [Role_PK] PRIMARY KEY CLUSTERED ([roleID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table RoleFormControl
-- ----------------------------
ALTER TABLE [dbo].[RoleFormControl] ADD CONSTRAINT [RoleFormControl_PK] PRIMARY KEY CLUSTERED ([roleID], [form], [control])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table RoleForSignup
-- ----------------------------
ALTER TABLE [dbo].[RoleForSignup] ADD CONSTRAINT [RoleForSignup_PK] PRIMARY KEY CLUSTERED ([roleID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for SchoolLevel
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[SchoolLevel]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table SchoolLevel
-- ----------------------------
ALTER TABLE [dbo].[SchoolLevel] ADD CONSTRAINT [SchoolLevel_PK] PRIMARY KEY CLUSTERED ([schoolLevelID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [Student_PK] PRIMARY KEY CLUSTERED ([studentID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table StudentUser
-- ----------------------------
ALTER TABLE [dbo].[StudentUser] ADD CONSTRAINT [StudentUser_PK] PRIMARY KEY CLUSTERED ([username])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Subject
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Subject
-- ----------------------------
ALTER TABLE [dbo].[Subject] ADD CONSTRAINT [Subject_PK] PRIMARY KEY CLUSTERED ([subjectID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table TakeQuiz
-- ----------------------------
ALTER TABLE [dbo].[TakeQuiz] ADD CONSTRAINT [TakeQuiz_PK] PRIMARY KEY CLUSTERED ([username], [quizID], [dateAttempt])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table TakeQuizInExam
-- ----------------------------
ALTER TABLE [dbo].[TakeQuizInExam] ADD CONSTRAINT [TakeQuizInExam_PK] PRIMARY KEY CLUSTERED ([username], [examID], [quizID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [Teacher_PK] PRIMARY KEY CLUSTERED ([teacherID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table TeacherUser
-- ----------------------------
ALTER TABLE [dbo].[TeacherUser] ADD CONSTRAINT [TeacherUser_PK] PRIMARY KEY CLUSTERED ([username])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [User_PK] PRIMARY KEY CLUSTERED ([username])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Answer
-- ----------------------------
ALTER TABLE [dbo].[Answer] ADD CONSTRAINT [Answer_FK] FOREIGN KEY ([questionID]) REFERENCES [dbo].[Question] ([questionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table AnswerPracticeQuestion
-- ----------------------------
ALTER TABLE [dbo].[AnswerPracticeQuestion] ADD CONSTRAINT [AnswerPracticeQuestion_FK] FOREIGN KEY ([practiceQuestionID]) REFERENCES [dbo].[PracticeQuestion] ([practiceQuestionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table AnswerQuestion
-- ----------------------------
ALTER TABLE [dbo].[AnswerQuestion] ADD CONSTRAINT [AnswerQuestion_FK] FOREIGN KEY ([questionID]) REFERENCES [dbo].[Question] ([questionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Class
-- ----------------------------
ALTER TABLE [dbo].[Class] ADD CONSTRAINT [Class_FK] FOREIGN KEY ([schoolLevelID]) REFERENCES [dbo].[SchoolLevel] ([schoolLevelID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table ExamQuiz
-- ----------------------------
ALTER TABLE [dbo].[ExamQuiz] ADD CONSTRAINT [ExamQuiz_FK] FOREIGN KEY ([quizID]) REFERENCES [dbo].[Quiz] ([quizID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[ExamQuiz] ADD CONSTRAINT [ExamQuiz_FK_1] FOREIGN KEY ([examID]) REFERENCES [dbo].[Exam] ([examID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PracticeAnswer
-- ----------------------------
ALTER TABLE [dbo].[PracticeAnswer] ADD CONSTRAINT [PracticeAnswer_FK] FOREIGN KEY ([practiceQuestionID]) REFERENCES [dbo].[PracticeQuestion] ([practiceQuestionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PracticeQuestion
-- ----------------------------
ALTER TABLE [dbo].[PracticeQuestion] ADD CONSTRAINT [PracticeQuestion_FK] FOREIGN KEY ([subjectID]) REFERENCES [dbo].[Subject] ([subjectID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PracticeQuestion] ADD CONSTRAINT [PracticeQuestion_FK_1] FOREIGN KEY ([schoolLevelID]) REFERENCES [dbo].[SchoolLevel] ([schoolLevelID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PracticeQuestion] ADD CONSTRAINT [PracticeQuestion_FK2] FOREIGN KEY ([questionLevelID]) REFERENCES [dbo].[QuestionLevel] ([questionLevelID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PracticeQuestionQuiz
-- ----------------------------
ALTER TABLE [dbo].[PracticeQuestionQuiz] ADD CONSTRAINT [PracticeQuestionQuiz_FK] FOREIGN KEY ([practiceQuestionID]) REFERENCES [dbo].[PracticeQuestion] ([practiceQuestionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[PracticeQuestionQuiz] ADD CONSTRAINT [PracticeQuestionQuiz_FK1] FOREIGN KEY ([quizID]) REFERENCES [dbo].[Quiz] ([quizID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table Question
-- ----------------------------
ALTER TABLE [dbo].[Question] ADD CONSTRAINT [Question_FK] FOREIGN KEY ([schoolLevelID]) REFERENCES [dbo].[SchoolLevel] ([schoolLevelID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Question] ADD CONSTRAINT [Question_FK1] FOREIGN KEY ([subjectID]) REFERENCES [dbo].[Subject] ([subjectID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Question] ADD CONSTRAINT [Question_FK2] FOREIGN KEY ([questionLevelID]) REFERENCES [dbo].[QuestionLevel] ([questionLevelID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table QuestionQuiz
-- ----------------------------
ALTER TABLE [dbo].[QuestionQuiz] ADD CONSTRAINT [QuestionQuiz_FK] FOREIGN KEY ([questionID]) REFERENCES [dbo].[Question] ([questionID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[QuestionQuiz] ADD CONSTRAINT [QuestionQuiz_FK_1] FOREIGN KEY ([quizID]) REFERENCES [dbo].[Quiz] ([quizID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table RoleFormControl
-- ----------------------------
ALTER TABLE [dbo].[RoleFormControl] ADD CONSTRAINT [RoleFormControl_FK] FOREIGN KEY ([form], [control]) REFERENCES [dbo].[FormControl] ([form], [control]) ON DELETE CASCADE ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[RoleFormControl] ADD CONSTRAINT [RoleFormControl_FK1] FOREIGN KEY ([roleID]) REFERENCES [dbo].[Role] ([roleID]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [Student_FK] FOREIGN KEY ([classID]) REFERENCES [dbo].[Class] ([classID]) ON DELETE SET NULL ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table StudentUser
-- ----------------------------
ALTER TABLE [dbo].[StudentUser] ADD CONSTRAINT [StudentUser_FK] FOREIGN KEY ([username]) REFERENCES [dbo].[User] ([username]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[StudentUser] ADD CONSTRAINT [StudentUser_FK1] FOREIGN KEY ([studentID]) REFERENCES [dbo].[Student] ([studentID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table TakeQuiz
-- ----------------------------
ALTER TABLE [dbo].[TakeQuiz] ADD CONSTRAINT [TakeQuiz_FK] FOREIGN KEY ([quizID]) REFERENCES [dbo].[Quiz] ([quizID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table TakeQuizInExam
-- ----------------------------
ALTER TABLE [dbo].[TakeQuizInExam] ADD CONSTRAINT [TakeQuizInExam_FK] FOREIGN KEY ([quizID], [examID]) REFERENCES [dbo].[ExamQuiz] ([quizID], [examID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table TeacherUser
-- ----------------------------
ALTER TABLE [dbo].[TeacherUser] ADD CONSTRAINT [TeacherUser_FK] FOREIGN KEY ([username]) REFERENCES [dbo].[User] ([username]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[TeacherUser] ADD CONSTRAINT [TeacherUser_FK1] FOREIGN KEY ([teacherID]) REFERENCES [dbo].[Teacher] ([teacherID]) ON DELETE CASCADE ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table User
-- ----------------------------
ALTER TABLE [dbo].[User] ADD CONSTRAINT [User_FK] FOREIGN KEY ([roleID]) REFERENCES [dbo].[Role] ([roleID]) ON DELETE SET NULL ON UPDATE CASCADE
GO

