USE [GestioneOrdClienti]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16/04/2021 11:46:04 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 16/04/2021 11:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clienti](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CodiceCliente] [nvarchar](max) NOT NULL,
	[Nome] [nvarchar](max) NOT NULL,
	[Cognome] [nvarchar](max) NULL,
 CONSTRAINT [PK_Clienti] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordini]    Script Date: 16/04/2021 11:46:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordini](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DataOrdine] [datetime2](7) NOT NULL,
	[CodiceOrdine] [nvarchar](max) NOT NULL,
	[CodiceProdotto] [nvarchar](max) NOT NULL,
	[Importo] [decimal](18, 2) NOT NULL,
	[ClienteID] [int] NULL,
 CONSTRAINT [PK_Ordini] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210416081652_MyMigration', N'3.1.14')
GO
SET IDENTITY_INSERT [dbo].[Clienti] ON 

INSERT [dbo].[Clienti] ([ID], [CodiceCliente], [Nome], [Cognome]) VALUES (1, N'F304', N'Carlo', N'Neri')
INSERT [dbo].[Clienti] ([ID], [CodiceCliente], [Nome], [Cognome]) VALUES (2, N'C444', N'Lucia', N'Bianchi')
INSERT [dbo].[Clienti] ([ID], [CodiceCliente], [Nome], [Cognome]) VALUES (3, N'G890', N'Mario', N'Rossi')
SET IDENTITY_INSERT [dbo].[Clienti] OFF
GO
SET IDENTITY_INSERT [dbo].[Ordini] ON 

INSERT [dbo].[Ordini] ([ID], [DataOrdine], [CodiceOrdine], [CodiceProdotto], [Importo], [ClienteID]) VALUES (3, CAST(N'2021-03-04T00:00:00.0000000' AS DateTime2), N'A201', N'P9090', CAST(1000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Ordini] ([ID], [DataOrdine], [CodiceOrdine], [CodiceProdotto], [Importo], [ClienteID]) VALUES (4, CAST(N'2021-04-03T00:00:00.0000000' AS DateTime2), N'A202', N'P4400', CAST(200.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Ordini] ([ID], [DataOrdine], [CodiceOrdine], [CodiceProdotto], [Importo], [ClienteID]) VALUES (5, CAST(N'2021-09-03T00:00:00.0000000' AS DateTime2), N'A204', N'P8U8U', CAST(230.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Ordini] ([ID], [DataOrdine], [CodiceOrdine], [CodiceProdotto], [Importo], [ClienteID]) VALUES (6, CAST(N'2021-04-15T00:00:00.0000000' AS DateTime2), N'A205', N'P7878', CAST(1299.90 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[Ordini] OFF
GO
ALTER TABLE [dbo].[Ordini]  WITH CHECK ADD  CONSTRAINT [FK_Ordini_Clienti_ClienteID] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clienti] ([ID])
GO
ALTER TABLE [dbo].[Ordini] CHECK CONSTRAINT [FK_Ordini_Clienti_ClienteID]
GO
