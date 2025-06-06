USE [master]
GO
/****** Object:  Database [gestion_de_stock]    Script Date: 21/05/2025 20:44:48 ******/
CREATE DATABASE [gestion_de_stock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestion_de_stock', FILENAME = N'D:\sql\MSSQL12.MSSQLSERVER\MSSQL\DATA\gestion_de_stock.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'gestion_de_stock_log', FILENAME = N'D:\sql\MSSQL12.MSSQLSERVER\MSSQL\DATA\gestion_de_stock_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [gestion_de_stock] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gestion_de_stock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gestion_de_stock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gestion_de_stock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gestion_de_stock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gestion_de_stock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gestion_de_stock] SET ARITHABORT OFF 
GO
ALTER DATABASE [gestion_de_stock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gestion_de_stock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gestion_de_stock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gestion_de_stock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gestion_de_stock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gestion_de_stock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gestion_de_stock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gestion_de_stock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gestion_de_stock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gestion_de_stock] SET  ENABLE_BROKER 
GO
ALTER DATABASE [gestion_de_stock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gestion_de_stock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gestion_de_stock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gestion_de_stock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gestion_de_stock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gestion_de_stock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gestion_de_stock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gestion_de_stock] SET RECOVERY FULL 
GO
ALTER DATABASE [gestion_de_stock] SET  MULTI_USER 
GO
ALTER DATABASE [gestion_de_stock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gestion_de_stock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [gestion_de_stock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [gestion_de_stock] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [gestion_de_stock] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'gestion_de_stock', N'ON'
GO
USE [gestion_de_stock]
GO
/****** Object:  Table [dbo].[Categorie]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie](
	[ID_Categorie] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Categorie] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](100) NOT NULL,
	[Prenom] [nvarchar](100) NOT NULL,
	[Telephone] [nvarchar](20) NULL,
	[Adresse] [nvarchar](255) NULL,
	[Email] [nvarchar](100) NULL,
	[Ville] [nvarchar](100) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Commande]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Commande](
	[ID_Commande] [int] IDENTITY(1,1) NOT NULL,
	[date_Commande] [datetime] NOT NULL,
	[ID_Client] [int] NOT NULL,
	[Total_HT] [decimal](18, 2) NULL,
	[TVA] [decimal](18, 2) NULL,
	[Total_TTC] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Commande] PRIMARY KEY CLUSTERED 
(
	[ID_Commande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Details_Commande]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Details_Commande](
	[ID_Commande] [int] NOT NULL,
	[ID_Produit] [int] NOT NULL,
	[Quantite] [int] NOT NULL,
	[Prix] [nvarchar](250) NOT NULL,
	[Remise] [nvarchar](250) NOT NULL,
	[Total] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Details_Commande] PRIMARY KEY CLUSTERED 
(
	[ID_Commande] ASC,
	[ID_Produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produit]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produit](
	[Id_produit] [int] IDENTITY(1,1) NOT NULL,
	[Nom_produit] [nvarchar](100) NOT NULL,
	[Quantité_produit] [int] NOT NULL,
	[Prix_produit] [decimal](10, 2) NOT NULL,
	[Image_produit] [varbinary](max) NULL,
	[ID_Categorie] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[utilisateur]    Script Date: 21/05/2025 20:44:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[utilisateur](
	[Nomutilisateur] [nvarchar](250) NOT NULL,
	[Mot_De_Passe] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_utilisateur] PRIMARY KEY CLUSTERED 
(
	[Nomutilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Commande]  WITH CHECK ADD  CONSTRAINT [FK_Commande_Client] FOREIGN KEY([ID_Client])
REFERENCES [dbo].[Client] ([ID_Client])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Commande] CHECK CONSTRAINT [FK_Commande_Client]
GO
ALTER TABLE [dbo].[Details_Commande]  WITH CHECK ADD  CONSTRAINT [FK_Details_Commande_Commande] FOREIGN KEY([ID_Commande])
REFERENCES [dbo].[Commande] ([ID_Commande])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Details_Commande] CHECK CONSTRAINT [FK_Details_Commande_Commande]
GO
ALTER TABLE [dbo].[Details_Commande]  WITH CHECK ADD  CONSTRAINT [FK_Details_Commande_Produit] FOREIGN KEY([ID_Produit])
REFERENCES [dbo].[Produit] ([Id_produit])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Details_Commande] CHECK CONSTRAINT [FK_Details_Commande_Produit]
GO
ALTER TABLE [dbo].[Produit]  WITH CHECK ADD FOREIGN KEY([ID_Categorie])
REFERENCES [dbo].[Categorie] ([ID_Categorie])
GO
USE [master]
GO
ALTER DATABASE [gestion_de_stock] SET  READ_WRITE 
GO
