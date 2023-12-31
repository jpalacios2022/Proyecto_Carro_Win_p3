USE [Proyecto_Carro]
GO
/****** Object:  Table [dbo].[Carros]    Script Date: 11/30/2012 15:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carros](
	[Nro_producto] [char](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Descripcion] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Unidades_inventario] [int] NOT NULL,
	[Precio] [money] NOT NULL,
	[Modelo] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF