USE [congreso]
GO
/****** Object:  Table [dbo].[tipo_registros]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_registros](
	[id_tipo_registro] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_registro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_membresias]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_membresias](
	[id_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[costo] [float] NOT NULL,
	[descuento_congreso] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[posicion_titulo]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[posicion_titulo](
	[id_titulo] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_titulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[titulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[organizaciones]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[organizaciones](
	[id_organizacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[ciudad] [varchar](30) NOT NULL,
	[estado] [varchar](30) NOT NULL,
	[pais] [varchar](30) NOT NULL,
	[creado] [datetime] NULL,
	[estatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_organizacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[admins]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[admins](
	[id_admin] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellidos] [varchar](30) NOT NULL,
	[email] [varchar](50) NULL,
	[celular] [varchar](30) NULL,
	[usuario] [varchar](30) NOT NULL,
	[pass] [varchar](30) NOT NULL,
	[creado] [datetime] NULL,
	[estatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_admin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuarios](
	[pin] [int] IDENTITY(1000,6) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[posicion_titulo] [varchar](50) NULL,
	[nombre] [varchar](40) NOT NULL,
	[apellidos] [varchar](60) NOT NULL,
	[sexo] [varchar](20) NULL,
	[email] [varchar](50) NOT NULL,
	[telefono] [varchar](15) NULL,
	[organizacion] [int] NOT NULL,
	[disciplina] [varchar](100) NULL,
	[url] [varchar](250) NULL,
	[foto] [image] NULL,
	[factura] [varchar](2) NULL,
	[razonsocial] [varchar](150) NULL,
	[rfc] [varchar](30) NULL,
	[domiciliofiscal] [varchar](100) NULL,
	[creado] [datetime] NULL,
	[estatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[pin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[miembros_old]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[miembros_old](
	[id_miembro_old] [int] IDENTITY(1,1) NOT NULL,
	[miembro] [int] NOT NULL,
	[membresia] [int] NULL,
	[pago] [float] NULL,
	[creado] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_miembro_old] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[miembros]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[miembros](
	[id_miembro] [int] IDENTITY(1,1) NOT NULL,
	[miembro] [int] NOT NULL,
	[membresia] [int] NULL,
	[pago] [float] NULL,
	[creado] [datetime] NULL,
	[estatus] [varchar](20) NULL,
	[recibo] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_miembro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[miembro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[capitulos]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[capitulos](
	[id_capitulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[organizacion] [int] NULL,
	[presidente] [int] NULL,
	[encargado] [int] NULL,
	[comentarios] [varchar](250) NULL,
	[creado] [datetime] NULL,
	[estatus] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_capitulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[capitulo_integrantes]    Script Date: 01/11/2018 14:59:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[capitulo_integrantes](
	[id_cap_integrante] [int] IDENTITY(1,1) NOT NULL,
	[capitulo] [int] NULL,
	[integrante] [int] NULL,
	[creado] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cap_integrante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__admins__creado__29572725]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[admins] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__admins__estatus__2A4B4B5E]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[admins] ADD  DEFAULT ('Activo') FOR [estatus]
GO
/****** Object:  Default [DF__capitulo___cread__3F115E1A]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulo_integrantes] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__capitulos__cread__37703C52]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulos] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__capitulos__estat__3864608B]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulos] ADD  DEFAULT ('Activo') FOR [estatus]
GO
/****** Object:  Default [DF__miembros__creado__59C55456]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__miembros__estatu__5AB9788F]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros] ADD  DEFAULT ('No_Activo') FOR [estatus]
GO
/****** Object:  Default [DF__organizac__cread__1367E606]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[organizaciones] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__organizac__estat__145C0A3F]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[organizaciones] ADD  DEFAULT ('Activo') FOR [estatus]
GO
/****** Object:  Default [DF__usuarios__creado__300424B4]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT (getdate()) FOR [creado]
GO
/****** Object:  Default [DF__usuarios__estatu__30F848ED]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[usuarios] ADD  DEFAULT ('Activo') FOR [estatus]
GO
/****** Object:  ForeignKey [FK__capitulo___capit__3D2915A8]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulo_integrantes]  WITH CHECK ADD FOREIGN KEY([capitulo])
REFERENCES [dbo].[capitulos] ([id_capitulo])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__capitulo___integ__3E1D39E1]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulo_integrantes]  WITH CHECK ADD FOREIGN KEY([integrante])
REFERENCES [dbo].[usuarios] ([pin])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__capitulos__encar__367C1819]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulos]  WITH CHECK ADD FOREIGN KEY([encargado])
REFERENCES [dbo].[usuarios] ([pin])
GO
/****** Object:  ForeignKey [FK__capitulos__organ__3493CFA7]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulos]  WITH CHECK ADD FOREIGN KEY([organizacion])
REFERENCES [dbo].[organizaciones] ([id_organizacion])
GO
/****** Object:  ForeignKey [FK__capitulos__presi__3587F3E0]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[capitulos]  WITH CHECK ADD FOREIGN KEY([presidente])
REFERENCES [dbo].[usuarios] ([pin])
ON DELETE SET NULL
GO
/****** Object:  ForeignKey [FK__miembros__membre__58D1301D]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros]  WITH CHECK ADD FOREIGN KEY([membresia])
REFERENCES [dbo].[tipo_membresias] ([id_tipo])
GO
/****** Object:  ForeignKey [FK__miembros__miembr__57DD0BE4]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros]  WITH CHECK ADD FOREIGN KEY([miembro])
REFERENCES [dbo].[usuarios] ([pin])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__miembros___membr__607251E5]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros_old]  WITH CHECK ADD FOREIGN KEY([membresia])
REFERENCES [dbo].[tipo_membresias] ([id_tipo])
GO
/****** Object:  ForeignKey [FK__miembros___miemb__5F7E2DAC]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[miembros_old]  WITH CHECK ADD FOREIGN KEY([miembro])
REFERENCES [dbo].[usuarios] ([pin])
ON DELETE CASCADE
GO
/****** Object:  ForeignKey [FK__usuarios__organi__2F10007B]    Script Date: 01/11/2018 14:59:32 ******/
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([organizacion])
REFERENCES [dbo].[organizaciones] ([id_organizacion])
GO
