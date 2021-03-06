USE [master]
GO
/****** Object:  Database [TruyumDB]    Script Date: 14-05-2021 18:22:00 ******/
CREATE DATABASE [TruyumDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TruyumDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TruyumDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TruyumDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TruyumDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TruyumDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TruyumDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TruyumDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TruyumDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TruyumDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TruyumDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TruyumDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TruyumDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TruyumDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TruyumDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TruyumDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TruyumDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TruyumDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TruyumDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TruyumDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TruyumDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TruyumDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TruyumDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TruyumDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TruyumDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TruyumDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TruyumDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TruyumDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TruyumDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TruyumDB] SET RECOVERY FULL 
GO
ALTER DATABASE [TruyumDB] SET  MULTI_USER 
GO
ALTER DATABASE [TruyumDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TruyumDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TruyumDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TruyumDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TruyumDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TruyumDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TruyumDB', N'ON'
GO
ALTER DATABASE [TruyumDB] SET QUERY_STORE = OFF
GO
USE [TruyumDB]
GO
/****** Object:  Table [dbo].[TCartList]    Script Date: 14-05-2021 18:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TCartList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[MenuId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMenuList]    Script Date: 14-05-2021 18:22:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMenuList](
	[id] [int] NULL,
	[name] [varchar](50) NULL,
	[price] [float] NULL,
	[active] [bit] NULL,
	[dateOfLaunch] [datetime] NULL,
	[category] [varchar](50) NULL,
	[freeDelivery] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TCartList] ON 

INSERT [dbo].[TCartList] ([id], [UserId], [MenuId]) VALUES (4, 2, 3)
INSERT [dbo].[TCartList] ([id], [UserId], [MenuId]) VALUES (5, 1, 5)
INSERT [dbo].[TCartList] ([id], [UserId], [MenuId]) VALUES (6, 2, 4)
INSERT [dbo].[TCartList] ([id], [UserId], [MenuId]) VALUES (15, 4, 4)
INSERT [dbo].[TCartList] ([id], [UserId], [MenuId]) VALUES (16, 5, 7)
SET IDENTITY_INSERT [dbo].[TCartList] OFF
GO
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (1, N'Biriyani', 200, 1, CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'Main', 1)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (2, N'ChickenFry', 150, 1, CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'Main', 1)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (3, N'lemonJuice', 20, 1, CAST(N'2021-05-01T00:00:00.000' AS DateTime), N'Juice', 0)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (4, N'waterMelonJuice', 30, 1, CAST(N'2021-05-01T00:00:00.000' AS DateTime), N'Juice', 0)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (5, N'SandWich', 100, 1, CAST(N'2021-05-01T00:00:00.000' AS DateTime), N'Starters', 1)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (6, N'IceCream', 70, 1, CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'Starters', 0)
INSERT [dbo].[TMenuList] ([id], [name], [price], [active], [dateOfLaunch], [category], [freeDelivery]) VALUES (7, N'Salad', 100, 1, CAST(N'2021-05-05T00:00:00.000' AS DateTime), N'Starters', 1)

GO
/****** Object:  StoredProcedure [dbo].[pr_GetmenuItemCustomer]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_GetmenuItemCustomer]
(
@today date
)
as
begin
select * from menu where Active=1 and dateOfLaunch <= @today
end
GO
/****** Object:  StoredProcedure [dbo].[pr_updatemenu]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_updatemenu]
(
@name varchar, @price float, @active bit, @date datetime, @category varchar, @delivery bit, @id int
)
as begin
update menu set [name]=@name,price=@price, active=@active, DateOfLaunch=@date, category=@category,freedelivery=@delivery where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[pr_updatemenuList]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_updatemenuList]
(
@name varchar(50), @price float, @active bit, @date datetime, @category varchar(30), @delivery bit
)
as begin
update menu set [name]=@name,price=@price, active=@active, DateOfLaunch=@date, category=@category,freedelivery=@delivery
end
GO
/****** Object:  StoredProcedure [dbo].[pr_updatemenuList1]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pr_updatemenuList1]
(
@name varchar(50), @price float, @active bit, @date datetime, @category varchar(30), @delivery bit, @Id int
)
as begin
update menu set [name]=@name,price=@price, active=@active, DateOfLaunch=@date, category=@category,freedelivery=@delivery, Id=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[T_AddCartItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_AddCartItem]
(
@userId int,
@menuId int
)
as
begin
insert into TCartList (UserId , MenuId) values (@userId , @menuId ) 
end
GO
/****** Object:  StoredProcedure [dbo].[T_addMenuListItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_addMenuListItem](
@id int,
@name varchar(50),
@price float,
@active bit,
@dateoflaunch datetime,
@category varchar(50),
@freedelivery bit
)
as
begin

insert into TMenuList (id, [name], price, active, dateOfLaunch, category, freeDelivery) 
values (@id,@name ,
@price ,
@active ,
@dateoflaunch ,
@category ,
@freedelivery)
end
GO
/****** Object:  StoredProcedure [dbo].[T_EditMenuListItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_EditMenuListItem]
(@id int,@name varchar(50), @price float, @active bit, @date datetime, @category varchar(50), @delivery bit)
as begin
update TMenuList set name=@name,price=@price, active=@active, dateoflaunch=@date, category=@category,freedelivery=@delivery
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[T_GetMenuList]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[T_GetMenuList]
as
begin
select * from TMenuList
end
GO
/****** Object:  StoredProcedure [dbo].[T_GetmenulistCustomer]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_GetmenulistCustomer]
(
@today datetime
)
as
begin
select * from TMenuList where active='1' and dateoflaunch<=@today
end
GO
/****** Object:  StoredProcedure [dbo].[T_GetMenuListItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_GetMenuListItem]
(
@menuItemId int
)
as
begin
select * from Tmenulist where id=@menuItemId
end
GO
/****** Object:  StoredProcedure [dbo].[T_RemoveCartItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_RemoveCartItem]
(
@userId int,
@menuId int
)
as
begin
delete from TCartList where userId=@userId and menuId=@menuId
end
GO
/****** Object:  StoredProcedure [dbo].[T_RemoveMenuListItem]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[T_RemoveMenuListItem]
(
@id int
)
as
begin
delete from TMenuList where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[T_ViewCartList]    Script Date: 14-05-2021 18:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[T_ViewCartList]
(
@userId int
)
as
begin
select * from TMenuList m left join Tcartlist c on m.id=c.menuid where c.userid=@userId
end
GO
USE [master]
GO
ALTER DATABASE [TruyumDB] SET  READ_WRITE 
GO
