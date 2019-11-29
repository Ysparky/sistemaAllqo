USE [master]
GO
/****** Object:  Database [allqo]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE DATABASE [allqo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'allqo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\allqo.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'allqo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\allqo_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [allqo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [allqo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [allqo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [allqo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [allqo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [allqo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [allqo] SET ARITHABORT OFF 
GO
ALTER DATABASE [allqo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [allqo] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [allqo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [allqo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [allqo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [allqo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [allqo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [allqo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [allqo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [allqo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [allqo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [allqo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [allqo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [allqo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [allqo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [allqo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [allqo] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [allqo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [allqo] SET RECOVERY FULL 
GO
ALTER DATABASE [allqo] SET  MULTI_USER 
GO
ALTER DATABASE [allqo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [allqo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [allqo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [allqo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'allqo', N'ON'
GO
USE [allqo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29/11/2019 3:16:30 p. m. ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nvarchar](max) NULL,
	[apellidos] [nvarchar](max) NULL,
	[direccion] [nvarchar](max) NULL,
	[dni] [int] NOT NULL,
	[correo] [nvarchar](max) NULL,
	[numCelular] [bigint] NOT NULL,
	[estado] [nvarchar](max) NULL,
	[idLugar] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComprobantePago]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprobantePago](
	[numComprobante] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
	[comentario] [nvarchar](max) NULL,
	[estadoPago] [nvarchar](max) NULL,
	[idCliente] [int] NOT NULL,
 CONSTRAINT [PK_ComprobantePago] PRIMARY KEY CLUSTERED 
(
	[numComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleComprobante]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleComprobante](
	[numDetalle] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioUnit] [real] NOT NULL,
	[subtotal] [real] NOT NULL,
	[total] [real] NOT NULL,
	[importe] [real] NOT NULL,
	[numComprobante] [int] NOT NULL,
	[idServicio] [int] NOT NULL,
 CONSTRAINT [PK_DetalleComprobante] PRIMARY KEY CLUSTERED 
(
	[numDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[idLugar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[agregado] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Lugar] PRIMARY KEY CLUSTERED 
(
	[idLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[idMascota] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[edad] [nvarchar](max) NULL,
	[idCliente] [int] NOT NULL,
	[idRaza] [int] NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[idMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Raza]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Raza](
	[idRaza] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[idTipo] [int] NOT NULL,
 CONSTRAINT [PK_Raza] PRIMARY KEY CLUSTERED 
(
	[idRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] IDENTITY(1,1) NOT NULL,
	[fechaReservada] [datetime2](7) NOT NULL,
	[fechaSesion] [datetime2](7) NOT NULL,
	[estado] [nvarchar](max) NULL,
	[idCliente] [int] NOT NULL,
	[idServicio] [int] NOT NULL,
	[idTrabajador] [int] NOT NULL,
	[idSesion] [int] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [nvarchar](max) NULL,
	[descripcion] [nvarchar](max) NULL,
	[precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[idSesion] [int] IDENTITY(1,1) NOT NULL,
	[numMascotas] [int] NULL,
	[estado] [nvarchar](max) NULL,
	[fechaSesion] [datetime2](7) NOT NULL,
	[lugar] [nvarchar](max) NULL,
	[idTipo] [int] NULL,
	[idServicio] [int] NULL,
 CONSTRAINT [PK_Sesion] PRIMARY KEY CLUSTERED 
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SesionxMascota]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SesionxMascota](
	[idSesionxm] [int] IDENTITY(1,1) NOT NULL,
	[idMascota] [int] NULL,
	[idSesion] [int] NULL,
 CONSTRAINT [PK_SesionxMascota] PRIMARY KEY CLUSTERED 
(
	[idSesionxm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoPerro]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPerro](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[agregado] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TipoPerro] PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 29/11/2019 3:16:30 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[idTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [nvarchar](max) NULL,
	[apellidos] [nvarchar](max) NULL,
	[dni] [int] NOT NULL,
	[numCel] [int] NOT NULL,
	[direccion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Trabajador] PRIMARY KEY CLUSTERED 
(
	[idTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116003702_EF', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191116073443_BD_ALLQO', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191127233758_focusSesion', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191128162328_MigracionForzada', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191128170315_Rel_Sesion_Servicio', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191128192511_relSesionLugar', N'2.1.8-servicing-32085')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191129180736_Integrado', N'2.1.8-servicing-32085')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'Adiestrador', N'ADIESTRADOR', N'8ce44395-1462-4416-91fd-1ed536298c5b')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'Paseador', N'PASEADOR', N'0e4344f7-b0a7-446b-8097-4b200efb32a0')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3', N'General', N'GENERAL', N'a800cad7-3aa2-49cb-a2f1-39715f9dc161')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'4', N'Gerente General', N'GERENTE GENERAL', N'f4c4c5a9-792b-4cc9-8bc5-ca607ed28b49')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5', N'Cajero', N'CAJERO', N'bf25c6f1-238e-4807-b2fd-d5207d374866')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6', N'Asistente de Ventas', N'ASISTENTE DE VENTAS', N'6fa24981-103f-451d-ae30-485dd36fd6de')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'15754926', N'rriendo@gmail.com', N'RRIENDO@GMAIL.COM', N'rriendo@gmail.com', N'RRIENDO@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI7dnif/7r3qEez3HBGjlVZDwiqCC5x2oUvnO8JsrPzRdgu4+SkDICleDMZs2sF7Lg==', N'223X62H4GZWUIVRDORGHFOIUBKRQRXR3', N'5131cc24-54fc-408a-bfcf-df1486ad97b5', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Trabajador] ON 

INSERT [dbo].[Trabajador] ([idTrabajador], [nombres], [apellidos], [dni], [numCel], [direccion]) VALUES (9, N'Rolando', N'Riendo', 15754926, 945362344, N'Comas')
SET IDENTITY_INSERT [dbo].[Trabajador] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cliente_idLugar]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Cliente_idLugar] ON [dbo].[Cliente]
(
	[idLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ComprobantePago_idCliente]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_ComprobantePago_idCliente] ON [dbo].[ComprobantePago]
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetalleComprobante_idServicio]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_DetalleComprobante_idServicio] ON [dbo].[DetalleComprobante]
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetalleComprobante_numComprobante]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_DetalleComprobante_numComprobante] ON [dbo].[DetalleComprobante]
(
	[numComprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Mascota_idCliente]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Mascota_idCliente] ON [dbo].[Mascota]
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Mascota_idRaza]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Mascota_idRaza] ON [dbo].[Mascota]
(
	[idRaza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Raza_idTipo]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Raza_idTipo] ON [dbo].[Raza]
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reserva_idCliente]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_idCliente] ON [dbo].[Reserva]
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reserva_idServicio]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_idServicio] ON [dbo].[Reserva]
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reserva_idSesion]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_idSesion] ON [dbo].[Reserva]
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reserva_idTrabajador]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Reserva_idTrabajador] ON [dbo].[Reserva]
(
	[idTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sesion_idServicio]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Sesion_idServicio] ON [dbo].[Sesion]
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sesion_idTipo]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Sesion_idTipo] ON [dbo].[Sesion]
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SesionxMascota_idMascota]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SesionxMascota_idMascota] ON [dbo].[SesionxMascota]
(
	[idMascota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SesionxMascota_idSesion]    Script Date: 29/11/2019 3:16:30 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_SesionxMascota_idSesion] ON [dbo].[SesionxMascota]
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sesion] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [fechaSesion]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Lugar_idLugar] FOREIGN KEY([idLugar])
REFERENCES [dbo].[Lugar] ([idLugar])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Lugar_idLugar]
GO
ALTER TABLE [dbo].[ComprobantePago]  WITH CHECK ADD  CONSTRAINT [FK_ComprobantePago_Cliente_idCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ComprobantePago] CHECK CONSTRAINT [FK_ComprobantePago_Cliente_idCliente]
GO
ALTER TABLE [dbo].[DetalleComprobante]  WITH CHECK ADD  CONSTRAINT [FK_DetalleComprobante_ComprobantePago_numComprobante] FOREIGN KEY([numComprobante])
REFERENCES [dbo].[ComprobantePago] ([numComprobante])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleComprobante] CHECK CONSTRAINT [FK_DetalleComprobante_ComprobantePago_numComprobante]
GO
ALTER TABLE [dbo].[DetalleComprobante]  WITH CHECK ADD  CONSTRAINT [FK_DetalleComprobante_Servicio_idServicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleComprobante] CHECK CONSTRAINT [FK_DetalleComprobante_Servicio_idServicio]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Cliente_idCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Cliente_idCliente]
GO
ALTER TABLE [dbo].[Mascota]  WITH CHECK ADD  CONSTRAINT [FK_Mascota_Raza_idRaza] FOREIGN KEY([idRaza])
REFERENCES [dbo].[Raza] ([idRaza])
GO
ALTER TABLE [dbo].[Mascota] CHECK CONSTRAINT [FK_Mascota_Raza_idRaza]
GO
ALTER TABLE [dbo].[Raza]  WITH CHECK ADD  CONSTRAINT [FK_Raza_TipoPerro_idTipo] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoPerro] ([idTipo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Raza] CHECK CONSTRAINT [FK_Raza_TipoPerro_idTipo]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente_idCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente_idCliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Servicio_idServicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Servicio_idServicio]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Sesion_idSesion] FOREIGN KEY([idSesion])
REFERENCES [dbo].[Sesion] ([idSesion])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Sesion_idSesion]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Trabajador_idTrabajador] FOREIGN KEY([idTrabajador])
REFERENCES [dbo].[Trabajador] ([idTrabajador])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Trabajador_idTrabajador]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_Servicio_idServicio] FOREIGN KEY([idServicio])
REFERENCES [dbo].[Servicio] ([idServicio])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_Servicio_idServicio]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_TipoPerro_idTipo] FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoPerro] ([idTipo])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_TipoPerro_idTipo]
GO
ALTER TABLE [dbo].[SesionxMascota]  WITH CHECK ADD  CONSTRAINT [FK_SesionxMascota_Mascota_idMascota] FOREIGN KEY([idMascota])
REFERENCES [dbo].[Mascota] ([idMascota])
GO
ALTER TABLE [dbo].[SesionxMascota] CHECK CONSTRAINT [FK_SesionxMascota_Mascota_idMascota]
GO
ALTER TABLE [dbo].[SesionxMascota]  WITH CHECK ADD  CONSTRAINT [FK_SesionxMascota_Sesion_idSesion] FOREIGN KEY([idSesion])
REFERENCES [dbo].[Sesion] ([idSesion])
GO
ALTER TABLE [dbo].[SesionxMascota] CHECK CONSTRAINT [FK_SesionxMascota_Sesion_idSesion]
GO
USE [master]
GO
ALTER DATABASE [allqo] SET  READ_WRITE 
GO
