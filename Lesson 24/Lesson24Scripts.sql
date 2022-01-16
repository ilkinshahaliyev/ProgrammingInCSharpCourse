USE [master]
GO
/****** Object:  Database [DatabaseDb]    Script Date: 16.01.2022 18:54:37 ******/
CREATE DATABASE [DatabaseDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DatabaseDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DatabaseDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DatabaseDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DatabaseDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DatabaseDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DatabaseDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DatabaseDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DatabaseDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DatabaseDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DatabaseDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DatabaseDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [DatabaseDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DatabaseDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DatabaseDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DatabaseDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DatabaseDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DatabaseDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DatabaseDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DatabaseDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DatabaseDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DatabaseDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DatabaseDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DatabaseDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DatabaseDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DatabaseDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DatabaseDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DatabaseDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DatabaseDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DatabaseDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DatabaseDb] SET  MULTI_USER 
GO
ALTER DATABASE [DatabaseDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DatabaseDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DatabaseDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DatabaseDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DatabaseDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DatabaseDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DatabaseDb] SET QUERY_STORE = OFF
GO
USE [DatabaseDb]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 16.01.2022 18:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 16.01.2022 18:54:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[EmploymentDate] [datetime] NULL,
	[DepartmentId] [int] NOT NULL,
	[ManagerId] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 
GO
INSERT [dbo].[Departments] ([Id], [Name], [CreatedDate]) VALUES (1, N'SOCAR', CAST(N'2002-01-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Departments] ([Id], [Name], [CreatedDate]) VALUES (2, N'AZERSU', CAST(N'1997-05-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Departments] ([Id], [Name], [CreatedDate]) VALUES (3, N'AZERCHAY', CAST(N'1995-07-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Departments] ([Id], [Name], [CreatedDate]) VALUES (4, N'AZERIQAZ', CAST(N'1992-01-23T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [EmploymentDate], [DepartmentId], [ManagerId]) VALUES (1, N'Samir', N'Celilov', CAST(N'2001-05-12T00:00:00.000' AS DateTime), 1, NULL)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [EmploymentDate], [DepartmentId], [ManagerId]) VALUES (2, N'Ilham', N'Alizada', CAST(N'2003-03-23T00:00:00.000' AS DateTime), 2, 1)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [EmploymentDate], [DepartmentId], [ManagerId]) VALUES (3, N'Celil', N'Mehemmedov', CAST(N'2004-12-21T00:00:00.000' AS DateTime), 4, 2)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [EmploymentDate], [DepartmentId], [ManagerId]) VALUES (4, N'Ilkin', N'Qabilov', CAST(N'2002-07-19T00:00:00.000' AS DateTime), 3, 3)
GO
INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [EmploymentDate], [DepartmentId], [ManagerId]) VALUES (8, N'Tural', N'Memmedov', CAST(N'2003-05-13T00:00:00.000' AS DateTime), 2, 3)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
ALTER TABLE [dbo].[Departments] ADD  CONSTRAINT [DF_Departments_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_DepartmentId_Departments_Id] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_DepartmentId_Departments_Id]
GO
USE [master]
GO
ALTER DATABASE [DatabaseDb] SET  READ_WRITE 
GO
