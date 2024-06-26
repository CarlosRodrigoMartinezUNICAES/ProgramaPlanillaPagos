USE [master]
GO
/****** Object:  Database [Planilla]    Script Date: 3/4/2024 01:46:44:p. m. ******/
CREATE DATABASE [Planilla]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Planilla', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER\MSSQL\DATA\Planilla.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Planilla_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLSERVER\MSSQL\DATA\Planilla_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Planilla] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Planilla].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Planilla] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Planilla] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Planilla] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Planilla] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Planilla] SET ARITHABORT OFF 
GO
ALTER DATABASE [Planilla] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Planilla] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Planilla] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Planilla] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Planilla] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Planilla] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Planilla] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Planilla] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Planilla] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Planilla] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Planilla] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Planilla] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Planilla] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Planilla] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Planilla] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Planilla] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Planilla] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Planilla] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Planilla] SET  MULTI_USER 
GO
ALTER DATABASE [Planilla] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Planilla] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Planilla] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Planilla] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Planilla] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Planilla] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Planilla] SET QUERY_STORE = ON
GO
ALTER DATABASE [Planilla] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Planilla]
GO
/****** Object:  Table [dbo].[AttendanceTbl]    Script Date: 3/4/2024 01:46:45:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttendanceTbl](
	[AttNum] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[DayPres] [int] NOT NULL,
	[DayAbs] [int] NOT NULL,
	[DayExcused] [int] NOT NULL,
	[Period] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AttNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BonusTbl]    Script Date: 3/4/2024 01:46:45:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BonusTbl](
	[BId] [int] IDENTITY(500,1) NOT NULL,
	[BName] [varchar](50) NOT NULL,
	[BAmt] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTbl]    Script Date: 3/4/2024 01:46:45:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTbl](
	[EmpId] [int] IDENTITY(1000,1) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[EmpGen] [varchar](10) NOT NULL,
	[EmpDOB] [date] NOT NULL,
	[EmpPhone] [varchar](50) NOT NULL,
	[EmpAdd] [varchar](100) NOT NULL,
	[EmpPos] [varchar](50) NOT NULL,
	[JoinDate] [date] NOT NULL,
	[EmpQual] [varchar](50) NOT NULL,
	[EmpBasSal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryTbl]    Script Date: 3/4/2024 01:46:45:p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryTbl](
	[SalNum] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [int] NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[EmpBasSal] [int] NOT NULL,
	[EmpBonus] [int] NOT NULL,
	[EmpAdvance] [int] NOT NULL,
	[EmpTax] [int] NOT NULL,
	[EmpBalance] [int] NOT NULL,
	[SalPeriod] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SalNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttendanceTbl]  WITH CHECK ADD  CONSTRAINT [FK2] FOREIGN KEY([EmpId])
REFERENCES [dbo].[EmployeeTbl] ([EmpId])
GO
ALTER TABLE [dbo].[AttendanceTbl] CHECK CONSTRAINT [FK2]
GO
ALTER TABLE [dbo].[SalaryTbl]  WITH CHECK ADD  CONSTRAINT [FK1] FOREIGN KEY([EmpId])
REFERENCES [dbo].[EmployeeTbl] ([EmpId])
GO
ALTER TABLE [dbo].[SalaryTbl] CHECK CONSTRAINT [FK1]
GO
USE [master]
GO
ALTER DATABASE [Planilla] SET  READ_WRITE 
GO
