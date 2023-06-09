USE [master]
GO
/****** Object:  Database [ShipmentHandler]    Script Date: 8.01.2023 23:45:07 ******/
CREATE DATABASE [ShipmentHandler]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShipmentHandler', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShipmentHandler.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShipmentHandler_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ShipmentHandler_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShipmentHandler] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShipmentHandler].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShipmentHandler] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShipmentHandler] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShipmentHandler] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShipmentHandler] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShipmentHandler] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShipmentHandler] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShipmentHandler] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShipmentHandler] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShipmentHandler] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShipmentHandler] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShipmentHandler] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShipmentHandler] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShipmentHandler] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShipmentHandler] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShipmentHandler] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ShipmentHandler] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShipmentHandler] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShipmentHandler] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShipmentHandler] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShipmentHandler] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShipmentHandler] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShipmentHandler] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShipmentHandler] SET RECOVERY FULL 
GO
ALTER DATABASE [ShipmentHandler] SET  MULTI_USER 
GO
ALTER DATABASE [ShipmentHandler] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShipmentHandler] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShipmentHandler] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShipmentHandler] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShipmentHandler] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShipmentHandler] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShipmentHandler', N'ON'
GO
ALTER DATABASE [ShipmentHandler] SET QUERY_STORE = OFF
GO
USE [ShipmentHandler]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 8.01.2023 23:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClient](
	[ClientID] [int] NOT NULL,
	[Client_Name] [nvarchar](50) NULL,
	[Client_Surname] [nvarchar](50) NULL,
	[Telephone] [int] NULL,
	[Email] [nvarchar](75) NULL,
	[Adress_Information] [nvarchar](300) NULL,
	[Country] [nvarchar](200) NULL,
	[City_Town] [nvarchar](200) NULL,
	[State_Province_Country] [nvarchar](200) NULL,
	[Postal_Code] [int] NULL,
	[Additional_Information] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblItem]    Script Date: 8.01.2023 23:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblItem](
	[ItemID] [int] NOT NULL,
	[Item_Name] [nvarchar](max) NULL,
	[Item_Type] [nvarchar](100) NULL,
	[Item_Price] [int] NULL,
	[Item_Brand] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPickup]    Script Date: 8.01.2023 23:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPickup](
	[Pickup_License] [int] NOT NULL,
	[Driver_ID] [int] NULL,
	[Driver_Name] [nvarchar](50) NULL,
	[Driver_Surname] [nvarchar](50) NULL,
	[Current_Location] [nvarchar](max) NULL,
	[Current_Shipment] [int] NULL,
	[Shipment_List] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Pickup_License] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblShipment]    Script Date: 8.01.2023 23:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblShipment](
	[ShipmentID] [int] NOT NULL,
	[Delivery_Type] [nvarchar](50) NULL,
	[Shipment_Description] [nvarchar](max) NULL,
	[Shipment_Weight] [int] NULL,
	[Item1] [int] NULL,
	[Item2] [int] NULL,
	[Item3] [int] NULL,
	[Client] [int] NULL,
	[Pickup] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblShipmentList]    Script Date: 8.01.2023 23:45:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblShipmentList](
	[Shipment_ListID] [int] NOT NULL,
	[Shipment1] [int] NULL,
	[Shipment2] [int] NULL,
	[Shipment3] [int] NULL,
	[Shipment4] [int] NULL,
	[Shipment5] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Shipment_ListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblPickup]  WITH CHECK ADD  CONSTRAINT [fkp1] FOREIGN KEY([Current_Shipment])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblPickup] CHECK CONSTRAINT [fkp1]
GO
ALTER TABLE [dbo].[tblPickup]  WITH CHECK ADD  CONSTRAINT [fkp2] FOREIGN KEY([Shipment_List])
REFERENCES [dbo].[tblShipmentList] ([Shipment_ListID])
GO
ALTER TABLE [dbo].[tblPickup] CHECK CONSTRAINT [fkp2]
GO
ALTER TABLE [dbo].[tblShipment]  WITH CHECK ADD  CONSTRAINT [fk] FOREIGN KEY([Client])
REFERENCES [dbo].[tblClient] ([ClientID])
GO
ALTER TABLE [dbo].[tblShipment] CHECK CONSTRAINT [fk]
GO
ALTER TABLE [dbo].[tblShipment]  WITH CHECK ADD  CONSTRAINT [fki1] FOREIGN KEY([Item1])
REFERENCES [dbo].[tblItem] ([ItemID])
GO
ALTER TABLE [dbo].[tblShipment] CHECK CONSTRAINT [fki1]
GO
ALTER TABLE [dbo].[tblShipment]  WITH CHECK ADD  CONSTRAINT [fki2] FOREIGN KEY([Item2])
REFERENCES [dbo].[tblItem] ([ItemID])
GO
ALTER TABLE [dbo].[tblShipment] CHECK CONSTRAINT [fki2]
GO
ALTER TABLE [dbo].[tblShipment]  WITH CHECK ADD  CONSTRAINT [fki3] FOREIGN KEY([Item3])
REFERENCES [dbo].[tblItem] ([ItemID])
GO
ALTER TABLE [dbo].[tblShipment] CHECK CONSTRAINT [fki3]
GO
ALTER TABLE [dbo].[tblShipment]  WITH CHECK ADD  CONSTRAINT [fkp] FOREIGN KEY([Pickup])
REFERENCES [dbo].[tblPickup] ([Pickup_License])
GO
ALTER TABLE [dbo].[tblShipment] CHECK CONSTRAINT [fkp]
GO
ALTER TABLE [dbo].[tblShipmentList]  WITH CHECK ADD  CONSTRAINT [fks1] FOREIGN KEY([Shipment1])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblShipmentList] CHECK CONSTRAINT [fks1]
GO
ALTER TABLE [dbo].[tblShipmentList]  WITH CHECK ADD  CONSTRAINT [fks2] FOREIGN KEY([Shipment2])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblShipmentList] CHECK CONSTRAINT [fks2]
GO
ALTER TABLE [dbo].[tblShipmentList]  WITH CHECK ADD  CONSTRAINT [fks3] FOREIGN KEY([Shipment3])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblShipmentList] CHECK CONSTRAINT [fks3]
GO
ALTER TABLE [dbo].[tblShipmentList]  WITH CHECK ADD  CONSTRAINT [fks4] FOREIGN KEY([Shipment4])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblShipmentList] CHECK CONSTRAINT [fks4]
GO
ALTER TABLE [dbo].[tblShipmentList]  WITH CHECK ADD  CONSTRAINT [fks5] FOREIGN KEY([Shipment5])
REFERENCES [dbo].[tblShipment] ([ShipmentID])
GO
ALTER TABLE [dbo].[tblShipmentList] CHECK CONSTRAINT [fks5]
GO
USE [master]
GO
ALTER DATABASE [ShipmentHandler] SET  READ_WRITE 
GO
