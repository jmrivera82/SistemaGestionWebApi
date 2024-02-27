USE [coderhouse]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 23/02/2022 01:28:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripciones] [varchar](max) NOT NULL,
	[Costo] [money] NULL,
	[PrecioVenta] [money] NOT NULL,
	[Stock] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoVendido]    Script Date: 23/02/2022 01:28:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoVendido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Stock] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdVenta] [int] NOT NULL,
 CONSTRAINT [PK_ProductoVendido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 23/02/2022 01:28:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[NombreUsuario] [varchar](max) NOT NULL,
	[Contrase�a] [varchar](max) NOT NULL,
	[Mail] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 23/02/2022 01:28:41 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comentarios] [varchar](max) NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (1, N'Remera manga larga', 500.0000, 1400.0000, 23, 1)
INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (2, N'Pantalon Jean', 800.0000, 4000.0000, 12, 1)
INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (3, N'Bermuda', 600.0000, 3000.0000, 10, 1)
INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (4, N'Musculosa', 300.0000, 1100.0000, 20, 1)
INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (5, N'Campera', 1500.0000, 8000.0000, 5, 1)
INSERT [dbo].[Producto] ([Id], [Descripciones], [Costo], [PrecioVenta], [Stock], [IdUsuario]) VALUES (6, N'Buzo', 1000.0000, 3000.0000, 14, 1)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductoVendido] ON 

INSERT [dbo].[ProductoVendido] ([Id], [Stock], [IdProducto], [IdVenta]) VALUES (1, 2, 1, 1)
INSERT [dbo].[ProductoVendido] ([Id], [Stock], [IdProducto], [IdVenta]) VALUES (2, 1, 2, 1)
INSERT [dbo].[ProductoVendido] ([Id], [Stock], [IdProducto], [IdVenta]) VALUES (3, 1, 5, 1)
INSERT [dbo].[ProductoVendido] ([Id], [Stock], [IdProducto], [IdVenta]) VALUES (4, 1, 3, 1)
SET IDENTITY_INSERT [dbo].[ProductoVendido] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [NombreUsuario], [Contrase�a], [Mail]) VALUES (1, N'Tobias', N'Casazza', N'tcasazza', N'SoyTobiasCasazza', N'tobiascasazza@gmail.com')
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellido], [NombreUsuario], [Contrase�a], [Mail]) VALUES (2, N'Ernesto', N'Perez', N'eperez', N'SoyErnestoPerez', N'ernestoperez@gmail.com')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (1, N'', 1)
INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (2, N'', 1)
INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (3, N'', 1)
INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (4, N'', 1)
INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (5, N'', 1)
INSERT [dbo].[Venta] ([Id], [Comentarios], [IdUsuario]) VALUES (6, N'', 1)
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Usuario]
GO
ALTER TABLE [dbo].[ProductoVendido]  WITH CHECK ADD  CONSTRAINT [FK_ProductoVendido_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([Id])
GO
ALTER TABLE [dbo].[ProductoVendido] CHECK CONSTRAINT [FK_ProductoVendido_Producto]
GO
ALTER TABLE [dbo].[ProductoVendido]  WITH CHECK ADD  CONSTRAINT [FK_ProductoVendido_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([Id])
GO
ALTER TABLE [dbo].[ProductoVendido] CHECK CONSTRAINT [FK_ProductoVendido_Venta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario]
