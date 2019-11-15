USE [allqo]
GO
SET IDENTITY_INSERT [dbo].[TipoPerro] ON 

INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (1, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (2, N'POTENCIALMENTE PELIGROSO', 7)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (3, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (4, N'POTENCIALMENTE PELIGROSO', 7)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (5, N'COMÚN', 3)
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (6, N'POTENCIALMENTE PELIGROSO', 7)
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
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (1, N'ADIESTRAMIENTO', N'', 15)
INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (2, N'PASEO', N'', 20)
SET IDENTITY_INSERT [dbo].[Servicio] OFF
SET IDENTITY_INSERT [dbo].[Especialidad] ON 

INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (1, N'Gerente General')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (2, N'Asistente de Ventas')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (3, N'Cajero')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (4, N'Adiestrador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (5, N'Paseador')
INSERT [dbo].[Especialidad] ([idEspecialidad], [nombre]) VALUES (6, N'General')
SET IDENTITY_INSERT [dbo].[Especialidad] OFF
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (1, N'Juan Manuel', N'Sanchez Melendez', N'73432543', 987654321, 1, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (2, N'Julia Rosa', N'Luz Casado', N'73432543', 987654321, 2, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (3, N'Jose Alexander', N'Roque Rodriguez', N'73432543', 987654321, 3, N'')
INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [idEspecialidad], [direccion]) VALUES (4, N'Gianpierre', N'Leon Grados', N'73432543', 987654321, 4, N'')
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
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
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([Reserva_ID], [fechaReservada], [fechaSesion], [estado], [idCliente], [idServicio], [idTrabajador]) VALUES (4, CAST(N'2019-04-11T11:03:12.000' AS DateTime), CAST(N'2019-05-11T21:03:12.000' AS DateTime), N'PAGADO', 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Reserva] OFF
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (1, N'PANCHA', N'2 meses', 3, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (2, N'KIRA', N'1 año', 2, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (3, N'BETH', N'3 años', 1, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (4, N'OVEEN', N'1 mes', 6, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (5, N'MANGO', N'4 meses', 5, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (6, N'TACO', N'2 meses', 3, 7)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e5a741d3-aefb-417d-bbf4-39e9318ed432', N'jscr2@gmail.com', N'JSCR2@GMAIL.COM', N'jscr2@gmail.com', N'JSCR2@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECtMsgIrAN7IjfyBII9j5a+J4s9wfEUEBdUcSQM3xjzDAR1T+MOL040h5NULYaAZPQ==', N'PICPNJMFJ76TAKQDJLLB3MX5S34SQZ7J', N'6dd18124-e6b7-4ed5-8ec3-357d097664f7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.1.11-servicing-32099')
