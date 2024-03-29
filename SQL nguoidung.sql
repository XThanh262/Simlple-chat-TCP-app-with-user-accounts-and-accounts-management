USE [master]
GO
/****** Object:  Database [Nhantinbaomat]    Script Date: 12/11/2021 10:28:21 PM ******/
CREATE DATABASE [Nhantinbaomat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Nhantinbaomat', FILENAME = N'E:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\Nhantinbaomat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Nhantinbaomat_log', FILENAME = N'E:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\Nhantinbaomat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Nhantinbaomat] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Nhantinbaomat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Nhantinbaomat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET ARITHABORT OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Nhantinbaomat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Nhantinbaomat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Nhantinbaomat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Nhantinbaomat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET RECOVERY FULL 
GO
ALTER DATABASE [Nhantinbaomat] SET  MULTI_USER 
GO
ALTER DATABASE [Nhantinbaomat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Nhantinbaomat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Nhantinbaomat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Nhantinbaomat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Nhantinbaomat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Nhantinbaomat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Nhantinbaomat', N'ON'
GO
ALTER DATABASE [Nhantinbaomat] SET QUERY_STORE = OFF
GO
USE [Nhantinbaomat]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 12/11/2021 10:28:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[IpPort] [nvarchar](50) NULL,
	[QuyenHan] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [Email], [IpPort], [QuyenHan]) VALUES (N'123', N'123', N'', N'192.168.1.8:57647', N'Nguoidung')
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [Email], [IpPort], [QuyenHan]) VALUES (N'987', N'987', N'hxthanh0206@gmail.com', N'192.168.1.6:54040', N'Nguoidung')
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [Email], [IpPort], [QuyenHan]) VALUES (N'abc', N'456', N'123@456', N'192.168.1.6:54041', N'Nguoidung')
INSERT [dbo].[NguoiDung] ([TaiKhoan], [MatKhau], [Email], [IpPort], [QuyenHan]) VALUES (N'admin', N'admin', N'xuanthanh020620@gmail.com', N'192.168.1.8:57853', N'Admin')
GO
USE [master]
GO
ALTER DATABASE [Nhantinbaomat] SET  READ_WRITE 
GO
