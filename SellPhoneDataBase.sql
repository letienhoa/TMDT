USE [master]
GO
drop DATABASE [SellPhoneDataBase]
CREATE DATABASE [SellPhoneDataBase]
 --CONTAINMENT = NONE
 --ON  PRIMARY 
--( NAME = N'SellPhoneDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SellPhoneDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 --LOG ON 
--( NAME = N'SellPhoneDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\SellPhoneDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
--GO
--ALTER DATABASE [SellPhoneDataBase] SET COMPATIBILITY_LEVEL = 140
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SellPhoneDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SellPhoneDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SellPhoneDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SellPhoneDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SellPhoneDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SellPhoneDataBase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SellPhoneDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET RECOVERY FULL 
GO
ALTER DATABASE [SellPhoneDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [SellPhoneDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SellPhoneDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SellPhoneDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SellPhoneDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SellPhoneDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SellPhoneDataBase', N'ON'
GO
ALTER DATABASE [SellPhoneDataBase] SET QUERY_STORE = OFF
GO
USE [SellPhoneDataBase]
GO
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[CustomerPhoneNumber] [nvarchar](max) NULL,
	[AppointmentDate] [datetime2] NULL,
	[CustomerEmail] [nvarchar](max) NULL,
	[TotalPrice] [int] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Memory] [int] NULL,
	[Quantity] [int] NULL,
	[Capacity] [int] NULL,
	[Manufacturer] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
	[Price] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SpecialTagId] [int] NOT NULL,
	[Trangthai][int]NOT NULL
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSelectedForAppointment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Trangthai][int]NOT NULL
 CONSTRAINT [PK_ProductSelectedForAppointment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_SpecialTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DateOfBith] [datetime2](7) NOT NULL,
	[Gender] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--tạo nhân viên
CREATE TABLE [dbo].[Nhanvien](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[DateOfBith] [datetime2](7) NOT NULL,
	[Gender] [int] NOT NULL,
	[Loai] [int] NOT NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108234230_addCategory', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108234554_addSpecialTag', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191108235036_addProducts', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112033905_addUsers', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112043502_addAppointmentsAndProductSelectedForAppointment', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112075216_addBillAndBillDetails', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112080352_addDatabase', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191113132915_DatabaseNew', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191115123850_addDatabaseNew', N'2.2.6-servicing-10079')
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (1, N'HaNoi', N'Son IT', N'0968806360',CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin', 25780000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (2, N'HaNoi', NULL, NULL, NULL, NULL, 26060000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (3, N'HaNoi', NULL, NULL, NULL, NULL, 25780000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (4, N'HaNoi', NULL, NULL, NULL, NULL, 42770000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (5,N'HaNoi', NULL, NULL, NULL, NULL, 17580000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (6, N'HaNoi', N'Son', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin@gmail.com', 9010000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (7, N'HaNoi', N'Phan Phú Huy', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'phanphuhuy111@gmail.com', 19280000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (8, N'HaNoi', N'Phan Phú Huy', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'phanphuhuy111@gmail.com', 430000)
INSERT [dbo].[Appointments] ([Id], [Address], [CustomerName], [CustomerPhoneNumber], [AppointmentDate], [CustomerEmail], [TotalPrice]) VALUES (9, N'HaNoi', N'Duy', N'334343424434', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), N'admin@gmail.com', 10490000)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Laptop')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Tablet')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Phụ kiện')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Điện thoại')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (1, N'Samsung Galaxy Note 9', N'\images\ProductImage\1.png', 6, 8, 128, N'Samsung', N'Xanh Dương', 16990000, 4, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (2, N'Samsung Galaxy A70', N'\images\ProductImage\2.png', 6, 5, 128, N'Samsung', N'Trắng', 8790000, 4, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (3, N'IPhone 7 32GB', N'\images\ProductImage\3.png', 2, 2, 32, N'Iphone', N'Vàng', 10490000, 4, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (4, N'IPhone 6 32GB', N'\images\ProductImage\3.png', 2, 2, 32, N'Iphone', N'Vàng', 7490000, 4, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (5, N'Huawei P30 Lite', N'\images\ProductImage\5.png', 6, 20, 128, N'Huawei', N'Xanh Dương', 6020000, 4, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (6, N'IPhone 6s Plus 32GB', N'\images\ProductImage\6.png', 2, 2, 32, N'Apple', N'Vàng Đồng', 8490000, 4, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (7, N'Máy tính bảng iPad Mini 7.9', N'\images\ProductImage\7.png', 3, 3, 64, N'Apple', N'Bạc', 14490000, 2, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (8, N'Tai nghe EP Kanen IP-225', N'\images\ProductImage\8.jpg', 0, 5, 0, N'Kanen', N'Xanh lá', 105000, 3, 4,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (9, N'Loa Bluetooth iCute', N'\images\ProductImage\9.jpg', 0, 6, 0, N'Thế Giới Di Động', N'Đen', 280000, 3, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (10, N'USB Sandisk 8 GB 2.0', N'\images\ProductImage\10.jpg', 0, 4, 8, N'Sandisk', N'Đen & Đỏ', 150000, 3, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (11, N'Ổ cứng HDD 1TB WD My', N'\images\ProductImage\11.jpg', 0, 6, 1024, N'Western Digital', N'Xanh Dương', 1690000, 3, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (12, N'MicroSD 16 GB Class 10', N'\images\ProductImage\12.jpg', 0, 1, 16, N' SanDisk, Transcend ', N'Đen', 220000, 3, 1,0)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (17, N'MicroSD 64 GB Lexar', N'\images\ProductImage\13.jpg', 0, 2, 64, N' Lexar ', N'Đen', 385000, 3, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (14, N'Loa vi tính Fenda V320', N'\images\ProductImage\14.jpg', 0, 4, 0, N'Trung Quốc ', N'Đen', 250000, 3, 1,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (15, N'Loa Bluetooth Fenda W8', N'\images\ProductImage\15.jpg', 0, 7, 0, N'Trung Quốc ', N'Xanh Dương', 500000, 3, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (16, N'Laptop Lenovo i5 8250U/4GB/1TB/Win10', N'\images\ProductImage\16.jpg', 4, 4, 1024, N'Lenovo', N'Xám', 12490000, 1, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (30, N'Laptop Acer i5 8265U/4GB/1TB/Win10', N'\images\ProductImage\17.jpg', 4, 2, 1024, N'Acer', N'Xám', 11990000, 1, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (18, N'Laptop HP i3 8145U/4GB/1TB/Win10', N'\images\ProductImage\18.jpg', 4, 3, 1024, N'Hp', N'Xám', 12990000, 1, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (19, N'Laptop Acer i3 7130U/4GB/1TB/Win10', N'\images\ProductImage\19.jpg', 4, 2, 128, N'Acer', N'Xám', 15740000, 1, 3,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (20, N'Laptop Lenovo i3 8145U/4GB/256GB/2GB', N'\images\ProductImage\20.jpg', 4, 1, 256, N'Lenovo', N'Đen', 11790000, 1, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (21, N'Laptop Asus i7 9750H/8GB/512GB/4GB GTX1650', N'\images\ProductImage\21.jpg', 8, 2, 512, N'Asus', N'Đen', 28990000, 1, 4,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (22, N'Samsung Galaxy Tab A8 8" T295 (2019)', N'\images\ProductImage\22.png', 2, 2, 32, N'Samsung', N'Bạc', 3450000, 2, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (23, N'Lenovo Tab E10 TB-X104L Đen', N'\images\ProductImage\23.png', 2, 3, 16, N'Lenovo', N'Đen', 3990000, 2, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (24, N'iPad Pro 11 inch Wifi 64GB (2018)', N'\images\ProductImage\24.png', 4, 2, 64, N'Apple', N'Xám', 20990000, 2, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (25, N'Samsung Galaxy Tab S6', N'\images\ProductImage\25.png', 6, 3, 128, N'Samsung', N'Xanh Dương', 18490000, 2, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (26, N'Huawei Mediapad T5 10.1 inch', N'\images\ProductImage\26.png', 3, 3, 32, N'Huawei', N'Đen', 5690000, 2, 4,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (27, N'iPad Mini 7.9 inch Wifi 64GB (2019)', N'\images\ProductImage\27.png', 3, 1, 64, N'Apple', N'Vàng Đồng', 9990000, 2, 4,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (28, N'Điện thoại Nokia 8.1', N'\images\ProductImage\28.png', 4, 4, 64, N'Nokia', N'Xanh Dương', 6590000, 4, 4,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (29, N'Điện thoại OPPO A5 (2020) 128GB', N'\images\ProductImage\29.png', 4, 2, 128, N'Opplo', N'Đen', 5290000, 4, 2,1)
INSERT [dbo].[Products] ([Id], [Name], [Image], [Memory], [Quantity], [Capacity], [Manufacturer], [Color], [Price], [CategoryId], [SpecialTagId],[Trangthai]) VALUES (13, N'Tai Nghe Focal Utopia', N'\images\ProductImage\30.jpg', 0, 5, 0, N'Focal', N'Đen thùi lùi', 990000, 3, 3,1)	 
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[ProductSelectedForAppointment] ON 

INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (1, 1, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (2, 1, 1,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (3, 2, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (4, 2, 1,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (5, 2, 9,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (6, 3, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (7, 3, 1,1)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (8, 4, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (9, 4, 1,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (10, 4, 1,1)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (11, 5, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (12, 5, 2,1)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (13, 6, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (14, 6, 12,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (15, 7, 2,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (16, 7, 3,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (17, 8, 10,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (18, 8, 9,0)
INSERT [dbo].[ProductSelectedForAppointment] ([Id], [AppointmentId], [ProductId],[Trangthai]) VALUES (19, 9, 3,0)
SET IDENTITY_INSERT [dbo].[ProductSelectedForAppointment] OFF
SET IDENTITY_INSERT [dbo].[SpecialTag] ON 

INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (1, N'Mới ra')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (2, N'Bán chạy')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (3, N'Đặc biệt')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (4, N'Phổ biến')
INSERT [dbo].[SpecialTag] ([Id], [Name]) VALUES (1003, N'None')
SET IDENTITY_INSERT [dbo].[SpecialTag] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (2, N'phanphuhuy116', N'123456', N'Phan Phú Huy', N'phanphuhuy111@gmail.com', N'01283381683', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (3, N'admin', N'admin1', N'admin1', N'admin@gmail.com', N'0968806360', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (8, N'phandinhsonlp116', N'0123456789', N'Son IT', N'phanphuhuy@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (9, N'thu12345', N'123456', N'Minh Thu', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (10, N'lethai', N'123456', N'Lê Hồng Thái', N'hongthai@gmail.com', N'12345632322', CAST(N'1999-11-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (11, N'letienhoa1998', N'hoa12345', N'Lê Tiến Hòa', N'letienhoa1998@gmail.com       ', N'0123242322', CAST(N'1998-11-09T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (13, N'ngominhthu', N'123456', N'Thu IT', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Users] ([Id], [UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender]) VALUES (14, N'phandinhson', N'1234567', N'Son IT', N'ngominhthu@gmail.com          ', N'0968806360', CAST(N'1999-11-11T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Users] OFF

--tạo giá trị cho nhân viên
INSERT [dbo].[Nhanvien]  ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Loai]) VALUES ( N'DiemKiDi', N'123456', N'Diem Vo', N'diem1234@gmail.com', N'098767655', CAST(N'1998-11-11T00:00:00.0000000' AS DateTime2), 0,2)
INSERT [dbo].[Nhanvien] ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Loai]) VALUES (N'Han', N'admin', N'Han', N'han12345@gmail.com', N'098878676', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1,2)
INSERT [dbo].[Nhanvien] ([UserName], [Password], [Name], [Email], [Phone], [DateOfBith], [Gender],[Loai]) VALUES (N'admin', N'admin', N'Han', N'han12345@gmail.com', N'098878676', CAST(N'1999-11-06T00:00:00.0000000' AS DateTime2), 1,1)
SET IDENTITY_INSERT [dbo].[Nhanvien] OFF


CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_Products_SpecialTagId] ON [dbo].[Products]
(
	[SpecialTagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_ProductSelectedForAppointment_AppointmentId] ON [dbo].[ProductSelectedForAppointment]
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_ProductSelectedForAppointment_ProductId] ON [dbo].[ProductSelectedForAppointment]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments] ADD  DEFAULT ((0)) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_SpecialTag_SpecialTagId] FOREIGN KEY([SpecialTagId])
REFERENCES [dbo].[SpecialTag] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_SpecialTag_SpecialTagId]
GO
ALTER TABLE [dbo].[ProductSelectedForAppointment]  WITH CHECK ADD  CONSTRAINT [FK_ProductSelectedForAppointment_Appointments_AppointmentId] FOREIGN KEY([AppointmentId])
REFERENCES [dbo].[Appointments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductSelectedForAppointment] CHECK CONSTRAINT [FK_ProductSelectedForAppointment_Appointments_AppointmentId]
GO
ALTER TABLE [dbo].[ProductSelectedForAppointment]  WITH CHECK ADD  CONSTRAINT [FK_ProductSelectedForAppointment_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductSelectedForAppointment] CHECK CONSTRAINT [FK_ProductSelectedForAppointment_Products_ProductId]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_Category]
    (@id INT
     )
AS 
BEGIN
    DELETE dbo.Category
    WHERE Id=@id
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Delete_User]
    (@id INT
     )
AS 
BEGIN
    DELETE FROM Users
    WHERE Id=@id
END
GO

-- xóa nhân viên
CREATE PROCEDURE [dbo].[Delete_nhanvien]
    (@id INT
     )
AS 
BEGIN
    DELETE FROM Nhanvien
    WHERE Id=@id
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_Category](
@name NVARCHAR(50))
AS
BEGIN
INSERT INTO dbo.Category
(
    Name
)
VALUES
(   @name
)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_SpecialTag]
(
@Name NVARCHAR(50)
)
AS
BEGIN
INSERT INTO dbo.SpecialTag
(
    Name
)
VALUES
(
@Name -- Name - nvarchar(max)
)

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_Users]
(
@UserName NVARCHAR(30),
@Password NVARCHAR(20),
@Name NVARCHAR(20),
@Email NVARCHAR(100),
@Phone   NVARCHAR(12),
@DateOfBith DATETIME,
@Gender INT

)
AS
BEGIN
    INSERT INTO dbo.Users
    (
        UserName,
        Password,
        Name,
        Email,
        Phone,
        DateOfBith,
        Gender
    )
    VALUES
    (   @UserName,           -- UserName - nvarchar(max)
        @Password,           -- Password - nvarchar(max)
        @Name,           -- Name - nvarchar(max)
        @Email,           -- Email - nvarchar(max)
       @Phone,           -- Phone - nvarchar(max)
       @DateOfBith, -- DateOfBith - datetime2(7)
       @Gender             -- Gender - int
        )
END
GO

-- tạo nhân viên

CREATE PROCEDURE [dbo].[Insert_nhanvien]
(
@UserName NVARCHAR(30),
@Password NVARCHAR(20),
@Name NVARCHAR(20),
@Email NVARCHAR(100),
@Phone   NVARCHAR(12),
@DateOfBith DATETIME,
@Gender INT,
@Loai INT
)
AS
BEGIN
    INSERT INTO dbo.Nhanvien
    (
        UserName,
        Password,
        Name,
        Email,
        Phone,
        DateOfBith,
        Gender,
		Loai
    )
    VALUES
    (   @UserName,           -- UserName - nvarchar(max)
        @Password,           -- Password - nvarchar(max)
        @Name,           -- Name - nvarchar(max)
        @Email,           -- Email - nvarchar(max)
       @Phone,           -- Phone - nvarchar(max)
       @DateOfBith, -- DateOfBith - datetime2(7)
       @Gender,
	   @Loai             -- Gender - int
        )
END
GO






CREATE PROCEDURE [dbo].[Insert_Appointments]
(
@Address NVARCHAR(max),
@CustomerName NVARCHAR(max),
@CustomerPhoneNumber NVARCHAR(max),
@AppointmentDate datetime2 ,
@CustomerEmail   NVARCHAR(max),
@TotalPrice int
)
AS
BEGIN
    INSERT INTO dbo.Appointments
    (
        Address,
        CustomerName,
        CustomerPhoneNumber,
        AppointmentDate,
        CustomerEmail,
        TotalPrice
    )
    VALUES
    (   @Address,           -- UserName - nvarchar(max)
        @CustomerName,           -- Password - nvarchar(max)
        @CustomerPhoneNumber,           -- Name - nvarchar(max)
        @AppointmentDate,           -- Email - nvarchar(max)
       @CustomerEmail,           -- Phone - nvarchar(max)
       @TotalPrice -- DateOfBith - datetime2(7)
        )
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_All_Category]
AS
BEGIN
SELECT * FROM Category
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_All_Product]
AS
BEGIN
	SELECT p.Id, c.Id AS CategoryId,st.Id AS SpecialTagId,p.Name,p.Image,p.Memory,p.Quantity,p.Capacity,p.Manufacturer,p.Color,p.Price,p.Trangthai,c.Name AS Category ,st.Name AS SpecialTag
	 FROM dbo.Products p,dbo.Category c,dbo.SpecialTag st
	 WHERE p.CategoryId=c.Id AND p.SpecialTagId=st.Id
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Select_All_SpecialTag]
AS
BEGIN
SELECT * FROM dbo.SpecialTag
END
GO

-- lay het thon tin trong bang dat hang
CREATE PROC [dbo].[Select_All_Dondathang]
AS
BEGIN
SELECT * FROM dbo.ProductSelectedForAppointment
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Select_All_User]
AS
BEGIN
SELECT * FROM dbo.Users
END
GO

CREATE PROCEDURE [dbo].[Select_All_nhanvien]
AS
BEGIN
SELECT * FROM dbo.Nhanvien
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Sellect_SpecialTag_Id]
(@Id INT)
AS
BEGIN
SELECT Id,Name
FROM dbo.SpecialTag 
WHERE Id=@Id

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_Category](
@id INT,
@name NVARCHAR(50)
)
AS

BEGIN
UPDATE dbo.Category
SET Name=@name
WHERE Id=@id

END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Update_SpecialTag]
(@id INT,
@name NVARCHAR(50)
)
AS
BEGIN
UPDATE dbo.SpecialTag
SET Name=@name
WHERE Id=@id
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_User](
@id INT,
@UserName NVARCHAR(MAX),
@Password NVARCHAR(MAX),
@Name NVARCHAR(MAX),
@Email NVARCHAR(MAX),
@Phone NVARCHAR(MAX),
@DateOfBirth datetime2(7),
@Gender INT
)
AS
BEGIN
UPDATE dbo.Users
SET UserName=@UserName, 
	Password=@Password, 
	Name=@Name, 
	Email=@Email, 
	Phone=@Phone, 
	DateOfBith=@DateOfBirth,
	Gender=@Gender
WHERE Id=@id
END
GO

-- chỉnh sủa nhân viên
CREATE PROCEDURE [dbo].[Update_nhanvien](
@id INT,
@UserName NVARCHAR(MAX),
@Password NVARCHAR(MAX),
@Name NVARCHAR(MAX),
@Email NVARCHAR(MAX),
@Phone NVARCHAR(MAX),
@DateOfBirth datetime2(7),
@Gender INT,
@Loai INT
)
AS
BEGIN
UPDATE dbo.Nhanvien
SET UserName=@UserName, 
	Password=@Password, 
	Name=@Name, 
	Email=@Email, 
	Phone=@Phone, 
	DateOfBith=@DateOfBirth,
	Gender=@Gender,
	Loai=@Loai
WHERE Id=@id
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[User_Login]
(
	@UserName NVARCHAR(100),
	@Password NVARCHAR(100)
)
AS

    BEGIN
       SELECT *
    FROM dbo.Users
    WHERE UserName=@UserName
        AND
        Password = @Password
    END
GO

-- tạo proc bên bảng nhanvien

CREATE PROCEDURE [dbo].[Nhanvien_Login]
(
	@UserName NVARCHAR(100),
	@Password NVARCHAR(100)
)
AS

    BEGIN
       SELECT *
    FROM dbo.Nhanvien
    WHERE UserName=@UserName
        AND
        Password = @Password
    END
GO


CREATE PROCEDURE [dbo].[Appointments_Timkiem]
(
	@Id int
)
AS

    BEGIN
       SELECT *
    FROM dbo.Appointments
    WHERE Id=@Id

    END
GO

CREATE PROCEDURE [dbo].[Product_Timkiem]
(
	@Id int
)
AS

    BEGIN
       SELECT *
    FROM dbo.Products
    WHERE Id=@Id

    END
GO

-- câp nhật trạng thái
CREATE PROCEDURE [dbo].[Update_dondathang](
@id INT
)
AS

BEGIN
UPDATE dbo.ProductSelectedForAppointment
SET Trangthai=1
WHERE Id=@id

END
GO

-- cập nhật trạng thái sản phẩm
CREATE PROCEDURE [dbo].[Update_trangthaisp](
@id INT
)
AS

BEGIN
UPDATE dbo.Products
SET Trangthai=1
WHERE Id=@id

END
GO


USE [master]
GO
ALTER DATABASE [SellPhoneDataBase] SET  READ_WRITE 
GO
