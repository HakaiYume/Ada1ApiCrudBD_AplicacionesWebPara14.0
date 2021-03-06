USE [master]
GO
/****** Object:  Database [api_pelicula]    Script Date: 29/01/2022 11:51:15 p. m. ******/
CREATE DATABASE [api_pelicula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'api_pelicula', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\api_pelicula.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'api_pelicula_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\api_pelicula_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [api_pelicula] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [api_pelicula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [api_pelicula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [api_pelicula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [api_pelicula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [api_pelicula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [api_pelicula] SET ARITHABORT OFF 
GO
ALTER DATABASE [api_pelicula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [api_pelicula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [api_pelicula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [api_pelicula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [api_pelicula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [api_pelicula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [api_pelicula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [api_pelicula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [api_pelicula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [api_pelicula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [api_pelicula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [api_pelicula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [api_pelicula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [api_pelicula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [api_pelicula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [api_pelicula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [api_pelicula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [api_pelicula] SET RECOVERY FULL 
GO
ALTER DATABASE [api_pelicula] SET  MULTI_USER 
GO
ALTER DATABASE [api_pelicula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [api_pelicula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [api_pelicula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [api_pelicula] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [api_pelicula] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [api_pelicula] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'api_pelicula', N'ON'
GO
ALTER DATABASE [api_pelicula] SET QUERY_STORE = OFF
GO
USE [api_pelicula]
GO
/****** Object:  Table [dbo].[pelicula]    Script Date: 29/01/2022 11:51:16 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pelicula](
	[id_pelicula] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NULL,
	[director] [varchar](100) NULL,
	[genero] [varchar](100) NULL,
	[puntuacion] [int] NULL,
	[rating] [int] NULL,
	[publicacion] [date] NULL,
 CONSTRAINT [PK_pelicula] PRIMARY KEY CLUSTERED 
(
	[id_pelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[pelicula] ON 

INSERT [dbo].[pelicula] ([id_pelicula], [titulo], [director], [genero], [puntuacion], [rating], [publicacion]) VALUES (1, N'The Amazing Spider-Man', N'Marc Webb', N'Super Heroes', 80, 758000, CAST(N'2012-07-06' AS Date))
INSERT [dbo].[pelicula] ([id_pelicula], [titulo], [director], [genero], [puntuacion], [rating], [publicacion]) VALUES (2, N'¡Shazam!', N'David F. Sandberg', N'Super Heroes', 77, 366000, CAST(N'2019-04-05' AS Date))
INSERT [dbo].[pelicula] ([id_pelicula], [titulo], [director], [genero], [puntuacion], [rating], [publicacion]) VALUES (3, N'Pixels', N'Comedia', N'Chris Columbus', 78, 243000, CAST(N'2015-07-24' AS Date))
INSERT [dbo].[pelicula] ([id_pelicula], [titulo], [director], [genero], [puntuacion], [rating], [publicacion]) VALUES (4, N'Harry Potter and the Order of the Phoenix', N'Fantasia', N'David Yates', 93, 939000, CAST(N'2007-07-12' AS Date))
SET IDENTITY_INSERT [dbo].[pelicula] OFF
GO
USE [master]
GO
ALTER DATABASE [api_pelicula] SET  READ_WRITE 
GO
