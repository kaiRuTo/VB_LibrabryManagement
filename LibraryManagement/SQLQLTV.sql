USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 5/28/2018 6:29:00 PM ******/
WHILE EXISTS(select NULL from sys.databases where name='QLTV')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLTV') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE QLTV
END
GO

CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
GO
USE [QLTV]
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[tblCTPhieuMuonSach]    Script Date: 5/28/2018 6:29:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTPhieuMuonSach](
	[maphieumuonsach] [varchar](10) NOT NULL,
	[masach] [varchar](10) NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [PK_tblCTPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach],
	[masach]
	 ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCTSach]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTSach](
	[masach] [varchar](10) NOT NULL,
	[matacgia] [varchar](10) NOT NULL
	 CONSTRAINT [PK_tblCTSach] PRIMARY KEY CLUSTERED 
(
	[masach],
	[matacgia]
	 ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [varchar](10) NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [varchar](10) NOT NULL,
	[ngaysinh] [datetime2](7) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[ngaylapthe] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [varchar](10) NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiSach]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiSach](
	[maloaisach] [varchar](10) NOT NULL,
	[tenloaisach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblDLoaiSach] PRIMARY KEY CLUSTERED 
(
	[maloaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaXuatBan]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaXuatBan](
	[manhaxuatban] [varchar](10) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuMuonSach]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [varchar](10) NOT NULL,
	[madocgia] [varchar](10) NOT NULL,
	[manhanvien] [varchar](10) NOT NULL,
	[soluong] [int] NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuTraSach]    Script Date: 5/28/2018 6:29:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuTraSach](
	[maphieutrasach] [varchar](10) NOT NULL,
	[maphieumuonsach] [varchar](10) NOT NULL,
	[manhanvien] [varchar](10) NOT NULL,
	[ngaytra] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieutrasach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 5/28/2018 6:29:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[masach] [varchar](10) NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[maloaisach] [varchar](10) NOT NULL,
	[namxuatban] [datetime2](7) NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
	[manhaxuatban] [varchar](10) NOT NULL,
	[trigia] [int] NOT NULL,
	[soluongsach] [int] NOT NULL,
	[soluongconlai] [int] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 5/28/2018 6:29:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [varchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThamSo]    Script Date: 5/28/2018 6:29:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThamSo](
	[tuoitoithieu] [int] NOT NULL,
	[tuoitoida] [int] NOT NULL,
	[handung] [int] NOT NULL,
	[soloaidocgia] [int] NOT NULL,
	[thoihanxuatbansach] [int] NOT NULL,	
	[soluongtacgia] [int] NOT NULL,
	[khoangnamxuatban] [int] NOT NULL,
	[soluongsachtoida] [int] NOT NULL,
	[songaymuontoida] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPhieuMuonSach_tblPhieuMuonSach] FOREIGN KEY([maphieumuonsach])
REFERENCES [dbo].[tblPhieuMuonSach] ([maphieumuonsach])
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach] CHECK CONSTRAINT [FK_tblCTPhieuMuonSach_tblPhieuMuonSach]
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTPhieuMuonSach_tblSach] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSach] ([masach])
GO
ALTER TABLE [dbo].[tblCTPhieuMuonSach] CHECK CONSTRAINT [FK_tblCTPhieuMuonSach_tblSach]
GO
ALTER TABLE [dbo].[tblCTSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTSach_tblSach] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSach] ([masach])
GO
ALTER TABLE [dbo].[tblCTSach] CHECK CONSTRAINT [FK_tblCTSach_tblSach]
GO
ALTER TABLE [dbo].[tblCTSach]  WITH CHECK ADD  CONSTRAINT [FK_tblCTSach_tblTacGia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tblTacGia] ([matacgia])
GO
ALTER TABLE [dbo].[tblCTSach] CHECK CONSTRAINT [FK_tblCTSach_tblTacGia]
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDocGia_tblLoaiDocGia] FOREIGN KEY([maloaidocgia])
REFERENCES [dbo].[tblLoaiDocGia] ([maloaidocgia])
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK_tblDocGia_tblLoaiDocGia]
GO
ALTER TABLE [dbo].[tblPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia] FOREIGN KEY([madocgia])
REFERENCES [dbo].[tblDocGia] ([madocgia])
GO
ALTER TABLE [dbo].[tblPhieuMuonSach] CHECK CONSTRAINT [FK_tblPhieuMuonSach_tblDocGia]
GO
ALTER TABLE [dbo].[tblPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuonSach_tblNhanVien] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblPhieuMuonSach] CHECK CONSTRAINT [FK_tblPhieuMuonSach_tblNhanVien]
GO
ALTER TABLE [dbo].[tblPhieuTraSach]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuTraSach_tblPhieuMuonSach] FOREIGN KEY([maphieumuonsach])
REFERENCES [dbo].[tblPhieuMuonSach] ([maphieumuonsach])
GO
ALTER TABLE [dbo].[tblPhieuTraSach] CHECK CONSTRAINT [FK_tblPhieuTraSach_tblPhieuMuonSach]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblLoaiSach] FOREIGN KEY([maloaisach])
REFERENCES [dbo].[tblLoaiSach] ([maloaisach])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblLoaiSach]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblNhaXuatBan] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[tblNhaXuatBan] ([manhaxuatban])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblNhaXuatBan]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
USE [QLTV]
GO
INSERT INTO [dbo].[tblLoaiDocGia] VALUES(1,'X'),(2,'Y')
GO
INSERT INTO [dbo].[tblDocGia] VALUES(1,N'Khang Trương',1,convert(datetime,'12/30/1998 00:00:00',101),N'KTX Khu A',N'khang@gmail.com',convert(datetime,'12/30/2015 00:00:00',101))
GO
select * from [tblLoaiDocGia]
GO
select * from [tblDocGia]
GO
