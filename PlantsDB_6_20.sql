USE [master]
GO
/****** Object:  Database [PlantsDB]    Script Date: 6/20/2023 6:57:47 PM ******/
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
/****** Object:  Table [dbo].[Comments]    Script Date: 6/20/2023 6:57:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[PlantID] [int] NULL,
	[Comment] [text] NULL,
	[UserID] [int] NULL,
	[CommentDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plants]    Script Date: 6/20/2023 6:57:47 PM ******/
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
	[DateAdded] [date] NULL,
	[CareDifficulty] [int] NULL,
	[CareDetails] [text] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK__Plants__98FE395C0D50030B] PRIMARY KEY CLUSTERED 
(
	[PlantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/20/2023 6:57:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
 CONSTRAINT [PK__Users__1788CC4C71BF9728] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (1, 1, N'This plant is beautiful!', 2, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (2, 3, N'Can this plant tolerate low light conditions?', 4, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (3, 5, N'I love the taste of strawberries from this plant!', 1, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (4, 7, N'The fragrance of lavender is so calming.', 3, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (5, 9, N'I have been wanting to grow my own herbs, and this basil looks great!', 2, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (6, 11, N'Is this plant safe for pets?', 4, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (7, 13, N'Jade plants are one of my favorites!', 1, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (8, 15, N'I have owned a snake plant for years, and it is so easy to care for.', 3, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (9, 17, N'Mint is a must-have in my kitchen!', 2, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
INSERT [dbo].[Comments] ([CommentID], [PlantID], [Comment], [UserID], [CommentDate]) VALUES (10, 19, N'Pothos plants are perfect for adding greenery to any space.', 4, CAST(N'2023-06-20T18:49:40.740' AS DateTime))
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Plants] ON 

INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (1, N'Aloe Vera', N'Succulent', N'Small', CAST(12.99 AS Decimal(10, 2)), NULL, N'Popular succulent with medicinal properties', NULL, CAST(N'2023-06-20' AS Date), 4, N'Water sparingly, requires well-draining soil', 2)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (2, N'Jasmine', N'Flowering', N'Medium', CAST(19.99 AS Decimal(10, 2)), NULL, N'Fragrant flowers used in perfumes and teas', NULL, CAST(N'2023-06-20' AS Date), 6, N'Prefers bright indirect light and regular watering', 3)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (3, N'Moss Rose', N'Flowering', N'Small', CAST(8.99 AS Decimal(10, 2)), NULL, N'Low-growing plant with vibrant flowers', NULL, CAST(N'2023-06-20' AS Date), 3, N'Thrives in sunny locations, water moderately', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (4, N'Lemon Tree', N'Edible', N'Large', CAST(29.99 AS Decimal(10, 2)), NULL, N'Produces juicy lemons', NULL, CAST(N'2023-06-20' AS Date), 7, N'Requires full sun, water deeply but infrequently', 2)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (5, N'Tillandsia', N'Air-Plant', N'Small', CAST(6.99 AS Decimal(10, 2)), NULL, N'Low-maintenance plant that does not require soil', NULL, CAST(N'2023-06-20' AS Date), 2, N'Mist regularly, bright indirect light', 4)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (6, N'Cactus', N'Succulent', N'Small', CAST(9.99 AS Decimal(10, 2)), NULL, N'Thorny desert plant that requires minimal watering', NULL, CAST(N'2023-06-20' AS Date), 3, N'Water sparingly, well-draining soil', 3)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (7, N'Orchid', N'Flowering', N'Medium', CAST(24.99 AS Decimal(10, 2)), NULL, N'Elegant flowers that come in a variety of colors', NULL, CAST(N'2023-06-20' AS Date), 5, N'Prefers indirect light, water carefully', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (8, N'Bamboo', N'Air-Plant', N'Large', CAST(39.99 AS Decimal(10, 2)), NULL, N'Fast-growing plant often used for decorative purposes', NULL, CAST(N'2023-06-20' AS Date), 6, N'Requires bright light and ample watering', 2)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (9, N'Rose', N'Flowering', N'Medium', CAST(17.99 AS Decimal(10, 2)), NULL, N'Classic flower known for its beauty and fragrance', NULL, CAST(N'2023-06-20' AS Date), 8, N'Prefers full sun, prune regularly', 4)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (10, N'Chili Pepper', N'Edible', N'Small', CAST(7.99 AS Decimal(10, 2)), NULL, N'Spicy pepper used in various culinary dishes', NULL, CAST(N'2023-06-20' AS Date), 7, N'Full sun, moderate watering, well-draining soil', 3)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (11, N'Succulent Mix', N'Succulent', N'Small', CAST(11.99 AS Decimal(10, 2)), NULL, N'Assortment of different succulent varieties', NULL, CAST(N'2023-06-20' AS Date), 4, N'Water sparingly, prefers bright light', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (12, N'Fiddle Leaf Fig', N'Flowering', N'Large', CAST(49.99 AS Decimal(10, 2)), NULL, N'Trendy plant with large, violin-shaped leaves', NULL, CAST(N'2023-06-13' AS Date), 5, N'Requires bright indirect light, water when topsoil is dry', 2)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (13, N'Strawberry Plant', N'Edible', N'Small', CAST(6.99 AS Decimal(10, 2)), NULL, N'Produces sweet and juicy strawberries', NULL, CAST(N'2023-06-10' AS Date), 4, N'Full sun, regular watering, well-draining soil', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (14, N'Spider Plant', N'Air-Plant', N'Small', CAST(12.99 AS Decimal(10, 2)), NULL, N'Easy-to-care-for plant with arching variegated leaves', NULL, CAST(N'2023-06-05' AS Date), 2, N'Thrives in bright indirect light, water moderately', 3)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (15, N'Lavender', N'Flowering', N'Medium', CAST(14.99 AS Decimal(10, 2)), NULL, N'Fragrant herb with purple flowers', NULL, CAST(N'2023-06-17' AS Date), 3, N'Prefers full sun, well-draining soil, occasional pruning', 4)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (16, N'Money Tree', N'Flowering', N'Medium', CAST(19.99 AS Decimal(10, 2)), NULL, N'Plant with braided trunk and glossy leaves', NULL, CAST(N'2023-06-12' AS Date), 4, N'Indirect light, water when topsoil is dry', 2)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (17, N'Basil', N'Edible', N'Small', CAST(6.99 AS Decimal(10, 2)), NULL, N'Popular herb used in cooking and pesto', NULL, CAST(N'2023-06-08' AS Date), 2, N'Full sun, regular watering, well-draining soil', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (18, N'Jade Plant', N'Succulent', N'Medium', CAST(24.99 AS Decimal(10, 2)), NULL, N'Thick, fleshy leaves and a tree-like appearance', NULL, CAST(N'2023-06-15' AS Date), 6, N'Bright light, infrequent watering, well-draining soil', 3)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (19, N'Snake Plant', N'Flowering', N'Small', CAST(9.99 AS Decimal(10, 2)), NULL, N'Low maintenance plant with upright leaves', NULL, CAST(N'2023-05-31' AS Date), 3, N'Tolerates low light, water sparingly', 4)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (20, N'Mint', N'Edible', N'Small', CAST(7.99 AS Decimal(10, 2)), NULL, N'Aromatic herb commonly used in beverages and desserts', NULL, CAST(N'2023-05-26' AS Date), 2, N'Partial shade, regular watering, moist soil', 1)
INSERT [dbo].[Plants] ([PlantId], [Name], [Type], [Size], [Price], [Colors], [Description], [Availability], [DateAdded], [CareDifficulty], [CareDetails], [UserId]) VALUES (21, N'Pothos', N'Air-Plant', N'Medium', CAST(16.99 AS Decimal(10, 2)), NULL, N'Trailing plant with heart-shaped leaves', NULL, CAST(N'2023-06-03' AS Date), 4, N'Thrives in low to bright indirect light, water moderately', 2)
SET IDENTITY_INSERT [dbo].[Plants] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (1, N'user1', N'pass1', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (2, N'user2', N'pass2', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (3, N'user3', N'pass3', 0)
INSERT [dbo].[Users] ([UserId], [Username], [Password], [IsAdmin]) VALUES (4, N'admin', N'adminpass', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__IsAdmin__286302EC]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK__Comments__PlantI__2A4B4B5E] FOREIGN KEY([PlantID])
REFERENCES [dbo].[Plants] ([PlantId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK__Comments__PlantI__2A4B4B5E]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK__Comments__UserID__2B3F6F97] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK__Comments__UserID__2B3F6F97]
GO
ALTER TABLE [dbo].[Plants]  WITH CHECK ADD  CONSTRAINT [FK_Plants_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Plants] CHECK CONSTRAINT [FK_Plants_Users]
GO
USE [master]
GO
ALTER DATABASE [PlantsDB] SET  READ_WRITE 
GO
