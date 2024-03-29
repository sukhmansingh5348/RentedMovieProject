USE [master]
GO
/****** Object:  Database [RentedMovieProject]    Script Date: 01-12-2019 08:37:44 PM ******/
CREATE DATABASE [RentedMovieProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentedMovieProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentedMovieProject.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RentedMovieProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentedMovieProject_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RentedMovieProject] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentedMovieProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentedMovieProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentedMovieProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentedMovieProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentedMovieProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentedMovieProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentedMovieProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentedMovieProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentedMovieProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentedMovieProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentedMovieProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentedMovieProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentedMovieProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentedMovieProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentedMovieProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentedMovieProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentedMovieProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentedMovieProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentedMovieProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentedMovieProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentedMovieProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentedMovieProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentedMovieProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentedMovieProject] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentedMovieProject] SET  MULTI_USER 
GO
ALTER DATABASE [RentedMovieProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentedMovieProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentedMovieProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentedMovieProject] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RentedMovieProject] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RentedMovieProject]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 01-12-2019 08:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](500) NULL,
	[Phone] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movies]    Script Date: 01-12-2019 08:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[Year] [nvarchar](50) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [text] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 01-12-2019 08:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

GO
INSERT [dbo].[Customer] ([ID], [FirstName], [LastName], [Address], [Phone]) VALUES (1, N'Nirmal', N'Singh', N'Abcd', N'980988789')
GO
INSERT [dbo].[Customer] ([ID], [FirstName], [LastName], [Address], [Phone]) VALUES (3, N'Raman', N'Singh', N'asdfa', N'22636474')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

GO
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (2, N'5', N'Hum Tum', N'2010', 2.0000, N'5', N'48', N'89', N'Dec  1 2019  3:41PM')
GO
INSERT [dbo].[Movies] ([ID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (3, N'5', N'Devdas', N'2019', 5.0000, N'4', N'34', N'334', N'Dec  1 2019  4:14PM')
GO
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

GO
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 2, 1, CAST(N'2019-12-01 00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (2, 3, 3, CAST(N'2019-12-01 00:00:00.000' AS DateTime), CAST(N'2019-12-01 20:04:59.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
GO
USE [master]
GO
ALTER DATABASE [RentedMovieProject] SET  READ_WRITE 
GO
