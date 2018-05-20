USE [master]
GO

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

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE QLTV
GO

USE QLTV
GO

/****** Object:  Table [dbo].[tblLoaiHocSinh]    Script Date: 3/28/2018 8:02:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [int] NOT NULL,
	[hoten] [nvarchar](50) NOT NULL,
	[maloaidocgia] [int] NOT NULL,
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

CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblSach](
	[masach] [int] NOT NULL,
	[tensach] [nvarchar](50) NOT NULL,
	[namxuatban] [datetime2](7) NOT NULL,
	[ngaynhap] [datetime2](7) NOT NULL,
	[maloaisach] [int] NOT NULL,
	[manhaxuatban] [int] NOT NULL,
	[matacgia] [int] NOT NULL,
	[matinhtrang] [int] NOT NULL,
	[trigia] [int] NOT NULL,

 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblLoaiSach](
	[maloaidsach] [int] NOT NULL,
	[tenloaisach] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_tblDLoaiSach] PRIMARY KEY CLUSTERED 
(
	[maloaidsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblNhaXuatBan](
	[manhaxuatban] [int] NOT NULL,
	[tennhaxuatban] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_tblNhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [int] NOT NULL,
	[tentacgia] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblTinhTrang](
	[matinhtrang] [int] NOT NULL,
	[tenltinhtrang] [nvarchar](50) NOT NULL,

 CONSTRAINT [PK_tblTinhTrang] PRIMARY KEY CLUSTERED 
(
	[matinhtrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblMuonTraSach](
	[masach] [int] NOT NULL,
	[madocgia] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[ngaymuon] [datetime2](7) NOT NULL,
	[ngayhoantra] [datetime2](7) NOT NULL,
	[ngaytra] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblMuonTraSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[tblThamSo](
[tuoitoithieu] [int] NOT NULL
)

GO

INSERT INTO [dbo].tblLoaiDocGia([maloaidocgia],[tenloaidocgia]) VALUES(1,N'X')

GO 

INSERT INTO [dbo].tblLoaiDocGia([maloaidocgia],[tenloaidocgia]) VALUES(2,N'Y')

GO
select COUNT([maloaidocgia])  from [dbo].[tblLoaiDocGia]

GO 

INSERT INTO [tblDocGia]([madocgia],[hoten],[maloaidocgia],[diachi],[email],[ngaysinh],[ngaylapthe])
VALUES(1,N'Khang Truong',1,N'KTX Khu A',N'khangtruong@gmail.com',convert(datetime,'12/30/1998 00:00:00',101),convert(datetime,'12/30/2015 00:00:00',101))

GO

select * from [tblDocGia]