USE [allqo]
GO
SET IDENTITY_INSERT [dbo].[Lugar] ON 

INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (1, N'LOCAL', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (2, N'SURCO', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (3, N'PUEBLO LIBRE', CAST(7.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (4, N'MIRAFLORES', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (5, N'CHORRILLOS', CAST(4.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Lugar] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (1, N'Victor Raul', N'Haya de la Torre', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (2, N'Ana Victoria', N'Ramos Samaniego', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 3)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (3, N'Andree', N'Galindo', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 4)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (4, N'Sofia', N'Castro Lumbre', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (5, N'Gardenia', N'Salcedo Gallo', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (6, N'Alvaro', N'Villafuerte', N'', 15364532, N'vicrau@gmail.com', 987654321, N'pagado', 5)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (1, N'ADIESTRAMIENTO', N'', CAST(15.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (2, N'PASEO', N'', CAST(20.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Servicio] OFF
SET IDENTITY_INSERT [dbo].[TipoPerro] ON 

INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (1, N'COMÚN', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (2, N'POTENCIALMENTE PELIGROSO', CAST(7.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TipoPerro] OFF
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (1, N'CHIHUAHUA', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (2, N'PUG', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (3, N'BEAGLE', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (4, N'LABRADOR RETRIEVER', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (5, N'CHOW CHOW', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (6, N'BOXER', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (7, N'PIT BULL TERRIER AMERICANO', 2)
SET IDENTITY_INSERT [dbo].[Raza] OFF
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (8, N'PANCHA', N'2 meses', 3, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (9, N'KIRA', N'1 año', 2, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (10, N'BETH', N'3 años', 1, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (11, N'OVEEN', N'1 mes', 6, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (12, N'MANGO', N'4 meses', 5, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (13, N'TACO', N'2 meses', 3, 7)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (1, N'Gerente General')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (2, N'Asistente de Ventas')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (3, N'Cajero')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (4, N'Adiestrador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (5, N'Paseador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (6, N'General')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [direccion], [idEspecialidad]) VALUES (5, N'Juan Manuel', N'Sanchez Melendez', 73432543, 987654321, N'', 1)
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [direccion], [idEspecialidad]) VALUES (6, N'Julia Rosa', N'Luz Casado', 73432543, 987654321, N'', 2)
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [direccion], [idEspecialidad]) VALUES (7, N'Jose Alexander', N'Roque Rodriguez', 73432543, 987654321, N'', 3)
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [direccion], [idEspecialidad]) VALUES (8, N'Gianpierre', N'Leon Grados', 73432543, 987654321, N'', 4)
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([idReserva], [fechaReservada], [fechaSesion], [estado], [idCliente], [idServicio], [idTrabajador], [idSesion]) VALUES (3, CAST(N'2019-04-11T11:03:12.0000000' AS DateTime2), CAST(N'2019-05-11T21:03:12.0000000' AS DateTime2), N'PAGADO', 3, 2, 6, NULL)
INSERT [dbo].[Reserva] ([idReserva], [fechaReservada], [fechaSesion], [estado], [idCliente], [idServicio], [idTrabajador], [idSesion]) VALUES (4, CAST(N'2019-11-19T14:22:00.0000000' AS DateTime2), CAST(N'2019-11-23T14:22:00.0000000' AS DateTime2), N'Emitido', 1, 1, 5, NULL)
SET IDENTITY_INSERT [dbo].[Reserva] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116003702_EF', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116073443_BD_ALLQO', N'2.1.11-servicing-32099')
