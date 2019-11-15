USE [allqo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/11/2019 12:46:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](255) NOT NULL,
	[apellidos] [varchar](255) NOT NULL,
	[direccion] [varchar](255) NOT NULL,
	[dni] [varchar](255) NOT NULL,
	[correo] [varchar](255) NOT NULL,
	[numCelular] [bigint] NOT NULL,
	[estado] [varchar](255) NOT NULL,
	[idLugar] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprobantePago]    Script Date: 15/11/2019 12:46:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobantePago](
	[numComprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[comentario] [varchar](255) NOT NULL,
	[estadoPago] [varchar](255) NOT NULL,
	[numDetalle] [int] NULL,
	[idCliente] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleComprobante]    Script Date: 15/11/2019 12:46:12 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleComprobante](
	[numDetalle] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioUnit] [float] NOT NULL,
	[subtotal] [float] NOT NULL,
	[total] [float] NOT NULL,
	[importe] [float] NOT NULL,
	[idServicio] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[idEspecialidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[idLugar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[agregado] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[idMascota] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[edad] [varchar](255) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idRaza] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Raza]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[idRaza] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[idTipo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Reserva_ID] [int] IDENTITY(1,1) NOT NULL,
	[fechaReservada] [datetime] NOT NULL,
	[fechaSesion] [datetime] NOT NULL,
	[estado] [varchar](255) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idServicio] [int] NOT NULL,
	[idTrabajador] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](255) NOT NULL,
	[descripcion] [varchar](255) NOT NULL,
	[precio] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[idSesion] [int] IDENTITY(1,1) NOT NULL,
	[numMascotas] [int] NOT NULL,
	[estado] [varchar](255) NOT NULL,
	[idReserva] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPerro]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPerro](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[agregado] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[idTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](255) NOT NULL,
	[apellidos] [varchar](255) NOT NULL,
	[dni] [varchar](255) NOT NULL,
	[numCel] [bigint] NOT NULL,
	[idEspecialidad] [int] NULL,
	[direccion] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/11/2019 12:46:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[idEspecialidad] [int] NULL,
 CONSTRAINT [PK_Usuario_1] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (1, N'Victor Raul', N'Haya de la Torre', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (2, N'Ana Victoria', N'Ramos Samaniego', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 3)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (3, N'Andree', N'Galindo', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 4)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (4, N'Sofia', N'Castro Lumbre', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (5, N'Gardenia', N'Salcedo Gallo', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (6, N'Alvaro', N'Villafuerte', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 5)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (7, N'Victor Raul', N'Haya de la Torre', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (8, N'Ana Victoria', N'Ramos Samaniego', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 3)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (9, N'Andree', N'Galindo', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 4)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (10, N'Sofia', N'Castro Lumbre', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (11, N'Gardenia', N'Salcedo Gallo', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (12, N'Alvaro', N'Villafuerte', N'', N'15364532', N'vicrau@gmail.com', 987654321, N'pagado', 5)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (1, N'Gerente General')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (2, N'Asistente de Ventas')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (3, N'Cajero')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (4, N'Adiestrador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (5, N'Paseador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (6, N'General')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
SET IDENTITY_INSERT [dbo].[Lugar] ON 

INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (1, N'LOCAL', 0)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (2, N'SURCO', 3)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (3, N'PUEBLO LIBRE', 7)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (4, N'MIRAFLORES', 5)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (5, N'CHORRILLOS', 4)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (6, N'LOCAL', 0)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (7, N'SURCO', 3)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (8, N'PUEBLO LIBRE', 7)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (9, N'MIRAFLORES', 5)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (10, N'CHORRILLOS', 4)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (11, N'LOCAL', 0)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (12, N'SURCO', 3)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (13, N'PUEBLO LIBRE', 7)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (14, N'MIRAFLORES', 5)
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (15, N'CHORRILLOS', 4)
SET IDENTITY_INSERT [dbo].[Lugar] OFF
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (1, N'PANCHA', N'2 meses', 3, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (2, N'KIRA', N'1 año', 2, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (3, N'BETH', N'3 años', 1, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (4, N'OVEEN', N'1 mes', 6, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (5, N'MANGO', N'4 meses', 5, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (6, N'TACO', N'2 meses', 3, 7)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (1, N'CHIHUAHUA', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (2, N'PUG', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (3, N'BEAGLE', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (4, N'LABRADOR RETRIEVER', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (5, N'CHOW CHOW', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (6, N'BOXER', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (7, N'PIT BULL TERRIER AMERICANO', 2)
SET IDENTITY_INSERT [dbo].[Raza] OFF
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([Reserva_ID], [fechaReservada], [fechaSesion], [estado], [idCliente], [idServicio], [idTrabajador]) VALUES (4, CAST(N'2019-04-11T11:03:12.000' AS DateTime), CAST(N'2019-05-11T21:03:12.000' AS DateTime), N'PAGADO', 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Reserva] OFF
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (1, N'ADIESTRAMIENTO', N'', 15)
INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (2, N'PASEO', N'', 20)
SET IDENTITY_INSERT [dbo].[Servicio] OFF
SET IDENTITY_INSERT [dbo].[TipoPerro] ON 

INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (1, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (2, N'POTENCIALMENTE PELIGROSO', 7)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (3, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (4, N'POTENCIALMENTE PELIGROSO', 7)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (5, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (6, N'POTENCIALMENTE PELIGROSO', 7)
SET IDENTITY_INSERT [dbo].[TipoPerro] OFF
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (1, N'Juan Manuel', N'Sanchez Melendez', N'73432543', 987654321, 1, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (2, N'Julia Rosa', N'Luz Casado', N'73432543', 987654321, 2, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (3, N'Jose Alexander', N'Roque Rodriguez', N'73432543', 987654321, 3, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (4, N'Gianpierre', N'Leon Grados', N'73432543', 987654321, 4, N'')
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
/****** Object:  Index [PK_Cliente1]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [PK_Cliente1] PRIMARY KEY NONCLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_ComprobantePago2]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[ComprobantePago] ADD  CONSTRAINT [PK_ComprobantePago2] PRIMARY KEY NONCLUSTERED 
(
	[numComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_DetalleComprobante7]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[DetalleComprobante] ADD  CONSTRAINT [PK_DetalleComprobante7] PRIMARY KEY NONCLUSTERED 
(
	[numDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Especialidad10]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Especialidad] ADD  CONSTRAINT [PK_Especialidad10] PRIMARY KEY NONCLUSTERED 
(
	[idEspecialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Lugar0]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Lugar] ADD  CONSTRAINT [PK_Lugar0] PRIMARY KEY NONCLUSTERED 
(
	[idLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Mascota3]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Mascota] ADD  CONSTRAINT [PK_Mascota3] PRIMARY KEY NONCLUSTERED 
(
	[idMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Raza4]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Raza] ADD  CONSTRAINT [PK_Raza4] PRIMARY KEY NONCLUSTERED 
(
	[idRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Reserva11]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Reserva] ADD  CONSTRAINT [PK_Reserva11] PRIMARY KEY NONCLUSTERED 
(
	[Reserva_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Servicio8]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Servicio] ADD  CONSTRAINT [PK_Servicio8] PRIMARY KEY NONCLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Sesion6]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Sesion] ADD  CONSTRAINT [PK_Sesion6] PRIMARY KEY NONCLUSTERED 
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_TipoPerro5]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[TipoPerro] ADD  CONSTRAINT [PK_TipoPerro5] PRIMARY KEY NONCLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK_Trabajador9]    Script Date: 15/11/2019 12:46:13 a. m. ******/
ALTER TABLE [dbo].[Trabajador] ADD  CONSTRAINT [PK_Trabajador9] PRIMARY KEY NONCLUSTERED 
(
	[idTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente0] FOREIGN KEY([idLugar])
REFERENCES [dbo].[Lugar] ([idLugar])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente0]
GO
ALTER TABLE [dbo].[ComprobantePago]  WITH CHECK ADD  CONSTRAINT [FK_ComprobantePago_DetalleComprobante] FOREIGN KEY([numDetalle])
REFERENCES [dbo].[DetalleComprobante] ([numDetalle])
GO
ALTER TABLE [dbo].[ComprobantePago] CHECK CONSTRAINT [FK_ComprobantePago_DetalleComprobante]
GO
ALTER TABLE [dbo].[ComprobantePago]  WITH CHECK ADD  CONSTRAINT [FK_ComprobantePago1] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[ComprobantePago] CHECK CONSTRAINT [FK_ComprobantePago1]
GO
ALTER TABLE [dbo].[DetalleComprobante]  WITH CHECK ADD  CONSTRAINT [FK_DetalleComprobante8] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO
ALTER TABLE [dbo].[DetalleComprobante] CHECK CONSTRAINT [FK_DetalleComprobante8]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota2] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota2]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota4] FOREIGN KEY([idRaza])
REFERENCES [dbo].[Raza] ([idRaza])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota4]
GO
ALTER TABLE [dbo].[Raza]  WITH CHECK ADD  CONSTRAINT [FK_Raza5] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoPerro] ([idTipo])
GO
ALTER TABLE [dbo].[Raza] CHECK CONSTRAINT [FK_Raza5]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva3] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva3]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva7] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva7]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva9] FOREIGN KEY([idTrabajador])
REFERENCES [dbo].[Trabajador] ([idTrabajador])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva9]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_Reserva] FOREIGN KEY([idReserva])
REFERENCES [dbo].[Reserva] ([Reserva_ID])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_Reserva]
GO
ALTER TABLE [dbo].[Trabajador]  WITH CHECK ADD  CONSTRAINT [FK_Trabajador_Especialidad] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
GO
ALTER TABLE [dbo].[Trabajador] CHECK CONSTRAINT [FK_Trabajador_Especialidad]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Especialidad] FOREIGN KEY([idEspecialidad])
REFERENCES [dbo].[Especialidad] ([idEspecialidad])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Especialidad]
GO
