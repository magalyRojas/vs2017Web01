USE [master]
GO
/****** Object:  Database [dbComercio]    Script Date: 24/02/2019 14:03:12 ******/
CREATE DATABASE [dbComercio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbComercio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbComercio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbComercio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\dbComercio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [dbComercio] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbComercio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbComercio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbComercio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbComercio] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbComercio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbComercio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbComercio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbComercio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbComercio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbComercio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbComercio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbComercio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbComercio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbComercio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbComercio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbComercio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbComercio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbComercio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbComercio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbComercio] SET RECOVERY FULL 
GO
ALTER DATABASE [dbComercio] SET  MULTI_USER 
GO
ALTER DATABASE [dbComercio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbComercio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbComercio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbComercio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbComercio] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbComercio', N'ON'
GO
ALTER DATABASE [dbComercio] SET QUERY_STORE = OFF
GO
USE [dbComercio]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [dbComercio]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 24/02/2019 14:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[CategoriaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Marca]    Script Date: 24/02/2019 14:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[MarcaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[MarcaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/02/2019 14:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProductoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoCode] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[CategoriaID] [int] NOT NULL,
	[MarcaID] [int] NOT NULL,
	[UnidadMedidaID] [int] NOT NULL,
	[PrecioMayor] [decimal](18, 2) NOT NULL,
	[PrecioMenor] [decimal](18, 2) NOT NULL,
	[StockActual] [decimal](18, 2) NULL,
	[StockMinimo] [decimal](18, 2) NULL,
	[Estado] [bit] NULL,
	[UsuarioCreador] [uniqueidentifier] NULL,
	[FechaCreacion] [datetime] NULL,
	[UsuarioModificador] [uniqueidentifier] NULL,
	[FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UnidadMedida]    Script Date: 24/02/2019 14:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnidadMedida](
	[UnidadMedidaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UnidadMedida] PRIMARY KEY CLUSTERED 
(
	[UnidadMedidaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/02/2019 14:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Roles] [nvarchar](200) NULL,
	[Nombres] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (1, N'Mouse USB', N'perisferico', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Audifonos Inhalambricos', N'prueba1', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (4, N'Teclado USB', N'teclado', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (5, N'Laptop', N'computadora personal', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (6, N'Parlantes Inhalambricos', N'perisferico', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (9, N'Pantalla Lcd', N'monitor', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (10, N'LX-300', N'impresora', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (11, N'Mouse Inhalambrico', N'Mouse ', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (12, N'teclado inhalambrico', N'teclado', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (13, N'Teclado gamer', N'teclado', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (14, N'Impresoras Matriciales', N'impresora', 0)
INSERT [dbo].[Categoria] ([CategoriaID], [Nombre], [Descripcion], [Estado]) VALUES (15, N'Impresoras Laser', N'Impresoras colores', 0)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Marca] ON 

INSERT [dbo].[Marca] ([MarcaID], [Nombre], [Descripcion], [Estado]) VALUES (1, N'HP', N'hewlett packard', 0)
INSERT [dbo].[Marca] ([MarcaID], [Nombre], [Descripcion], [Estado]) VALUES (2, N'Compac', N'Compac', 0)
SET IDENTITY_INSERT [dbo].[Marca] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ProductoID], [ProductoCode], [Nombre], [CategoriaID], [MarcaID], [UnidadMedidaID], [PrecioMayor], [PrecioMenor], [StockActual], [StockMinimo], [Estado], [UsuarioCreador], [FechaCreacion], [UsuarioModificador], [FechaModificacion]) VALUES (5, N'001', N'Teclado', 4, 1, 1, CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 1, N'45f7ee9c-908f-4624-b936-2590d69f19e6', CAST(N'2019-02-03T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Producto] ([ProductoID], [ProductoCode], [Nombre], [CategoriaID], [MarcaID], [UnidadMedidaID], [PrecioMayor], [PrecioMenor], [StockActual], [StockMinimo], [Estado], [UsuarioCreador], [FechaCreacion], [UsuarioModificador], [FechaModificacion]) VALUES (6, N'002', N'Mouse', 1, 2, 1, CAST(15.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), 1, N'45f7ee9c-908f-4624-b936-2590d69f19e6', CAST(N'2019-02-03T00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Producto] ([ProductoID], [ProductoCode], [Nombre], [CategoriaID], [MarcaID], [UnidadMedidaID], [PrecioMayor], [PrecioMenor], [StockActual], [StockMinimo], [Estado], [UsuarioCreador], [FechaCreacion], [UsuarioModificador], [FechaModificacion]) VALUES (7, N'005', N'Monitor x', 9, 1, 1, CAST(250.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([ProductoID], [ProductoCode], [Nombre], [CategoriaID], [MarcaID], [UnidadMedidaID], [PrecioMayor], [PrecioMenor], [StockActual], [StockMinimo], [Estado], [UsuarioCreador], [FechaCreacion], [UsuarioModificador], [FechaModificacion]) VALUES (8, N'006', N'teclado de colores', 2, 1, 1, CAST(55.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Producto] ([ProductoID], [ProductoCode], [Nombre], [CategoriaID], [MarcaID], [UnidadMedidaID], [PrecioMayor], [PrecioMenor], [StockActual], [StockMinimo], [Estado], [UsuarioCreador], [FechaCreacion], [UsuarioModificador], [FechaModificacion]) VALUES (9, N'007', N'Mouse', 1, 1, 1, CAST(15.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[UnidadMedida] ON 

INSERT [dbo].[UnidadMedida] ([UnidadMedidaID], [Nombre]) VALUES (1, N'Caja')
INSERT [dbo].[UnidadMedida] ([UnidadMedidaID], [Nombre]) VALUES (2, N'Metro')
SET IDENTITY_INSERT [dbo].[UnidadMedida] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([UsuarioID], [Login], [Password], [Roles], [Nombres], [Apellidos], [Email]) VALUES (1, N'admin', N'admin', N'Admin', N'Magaly', N'Rojas', N'mmm@gmail.com')
INSERT [dbo].[Usuario] ([UsuarioID], [Login], [Password], [Roles], [Nombres], [Apellidos], [Email]) VALUES (2, N'operador', N'operador', N'Operador;Admin', N'Fulano ', N'de Tal', N'fulano@gmail.com')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categoria] ([CategoriaID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Marca] FOREIGN KEY([MarcaID])
REFERENCES [dbo].[Marca] ([MarcaID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Marca]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_UnidadMedida] FOREIGN KEY([UnidadMedidaID])
REFERENCES [dbo].[UnidadMedida] ([UnidadMedidaID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_UnidadMedida]
GO
USE [master]
GO
ALTER DATABASE [dbComercio] SET  READ_WRITE 
GO
