USE [allqo]
GO
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
SET IDENTITY_INSERT [dbo].[Lugar] ON 

INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (1, N'Local', CAST(0.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (2, N'Surco', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (3, N'Pueblo Libre', CAST(7.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (4, N'Miraflores', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[Lugar] ([idLugar], [nombre], [agregado]) VALUES (5, N'Chorrillos', CAST(4.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Lugar] OFF
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (1, N'Victor Raul', N'Haya de la Torre', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Registrado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (2, N'Ana Victoria', N'Ramos Samaniego', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Registrado', 3)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (3, N'Andree', N'Galindo', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Pre-Registrado', 4)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (4, N'Sofia', N'Castro Lumbre', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Registrado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (5, N'Gardenia', N'Salcedo Gallo', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Pre-Registrado', 2)
INSERT [dbo].[Cliente] ([idCliente], [nombres], [apellidos], [direccion], [dni], [correo], [numCelular], [estado], [idLugar]) VALUES (6, N'Alvaro', N'Villafuerte', N'', 15364532, N'vicrau@gmail.com', 987654321, N'Registrado', 5)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (1, N'Adiestramiento', N'', CAST(15.00 AS Decimal(18, 2)))
INSERT [dbo].[Servicio] ([idServicio], [categoria], [descripcion], [precio]) VALUES (2, N'Paseo', N'', CAST(20.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Servicio] OFF
SET IDENTITY_INSERT [dbo].[TipoPerro] ON 

INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (1, N'Común', CAST(3.00 AS Decimal(18, 2)))
INSERT [dbo].[TipoPerro] ([idTipo], [nombre], [agregado]) VALUES (2, N'Potencialmente Peligroso', CAST(7.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TipoPerro] OFF
SET IDENTITY_INSERT [dbo].[Raza] ON 

INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (1, N'Chihuahua', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (2, N'Pug', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (3, N'Beagle', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (4, N'Labrador Retriever', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (5, N'Chow Chow', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (6, N'Boxer', 1)
INSERT [dbo].[Raza] ([idRaza], [nombre], [idTipo]) VALUES (7, N'Pit Bull Terrier Americano', 2)
SET IDENTITY_INSERT [dbo].[Raza] OFF
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (8, N'Pancha', N'2 meses', 3, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (9, N'Kira', N'1 año', 2, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (10, N'Beth', N'3 años', 1, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (11, N'Oveen', N'1 mes', 6, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (12, N'Mango', N'4 meses', 5, 3)
INSERT [dbo].[Mascota] ([idMascota], [nombre], [edad], [idCliente], [idRaza]) VALUES (13, N'Taco', N'2 meses', 3, 7)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116003702_EF', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116073443_BD_ALLQO', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191127233758_focusSesion', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191128162328_MigracionForzada', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191128170315_Rel_Sesion_Servicio', N'2.1.8-servicing-32085')
