USE [master]
GO
/****** Object:  Database [DbTechcareerProject]    Script Date: 9.09.2022 06:36:16 ******/
CREATE DATABASE [DbTechcareerProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbTechcareerProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbTechcareerProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbTechcareerProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbTechcareerProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbTechcareerProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbTechcareerProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbTechcareerProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbTechcareerProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbTechcareerProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbTechcareerProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbTechcareerProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET RECOVERY FULL 
GO
ALTER DATABASE [DbTechcareerProject] SET  MULTI_USER 
GO
ALTER DATABASE [DbTechcareerProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbTechcareerProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbTechcareerProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbTechcareerProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbTechcareerProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbTechcareerProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbTechcareerProject', N'ON'
GO
ALTER DATABASE [DbTechcareerProject] SET QUERY_STORE = OFF
GO
USE [DbTechcareerProject]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[ActivityName] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Explanation] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Quota] [int] NOT NULL,
	[IsItTicketed] [bit] NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[CityId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[OrganizerId] [int] NOT NULL,
 CONSTRAINT [PK_Activities] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](max) NOT NULL,
	[AdminSurname] [nvarchar](max) NOT NULL,
	[AdminMail] [nvarchar](max) NOT NULL,
	[AdminPassword] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NOT NULL,
	[CompanyWebSite] [nvarchar](max) NOT NULL,
	[CompanyMail] [nvarchar](max) NOT NULL,
	[CompanyPassword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Companies] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyActivities]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyActivities](
	[CompanyActivityId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[ActivityId] [int] NOT NULL,
 CONSTRAINT [PK_CompanyActivities] PRIMARY KEY CLUSTERED 
(
	[CompanyActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizers]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizers](
	[OrganizerId] [int] IDENTITY(1,1) NOT NULL,
	[OrganizerName] [nvarchar](max) NOT NULL,
	[OrganizerSurname] [nvarchar](max) NOT NULL,
	[OrganizerMail] [nvarchar](max) NOT NULL,
	[OrganizerPassword] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Organizers] PRIMARY KEY CLUSTERED 
(
	[OrganizerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Queries]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Queries](
	[QueryId] [int] IDENTITY(1,1) NOT NULL,
	[QueryDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Queries] PRIMARY KEY CLUSTERED 
(
	[QueryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserActivities]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserActivities](
	[UserActivityId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ActivityId] [int] NOT NULL,
 CONSTRAINT [PK_UserActivities] PRIMARY KEY CLUSTERED 
(
	[UserActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 9.09.2022 06:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[UserSurname] [nvarchar](max) NOT NULL,
	[UserMail] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Activities_CategoryId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_Activities_CategoryId] ON [dbo].[Activities]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Activities_CityId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_Activities_CityId] ON [dbo].[Activities]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Activities_OrganizerId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_Activities_OrganizerId] ON [dbo].[Activities]
(
	[OrganizerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CompanyActivities_ActivityId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_CompanyActivities_ActivityId] ON [dbo].[CompanyActivities]
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CompanyActivities_CompanyId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_CompanyActivities_CompanyId] ON [dbo].[CompanyActivities]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Queries_CompanyId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_Queries_CompanyId] ON [dbo].[Queries]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserActivities_ActivityId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_UserActivities_ActivityId] ON [dbo].[UserActivities]
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserActivities_UserId]    Script Date: 9.09.2022 06:36:16 ******/
CREATE NONCLUSTERED INDEX [IX_UserActivities_UserId] ON [dbo].[UserActivities]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_Activities_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_Activities_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_Activities_Cities_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[Cities] ([CityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_Activities_Cities_CityId]
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD  CONSTRAINT [FK_Activities_Organizers_OrganizerId] FOREIGN KEY([OrganizerId])
REFERENCES [dbo].[Organizers] ([OrganizerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Activities] CHECK CONSTRAINT [FK_Activities_Organizers_OrganizerId]
GO
ALTER TABLE [dbo].[CompanyActivities]  WITH CHECK ADD  CONSTRAINT [FK_CompanyActivities_Activities_ActivityId] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activities] ([ActivityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompanyActivities] CHECK CONSTRAINT [FK_CompanyActivities_Activities_ActivityId]
GO
ALTER TABLE [dbo].[CompanyActivities]  WITH CHECK ADD  CONSTRAINT [FK_CompanyActivities_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompanyActivities] CHECK CONSTRAINT [FK_CompanyActivities_Companies_CompanyId]
GO
ALTER TABLE [dbo].[Queries]  WITH CHECK ADD  CONSTRAINT [FK_Queries_Companies_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Companies] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Queries] CHECK CONSTRAINT [FK_Queries_Companies_CompanyId]
GO
ALTER TABLE [dbo].[UserActivities]  WITH CHECK ADD  CONSTRAINT [FK_UserActivities_Activities_ActivityId] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activities] ([ActivityId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserActivities] CHECK CONSTRAINT [FK_UserActivities_Activities_ActivityId]
GO
ALTER TABLE [dbo].[UserActivities]  WITH CHECK ADD  CONSTRAINT [FK_UserActivities_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserActivities] CHECK CONSTRAINT [FK_UserActivities_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [DbTechcareerProject] SET  READ_WRITE 
GO
