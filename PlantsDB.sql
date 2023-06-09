USE [master]
GO
/****** Object:  Database [PlantsDB]    Script Date: 6/15/2023 12:03:20 PM ******/
CREATE DATABASE [PlantsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PlantsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PlantsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PlantsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PlantsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PlantsDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PlantsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PlantsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PlantsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PlantsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PlantsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PlantsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [PlantsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PlantsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PlantsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PlantsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PlantsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PlantsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PlantsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PlantsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PlantsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PlantsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PlantsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PlantsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PlantsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PlantsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PlantsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PlantsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PlantsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PlantsDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PlantsDB] SET  MULTI_USER 
GO
ALTER DATABASE [PlantsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PlantsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PlantsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PlantsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PlantsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PlantsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PlantsDB] SET QUERY_STORE = OFF
GO
USE [PlantsDB]
GO
/****** Object:  Table [dbo].[Plants]    Script Date: 6/15/2023 12:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plants](
	[PlantId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Type] [varchar](100) NOT NULL,
	[Size] [varchar](50) NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Colors] [varchar](255) NULL,
	[Description] [text] NULL,
	[Availability] [varchar](20) NULL,
	[DateAdded] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/15/2023 12:03:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Plants] ON 

INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (1, N'Snake Plant', N'Houseplant', N'Medium', CAST(29.99 AS Decimal(10, 2)), N'Green', N'Low maintenance plant with upright leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.350' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (2, N'Monstera Deliciosa', N'Houseplant', N'Large', CAST(49.99 AS Decimal(10, 2)), N'Green', N'Popular plant with fenestrated leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.353' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (3, N'Peace Lily', N'Houseplant', N'Small', CAST(19.99 AS Decimal(10, 2)), N'White', N'Air-purifying plant with glossy leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.340' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (4, N'Jade Plant', N'Houseplant', N'Small', CAST(14.99 AS Decimal(10, 2)), N'Green', N'Succulent plant with fleshy leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.343' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (5, N'Pothos', N'Houseplant', N'Medium', CAST(24.99 AS Decimal(10, 2)), N'Green, Golden', N'Trailing plant that is easy to care for', N'In Stock', CAST(N'2023-05-26T22:11:31.360' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (6, N'Rubber Tree', N'Houseplant', N'Large', CAST(39.99 AS Decimal(10, 2)), N'Green', N'Tall plant with large, glossy leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.350' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (7, N'Bird of Paradise', N'Outdoor Plant', N'Large', CAST(59.99 AS Decimal(10, 2)), N'Orange, Blue', N'Tropical plant with distinctive bird-like flowers', N'In Stock', CAST(N'2023-05-26T22:11:31.353' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (8, N'Lavender', N'Outdoor Plant', N'Small', CAST(12.99 AS Decimal(10, 2)), N'Purple', N'Fragrant herb with purple flowers', N'In Stock', CAST(N'2023-05-26T22:11:31.350' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (9, N'Rose Bush', N'Outdoor Plant', N'Medium', CAST(29.99 AS Decimal(10, 2)), N'Red, Pink, Yellow, White', N'Classic flowering plant for gardens', N'In Stock', CAST(N'2023-05-26T22:11:31.353' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (10, N'Fiddle Leaf Fig', N'Houseplant', N'Large', CAST(59.99 AS Decimal(10, 2)), N'Green', N'Trendy plant with large, violin-shaped leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.350' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (11, N'ZZ Plant', N'Houseplant', N'Medium', CAST(34.99 AS Decimal(10, 2)), N'Green', N'Low-maintenance plant with glossy, dark green leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.343' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (12, N'Aloe Vera', N'Houseplant', N'Small', CAST(19.99 AS Decimal(10, 2)), N'Green', N'Succulent plant with medicinal properties', N'In Stock', CAST(N'2023-05-26T22:11:31.357' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (13, N'Spider Plant', N'Houseplant', N'Small', CAST(14.99 AS Decimal(10, 2)), N'Green, White', N'Easy-to-grow plant with arching leaves and small white flowers', N'In Stock', CAST(N'2023-05-26T22:11:31.360' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (14, N'Bamboo Palm', N'Houseplant', N'Medium', CAST(29.99 AS Decimal(10, 2)), N'Green', N'Indoor palm with slender, bamboo-like stems', N'In Stock', CAST(N'2023-05-26T22:11:31.340' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (15, N'Cactus', N'Houseplant', N'Small', CAST(9.99 AS Decimal(10, 2)), N'Green', N'Desert plant with spiky stems and unique shapes', N'In Stock', CAST(N'2023-05-26T22:11:31.347' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (16, N'Lemon Tree', N'Outdoor Plant', N'Large', CAST(49.99 AS Decimal(10, 2)), N'Green, Yellow', N'Fruit tree that produces juicy lemons', N'In Stock', CAST(N'2023-05-26T22:11:31.347' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (17, N'Hibiscus', N'Outdoor Plant', N'Medium', CAST(24.99 AS Decimal(10, 2)), N'Red, Pink, Yellow, Orange', N'Colorful flowering plant with large, showy blooms', N'In Stock', CAST(N'2023-05-26T22:11:31.340' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (18, N'Succulent Assortment', N'Houseplant', N'Small', CAST(19.99 AS Decimal(10, 2)), N'Various', N'Collection of assorted succulent plants', N'In Stock', CAST(N'2023-05-26T22:11:31.340' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (19, N'Palm Tree', N'Outdoor Plant', N'Large', CAST(79.99 AS Decimal(10, 2)), N'Green', N'Tropical tree with large, fan-shaped leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.337' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (20, N'English Ivy', N'Houseplant', N'Medium', CAST(24.99 AS Decimal(10, 2)), N'Green', N'Climbing plant with small, lobed leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.353' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (21, N'Calathea', N'Houseplant', N'Small', CAST(19.99 AS Decimal(10, 2)), N'Green, Purple', N'Ornamental plant with vibrant, patterned leaves', N'In Stock', CAST(N'2023-05-26T22:11:31.350' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (22, N'Dwarf Umbrella Tree', N'Houseplant', N'Medium', CAST(39.99 AS Decimal(10, 2)), N'Green', N'Compact plant with umbrella-shaped leaf clusters', N'In Stock', CAST(N'2023-05-26T22:11:31.343' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (23, N'Strawberry Plant', N'Edible Plant', N'Small', CAST(9.99 AS Decimal(10, 2)), N'Green, Red', N'Produces sweet and juicy strawberries', N'In Stock', CAST(N'2023-05-26T22:11:31.340' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (24, N'Basil', N'Edible Plant', N'Small', CAST(6.99 AS Decimal(10, 2)), N'Green', N'Popular herb used in cooking and pesto', N'In Stock', CAST(N'2023-05-26T22:11:31.347' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (25, N'Mint', N'Edible Plant', N'Small', CAST(6.99 AS Decimal(10, 2)), N'Green', N'Aromatic herb commonly used in beverages and desserts', N'In Stock', CAST(N'2023-05-26T22:11:31.347' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (26, N'Lavender', N'Houseplant', N'Small', CAST(14.99 AS Decimal(10, 2)), N'Purple', N'Fragrant herb with purple flowers', N'In Stock', CAST(N'2023-05-26T22:11:31.343' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (27, N'Cherry Tomato Plant', N'Edible Plant', N'Medium', CAST(12.99 AS Decimal(10, 2)), N'Green, Red', N'Produces small, flavorful cherry tomatoes', N'In Stock', CAST(N'2023-05-26T22:11:31.353' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (28, N'Rosemary', N'Edible Plant', N'Small', CAST(7.99 AS Decimal(10, 2)), N'Green', N'Aromatic herb used in culinary dishes and seasoning', N'In Stock', CAST(N'2023-05-26T22:11:31.357' AS DateTime))
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded]) VALUES (29, N'Lemon Balm', N'Edible Plant', N'Small', CAST(8.99 AS Decimal(10, 2)), N'Green', N'Herb with lemon-scented leaves often used for tea', N'In Stock', CAST(N'2023-05-26T22:11:31.363' AS DateTime))
SET IDENTITY_INSERT [dbo].[Plants] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (1, N'johndoe', N'p@ssw0rd', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (2, N'janedoe', N'password123', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (3, N'alice', N'securepass', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (4, N'bobsmith', N'mysecretpass', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (5, N'adminuser', N'adminpass123', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ((0)) FOR [IsAdmin]
GO
USE [master]
GO
ALTER DATABASE [PlantsDB] SET  READ_WRITE 
GO
