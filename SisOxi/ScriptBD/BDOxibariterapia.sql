USE [master]
GO
/****** Object:  Database [SisOxibariterapia]    Script Date: 06/13/2013 23:33:01 ******/
CREATE DATABASE [SisOxibariterapia] ON  PRIMARY 
( NAME = N'SisOxibariterapia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SisOxibariterapia.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SisOxibariterapia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SisOxibariterapia_log.LDF' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SisOxibariterapia] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SisOxibariterapia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SisOxibariterapia] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SisOxibariterapia] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SisOxibariterapia] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SisOxibariterapia] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SisOxibariterapia] SET ARITHABORT OFF
GO
ALTER DATABASE [SisOxibariterapia] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SisOxibariterapia] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SisOxibariterapia] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SisOxibariterapia] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SisOxibariterapia] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SisOxibariterapia] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SisOxibariterapia] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SisOxibariterapia] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SisOxibariterapia] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SisOxibariterapia] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SisOxibariterapia] SET  DISABLE_BROKER
GO
ALTER DATABASE [SisOxibariterapia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SisOxibariterapia] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SisOxibariterapia] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SisOxibariterapia] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SisOxibariterapia] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SisOxibariterapia] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SisOxibariterapia] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SisOxibariterapia] SET  READ_WRITE
GO
ALTER DATABASE [SisOxibariterapia] SET RECOVERY FULL
GO
ALTER DATABASE [SisOxibariterapia] SET  MULTI_USER
GO
ALTER DATABASE [SisOxibariterapia] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SisOxibariterapia] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'SisOxibariterapia', N'ON'
GO
USE [SisOxibariterapia]
GO
/****** Object:  Table [dbo].[Enfermedad]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Enfermedad](
	[idEnfermedad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](200) NULL,
	[descripcion] [varchar](200) NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [XPKEnfermedad] PRIMARY KEY CLUSTERED 
(
	[idEnfermedad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Enfermedad] ON
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (1, N'Pulmonia', N'Pulmonia grave', N'Enfermedad Principal')
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (2, N'Pulmonia 1', N'grave', N'Enfermedad Asociada')
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (3, N'Pulmonia 2', N'g', N'Enfermedad Asociada')
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (4, N'Pulmonia 3', N'g', N'Enfermedad Asociada')
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (5, N'a', N'a', N'Enfermedad Asociada')
INSERT [dbo].[Enfermedad] ([idEnfermedad], [nombre], [descripcion], [tipo]) VALUES (6, N'A', N'B', N'Enfermedad Principal')
SET IDENTITY_INSERT [dbo].[Enfermedad] OFF
/****** Object:  Table [dbo].[ImpresionDiagnostica]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImpresionDiagnostica](
	[idImpresionDiagnostica] [int] IDENTITY(1,1) NOT NULL,
	[observaciones] [text] NULL,
	[idHistoriaClinica] [int] NULL,
	[idEnfermedad] [int] NULL,
	[idImpresionDiagnosticaAlterna] [int] NULL,
 CONSTRAINT [XPKImpresionDiagnostica] PRIMARY KEY CLUSTERED 
(
	[idImpresionDiagnostica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ImpresionDiagnostica] ON
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (1, N'A', 1, 1, NULL)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (2, N'A', 1, 1, NULL)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (3, N'A', 1, 2, 1)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (4, N'B', 1, 3, 1)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (5, N'dsadas', 1, 4, 1)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (6, N'wtf', 1, 5, 1)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (7, N'', 1, 3, 2)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (11, N'', 1, 5, 2)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (20, N'C', 1, 6, NULL)
INSERT [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica], [observaciones], [idHistoriaClinica], [idEnfermedad], [idImpresionDiagnosticaAlterna]) VALUES (21, N'rew', 1, 2, 20)
SET IDENTITY_INSERT [dbo].[ImpresionDiagnostica] OFF
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[idHistoriaClinica] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NULL,
	[apellidoPaterno] [varchar](100) NULL,
	[codigoHistoriaClinica] [varchar](20) NULL,
	[apellidoMaterno] [varchar](100) NULL,
	[documentoIdentidad] [varchar](20) NULL,
	[estadoCivil] [varchar](20) NULL,
	[edad] [int] NULL,
	[sexo] [varchar](20) NULL,
	[profesion] [varchar](50) NULL,
	[fechaNacimiento] [datetime] NULL,
	[lugarNacimiento] [varchar](50) NULL,
	[provincia] [varchar](50) NULL,
	[ocupacion] [varchar](50) NULL,
	[centroTrabajo] [varchar](100) NULL,
	[direccionDomiciliaria] [varchar](100) NULL,
	[fono] [varchar](20) NULL,
	[diistritoDomicilio] [varchar](50) NULL,
	[provinciaDomicilio] [varchar](50) NULL,
	[nombreContacto] [varchar](50) NULL,
	[parentescoContacto] [varchar](20) NULL,
	[domicilioContacto] [varchar](100) NULL,
	[fonoContacto] [varchar](50) NULL,
	[grupoEtnico] [varchar](100) NULL,
	[nacionalidad] [varchar](50) NULL,
	[departamentoDomicilio] [varchar](100) NULL,
	[apellidosContacto] [varchar](100) NULL,
 CONSTRAINT [XPKHistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[idHistoriaClinica] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HistoriaClinica] ON
INSERT [dbo].[HistoriaClinica] ([idHistoriaClinica], [nombres], [apellidoPaterno], [codigoHistoriaClinica], [apellidoMaterno], [documentoIdentidad], [estadoCivil], [edad], [sexo], [profesion], [fechaNacimiento], [lugarNacimiento], [provincia], [ocupacion], [centroTrabajo], [direccionDomiciliaria], [fono], [diistritoDomicilio], [provinciaDomicilio], [nombreContacto], [parentescoContacto], [domicilioContacto], [fonoContacto], [grupoEtnico], [nacionalidad], [departamentoDomicilio], [apellidosContacto]) VALUES (1, N'Juan', N'Perez', N'P-00001', N'Gonzales', N'46859654', N'Soltero', 26, N'Masculino', N'', CAST(0x0000A1DB00081653 AS DateTime), N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Blancoide', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[HistoriaClinica] OFF
/****** Object:  Table [dbo].[DatosClinicos]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DatosClinicos](
	[idDatosClinicos] [int] IDENTITY(1,1) NOT NULL,
	[enfermedadActual] [text] NULL,
	[antecedenteFamiliares] [text] NULL,
	[antecedentesPatologicos] [text] NULL,
	[FC] [varchar](50) NULL,
	[T] [varchar](50) NULL,
	[PA] [varchar](50) NULL,
	[peso] [varchar](50) NULL,
	[talla] [varchar](50) NULL,
	[observacionesFisicas] [text] NULL,
	[examenesDeLaboratorio] [text] NULL,
	[idHistoriaClinica] [int] NULL,
 CONSTRAINT [XPKDatosClinicos] PRIMARY KEY CLUSTERED 
(
	[idDatosClinicos] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DatosClinicos] ON
INSERT [dbo].[DatosClinicos] ([idDatosClinicos], [enfermedadActual], [antecedenteFamiliares], [antecedentesPatologicos], [FC], [T], [PA], [peso], [talla], [observacionesFisicas], [examenesDeLaboratorio], [idHistoriaClinica]) VALUES (1, N'', N'', N'', N'', N'', N'', N'', N'', N'', N'', 1)
SET IDENTITY_INSERT [dbo].[DatosClinicos] OFF
/****** Object:  Table [dbo].[Tratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tratamiento](
	[idTratamiento] [int] IDENTITY(1,1) NOT NULL,
	[nroSesiones] [int] NULL,
	[estadoTratamiento] [varchar](20) NULL,
	[observacionesTratamiento] [text] NULL,
	[promedioOxigeno] [decimal](8, 2) NULL,
	[tipoTratamiento] [varchar](100) NULL,
	[fechaInicioTratamiento] [datetime] NULL,
	[idImpresionDiagnostica] [int] NULL,
 CONSTRAINT [XPKTratamiento] PRIMARY KEY CLUSTERED 
(
	[idTratamiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tratamiento] ON
INSERT [dbo].[Tratamiento] ([idTratamiento], [nroSesiones], [estadoTratamiento], [observacionesTratamiento], [promedioOxigeno], [tipoTratamiento], [fechaInicioTratamiento], [idImpresionDiagnostica]) VALUES (1, NULL, N'Incompleto', N'a', NULL, N'Tratamiento Medico', CAST(0x0000A1DC00A41C75 AS DateTime), 1)
INSERT [dbo].[Tratamiento] ([idTratamiento], [nroSesiones], [estadoTratamiento], [observacionesTratamiento], [promedioOxigeno], [tipoTratamiento], [fechaInicioTratamiento], [idImpresionDiagnostica]) VALUES (2, NULL, N'Incompleto', N'A', NULL, N'Tratamiento Analgesico', CAST(0x0000A1DC00A46C41 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Tratamiento] OFF
/****** Object:  Table [dbo].[SesionesTratamiento]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SesionesTratamiento](
	[idSesionTratamiento] [int] IDENTITY(1,1) NOT NULL,
	[fechaSesion] [datetime] NULL,
	[consumoOxigeno] [decimal](8, 2) NULL,
	[notasTender] [text] NULL,
	[idTratamiento] [int] NULL,
	[idEmpleado] [int] NULL,
	[protocolo] [varchar](50) NULL,
 CONSTRAINT [XPKSesionesTratamiento] PRIMARY KEY CLUSTERED 
(
	[idSesionTratamiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NULL,
	[apellidos] [varchar](100) NULL,
	[direccionDomiciliaria] [varchar](200) NULL,
	[fono] [varchar](20) NULL,
	[clave] [varchar](20) NULL,
	[cargo] [varchar](50) NULL,
	[dni] [varchar](11) NULL,
 CONSTRAINT [XPKEmpleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON
INSERT [dbo].[Empleado] ([idEmpleado], [nombres], [apellidos], [direccionDomiciliaria], [fono], [clave], [cargo], [dni]) VALUES (1, N'Charlie', N'Ochoa', N'Urb. Monte Verde A-12', N'465874', N'12345', N'Administrador', N'46275961')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
/****** Object:  Table [dbo].[Auditoria]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Auditoria](
	[idAuditoria] [int] IDENTITY(1,1) NOT NULL,
	[idEmpleado] [int] NULL,
	[idRegistro] [int] NULL,
	[tipo] [varchar](50) NULL,
	[tabla] [varchar](50) NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [XPKAuditoria] PRIMARY KEY CLUSTERED 
(
	[idAuditoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Auditoria] ON
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (2, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB00080802 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (3, 1, 1, N'INSERT', N'HistoriaClinica', CAST(0x0000A1DB0008316B AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (4, 1, 1, N'INSERT', N'DatosClinicos', CAST(0x0000A1DB00083180 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (5, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB0008F02A AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (6, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB000A66EC AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (7, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB00D1F45A AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (8, 1, 0, N'INSERT', N'Enfermedad', CAST(0x0000A1DB00D21D96 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (9, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DB00D22660 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (10, 1, 1, N'UPDATE', N'ImpresionDiagnostica', CAST(0x0000A1DB00D24C02 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (11, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB00D2B647 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (12, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DB00D2CDA9 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (13, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB017474E8 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (14, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB0175265B AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (15, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB017555E4 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (16, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB01762BF1 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (17, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB0176A3B1 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (18, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB017AADDA AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (19, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DB01854EBA AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (20, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00965C9A AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (21, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00975758 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (22, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC0097CF55 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (23, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00982300 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (24, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC0098F7A9 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (25, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC009DF60D AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (26, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC009E22FA AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (27, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC009E5B72 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (28, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC009F440A AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (29, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC009F8CDE AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (30, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC009FBED5 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (31, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC009FEA7C AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (32, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A012D8 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (33, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00A02CCE AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (34, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A30A7D AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (35, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00A31BF8 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (36, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A39A59 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (37, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A40B3D AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (38, 1, 0, N'INSERT', N'Tratamiento', CAST(0x0000A1DC00A425C3 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (39, 1, 0, N'INSERT', N'TipoExamen', CAST(0x0000A1DC00A44F4A AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (40, 1, 0, N'INSERT', N'ExamenGabinete', CAST(0x0000A1DC00A4553E AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (41, 1, 0, N'INSERT', N'ExamenGabinete', CAST(0x0000A1DC00A45F92 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (42, 1, 0, N'INSERT', N'Tratamiento', CAST(0x0000A1DC00A474B9 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (43, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00A484B4 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (44, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A52447 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (45, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A5622E AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (46, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00A57336 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (47, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A617C5 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (48, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00A62C32 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (49, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A7E47F AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (50, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A9A631 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (51, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00A9EDA8 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (52, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC00AD5761 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (53, 1, 0, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC00ADC310 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (54, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC017E21B5 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (55, 1, 0, N'INSERT', N'Enfermedad', CAST(0x0000A1DC017E3C00 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (56, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC017F13F5 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (57, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC01807F90 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (58, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC0180F116 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (59, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC01820FB9 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (60, 1, 16, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC01824702 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (61, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC0182CEA0 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (62, 1, 18, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC0182F9B8 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (63, 1, 19, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC01830136 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (64, 1, 1, N'LOGIN EXITOSO', N'Empleado', CAST(0x0000A1DC018393F6 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (65, 1, 20, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC0183B508 AS DateTime))
INSERT [dbo].[Auditoria] ([idAuditoria], [idEmpleado], [idRegistro], [tipo], [tabla], [fecha]) VALUES (66, 1, 21, N'INSERT', N'ImpresionDiagnostica', CAST(0x0000A1DC0183BBCB AS DateTime))
SET IDENTITY_INSERT [dbo].[Auditoria] OFF
/****** Object:  StoredProcedure [dbo].[spr_SeleccionarSesionesPorTratamiento]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla SesionesTratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_SeleccionarSesionesPorTratamiento]
(
	@idTratamiento int
)
AS
SELECT s.idSesionTratamiento,'nro'=ROW_NUMBER() over (order by s.idSesionTratamiento), s.fechaSesion,s.consumoOxigeno,s.protocolo,
s.idEmpleado,s.idTratamiento,s.notasTender ,'nombrefull'=e.nombres+ ' '+e.apellidos
 FROM SesionesTratamiento s inner join Empleado e on s.idEmpleado = e.idEmpleado
WHERE s.idTratamiento = @idTratamiento
GO
/****** Object:  Table [dbo].[ExamenGabinete]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenGabinete](
	[idExamenGabinete] [int] IDENTITY(1,1) NOT NULL,
	[observaciones] [text] NULL,
	[fecha] [datetime] NULL,
	[idTipoExamen] [int] NULL,
	[idHistoriaClinica] [int] NULL,
 CONSTRAINT [XPKExamenGabinete] PRIMARY KEY CLUSTERED 
(
	[idExamenGabinete] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ExamenGabinete] ON
INSERT [dbo].[ExamenGabinete] ([idExamenGabinete], [observaciones], [fecha], [idTipoExamen], [idHistoriaClinica]) VALUES (1, N'AA', CAST(0x0000A1CE00B1177B AS DateTime), 1, 1)
INSERT [dbo].[ExamenGabinete] ([idExamenGabinete], [observaciones], [fecha], [idTipoExamen], [idHistoriaClinica]) VALUES (2, N'f', CAST(0x0000A1CE00B1177B AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[ExamenGabinete] OFF
/****** Object:  StoredProcedure [dbo].[spr_SeleccionarExamenGabinete]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla ExamenGabinete
--Fecha de Creacion : miércoles, 10 de abril de 2013
create PROCEDURE [dbo].[spr_SeleccionarExamenGabinete]
AS
SELECT * FROM ExamenGabinete
GO
/****** Object:  StoredProcedure [dbo].[spr_SeleccionarDatosClinicos]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla DatosClinicos
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_SeleccionarDatosClinicos]
AS
SELECT * FROM DatosClinicos
GO
/****** Object:  StoredProcedure [dbo].[spr_ReporteEnfermedadesPorSexo]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ReporteEnfermedadesPorSexo]
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,
'Total'=@TotalIH,
'Paciente'=Count(HC.idHistoriaClinica),
'Porcentaje'=CONVERT(varchar,(Count(HC.idHistoriaClinica)* 100 / (Select Count(*) From HistoriaClinica)))+'%',
'Femenino'=SUM(CASE WHEN HC.sexo = 'Femenino' THEN 1 ELSE 0 END),			
'Masculino'=SUM(CASE WHEN HC.sexo = 'Masculino' THEN 1 ELSE 0 END)
			
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre
GO
/****** Object:  StoredProcedure [dbo].[spr_ReporteEnfermedadesPorRangoEdadesII]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ReporteEnfermedadesPorRangoEdadesII]
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,'Total'=@TotalIH,
'0-10'=SUM(CASE WHEN HC.edad between 0 and 10 THEN 1 ELSE 0 END),
'11-20'=SUM(CASE WHEN HC.edad between 11 and 20 THEN 1 ELSE 0 END),
'21-30'=SUM(CASE WHEN HC.edad between 21 and 30 THEN 1 ELSE 0 END),
'31-40'=SUM(CASE WHEN HC.edad between 31 and 40 THEN 1 ELSE 0 END),
'41-50'=SUM(CASE WHEN HC.edad between 41 and 50 THEN 1 ELSE 0 END),
'51-60'=SUM(CASE WHEN HC.edad between 51 and 60 THEN 1 ELSE 0 END),
'61-70'=SUM(CASE WHEN HC.edad between 61 and 70 THEN 1 ELSE 0 END),
'71-80'=SUM(CASE WHEN HC.edad between 71 and 80 THEN 1 ELSE 0 END),
'81+'=SUM(CASE WHEN HC.edad >=81 THEN 1 ELSE 0 END)
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre
GO
/****** Object:  StoredProcedure [dbo].[spr_ReporteEnfermedadesPorRangoEdades]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ReporteEnfermedadesPorRangoEdades]
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,'Total'=@TotalIH,
'Paciente'=Count(HC.idHistoriaClinica),
'Porcentaje'=CONVERT(varchar,(Count(HC.idHistoriaClinica)* 100 / (Select Count(*) From HistoriaClinica)))+'%',
'EdadMin'=MIN(Hc.edad),
'EdadMax'=MAX(hc.edad),
'Promedio'=AVG(HC.edad)
from 
Enfermedad E inner join ImpresionDiagnostica ID
	on E.idEnfermedad = ID.idEnfermedad
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
GROUP BY E.nombre
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarSesionesTratamiento]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla SesionesTratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarSesionesTratamiento]
(
    
            @idSesionTratamiento int,
            @fechaSesion datetime,
            @consumoOxigeno decimal(8,2),
            @notasTender text,
            @idTratamiento int,
            @idEmpleado int,
           	@protocolo varchar(10)
)
AS
UPDATE SesionesTratamiento 
SET

fechaSesion = @fechaSesion,
consumoOxigeno = @consumoOxigeno,
notasTender = @notasTender,
idTratamiento = @idTratamiento,
idEmpleado = @idEmpleado,
protocolo = @protocolo

WHERE idSesionTratamiento = @idSesionTratamiento;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarImpresionDiagnostica]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ModificarImpresionDiagnostica]
(
    
            @idImpresionDiagnostica int,
            @observaciones text,
            @idEnfermedad int,
            @idHistoriaClinica int,
            @idImpresionDIagnosticaAlterna int
)
AS
UPDATE ImpresionDiagnostica 
SET

observaciones = @observaciones,
idEnfermedad = @idEnfermedad,
idHistoriaClinica = @idHistoriaClinica,
idImpresionDiagnosticaAlterna = @idImpresionDIagnosticaAlterna
WHERE idImpresionDiagnostica = @idImpresionDiagnostica ;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarHistoriaClinica]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla HistoriaClinica
--Autor : 
--Fecha de Creacion : lunes, 8 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarHistoriaClinica]
(
    
            @idHistoriaClinica int,
            @nombres varchar(100),
            @apellidoPaterno varchar(100),
            @codigoHistoriaClinica varchar(20),
            @apellidoMaterno varchar(100),
            @documentoIdentidad varchar(20),
            @estadoCivil varchar(20),
            @edad int,
            @sexo varchar(20),
            @profesion varchar(50),
            @fechaNacimiento datetime,
            @lugarNacimiento varchar(50),
            @provincia varchar(50),
            @ocupacion varchar(50),
            @centroTrabajo varchar(100),
            @direccionDomiciliaria varchar(100),
            @fono varchar(20),
            @diistritoDomicilio varchar(50),
            @provinciaDomicilio varchar(50),
            @nombreContacto varchar(50),
            @parentescoContacto varchar(20),
            @domicilioContacto varchar(100),
            @fonoContacto varchar(50),
            @grupoEtnico varchar(100),
            @nacionalidad varchar(50),
            @departamentoDomicilio varchar(100),
            @apellidosContacto varchar(100)
)
AS
UPDATE HistoriaClinica 
SET
nombres = @nombres,
apellidoPaterno = @apellidoPaterno,
codigoHistoriaClinica = @codigoHistoriaClinica,
apellidoMaterno = @apellidoMaterno,
documentoIdentidad = @documentoIdentidad,
estadoCivil = @estadoCivil,
edad = @edad,
sexo = @sexo,
profesion = @profesion,
fechaNacimiento = @fechaNacimiento,
lugarNacimiento = @lugarNacimiento,
provincia = @provincia,
ocupacion = @ocupacion,
centroTrabajo = @centroTrabajo,
direccionDomiciliaria = @direccionDomiciliaria,
fono = @fono,
diistritoDomicilio = @diistritoDomicilio,
provinciaDomicilio = @provinciaDomicilio,
nombreContacto = @nombreContacto,
parentescoContacto = @parentescoContacto,
domicilioContacto = @domicilioContacto,
fonoContacto = @fonoContacto,
grupoEtnico = @grupoEtnico,
nacionalidad = @nacionalidad,
departamentoDomicilio = @departamentoDomicilio,
apellidosContacto = @apellidosContacto

WHERE idHistoriaClinica = @idHistoriaClinica;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarExamenGabinete]    Script Date: 06/13/2013 23:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla ExamenGabinete
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarExamenGabinete]
(
    
            @idExamenGabinete int,
            @observaciones text,
            @idHistoriaClinica int,
            @idTipoExamen int,
            @fecha datetime
)
AS
UPDATE ExamenGabinete 
SET

observaciones = @observaciones,
idHistoriaClinica = @idHistoriaClinica,
idTipoExamen = @idTipoExamen,
fecha = @fecha

WHERE idExamenGabinete = @idExamenGabinete ;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarEnfermedad]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ModificarEnfermedad]
(
    
            @idEnfermedad int,
            @nombre varchar(200),
            @descripcion varchar(200),
            @tipo varchar(100)
)
AS
UPDATE Enfermedad 
SET
nombre = @nombre,
descripcion = @descripcion,
tipo = @tipo
WHERE idEnfermedad = @idEnfermedad;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarEmpleado]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Empleado
--Autor : 
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarEmpleado]
(
    
            @idEmpleado int,
            @nombres varchar(100),
            @apellidos varchar(100),
            @direccionDomiciliaria varchar(200),
            @fono varchar(20),
            @clave varchar(20),
            @cargo varchar(50),
            @dni varchar(11)
)
AS
UPDATE Empleado 
SET
nombres = @nombres,
apellidos = @apellidos,
direccionDomiciliaria = @direccionDomiciliaria,
fono = @fono,
clave = @clave,
cargo = @cargo,
dni = @dni

WHERE idEmpleado = @idEmpleado;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarDatosClinicos]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla DatosClinicos
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarDatosClinicos]
(
    
            @idDatosClinicos int,
            @enfermedadActual text,
            @antecedenteFamiliares text,
            @antecedentesPatologicos text,
            @FC varchar(50),
            @T varchar(50),
            @PA varchar(50),
            @peso varchar(50),
            @talla varchar(50),
            @observacionesFisicas text,
            @examenesDeLaboratorio text,
            @idHistoriaClinica int
)
AS
UPDATE DatosClinicos 
SET
enfermedadActual = @enfermedadActual,
antecedenteFamiliares = @antecedenteFamiliares,
antecedentesPatologicos = @antecedentesPatologicos,
FC = @FC,
T = @T,
PA = @PA,
peso = @peso,
talla = @talla,
observacionesFisicas = @observacionesFisicas,
examenesDeLaboratorio = @examenesDeLaboratorio,
idHistoriaClinica = @idHistoriaClinica

WHERE idDatosClinicos = @idDatosClinicos;
GO
/****** Object:  StoredProcedure [dbo].[spr_LogeoSistema]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE spr_ReporteEnfermedadesTratamientoCamaraHiperbarica
--AS
--declare @TotalIH int;
--SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
--Select E.nombre,
--'Paciente'=Count(HC.idHistoriaClinica),
--'TratamientoCompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Completo' THEN 1 ELSE 0 END),	
--'TratamientoIncompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Incompleto' THEN 1 ELSE 0 END),
--'NroSesionesMin'=Min(T.nroSesiones),
--'NroSesionesMax'=MAX(T.nroSesiones),
--'PromedioNroSesiones'=AVG(T.nroSesiones)
--from 
--Enfermedad E inner join ImpresionDiagnostica ID
--	on E.idEnfermedad = ID.idEnfermedad
--			 inner join HistoriaClinica HC
--	on HC.idHistoriaClinica = ID.idHistoriaClinica
--			 inner join Tratamiento T
--	on T.idHistoriaClinica = HC.idHistoriaClinica
--		Where T.tipoTratamiento = 'Camara Hiperbárica'
--GROUP BY E.nombre
--GO

create Procedure [dbo].[spr_LogeoSistema]
(
@NOMBREUSUARIO	varchar(15),
@CLAVEUSUARIO	varchar(15)
)
as
select * from Empleado where dni=@NOMBREUSUARIO AND clave =@CLAVEUSUARIO
GO
/****** Object:  StoredProcedure [dbo].[spr_EliminarImpresionDiagnosticaAlterna]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_EliminarImpresionDiagnosticaAlterna]
(
	@idImpresionDiagnosticaAlterna int
)
AS
delete from ImpresionDiagnostica where ImpresionDiagnostica.idImpresionDiagnostica = @idImpresionDiagnosticaAlterna;
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarImpresionDiagnosticaPorIDImpresionDiagnosticaAlterna]
(
	@idImpresionDiagnosticaAlterna int
)
AS
SELECT ImpresionDiagnostica.*,Enfermedad.nombre 
FROM ImpresionDiagnostica inner join Enfermedad
on ImpresionDiagnostica.idEnfermedad = Enfermedad.idEnfermedad
WHERE idImpresionDiagnosticaAlterna = @idImpresionDiagnosticaAlterna;
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarImpresionDiagnosticaPorIDHistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarImpresionDiagnosticaPorIDHistoriaClinica]
(
	@idHistoriaClinica int
)
AS
SELECT ImpresionDiagnostica.*,Enfermedad.nombre 
FROM ImpresionDiagnostica inner join Enfermedad
on ImpresionDiagnostica.idEnfermedad = Enfermedad.idEnfermedad
WHERE idHistoriaClinica = @idHistoriaClinica and tipo='Enfermedad Principal';
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarHistoriaClinicaPorID]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarHistoriaClinicaPorID]
(
	@idHistoriaClinica varchar(50)
)
AS
SELECT * from HistoriaClinica WHERE idHistoriaClinica = @idHistoriaClinica
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarHistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla HistoriaClinica
--Fecha de Creacion : lunes, 8 de abril de 2013
CREATE PROCEDURE [dbo].[spr_BuscarHistoriaClinica]
(
	@busqueda varchar(50)
)
AS
SELECT HistoriaClinica.* , DatosClinicos.* 
FROM HistoriaClinica inner join
DatosClinicos on HistoriaClinica.idHistoriaClinica = DatosClinicos.idHistoriaClinica
WHERE HistoriaClinica.nombres like @busqueda + '%' or
	  HistoriaClinica.apellidoPaterno like @busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarExamenPorID]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013

create PROCEDURE [dbo].[spr_BuscarExamenPorID]
(
	@idExamenGabinete int
)
AS
SELECT * FROM ExamenGabinete where idExamenGabinete = @idExamenGabinete
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[spr_BuscarExamen]
AS
SELECT * FROM ExamenGabinete
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEnfermedadPorID]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013
CREATE PROCEDURE [dbo].[spr_BuscarEnfermedadPorID]
(
	@idEnfermedad int
)
AS
SELECT * FROM Enfermedad where idEnfermedad = @idEnfermedad
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEnfermedadAsociada]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarEnfermedadAsociada]
AS
SELECT * FROM Enfermedad where Enfermedad.tipo = 'Enfermedad Asociada'
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEnfermedad]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarEnfermedad]
AS
SELECT * FROM Enfermedad where Enfermedad.tipo = 'Enfermedad Principal'
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEmpleado]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Empleado
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE [dbo].[spr_BuscarEmpleado]
(
	@apellidos varchar(100)
)
AS
SELECT Empleado.*,'nombrefull'=Empleado.nombres+' '+Empleado.apellidos FROM Empleado 
WHERE empleado.apellidos  like @apellidos + '%'



--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarSesionesTratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA SesionesTratamiento--
----------------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla SesionesTratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarSesionesTratamiento]
(
    
            @fechaSesion datetime,
            @consumoOxigeno decimal(8,2),
            @notasTender text,
            @idTratamiento int,
            @idEmpleado int,
            
			@protocolo varchar(10)
)
AS
INSERT INTO SesionesTratamiento 
(fechaSesion,consumoOxigeno,notasTender,idTratamiento,idEmpleado,protocolo)
VALUES
(@fechaSesion,@consumoOxigeno,@notasTender,@idTratamiento,@idEmpleado,@protocolo)
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarImpresionDiagnostica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_AgregarImpresionDiagnostica]
(
    
            @observaciones text,
            @idEnfermedad int,
            @idHistoriaClinica int,
            @idImpresionDIagnosticaAlterna int
)
AS
INSERT INTO ImpresionDiagnostica 
(observaciones,idEnfermedad,idHistoriaClinica,idImpresionDiagnosticaAlterna)
VALUES
(@observaciones,@idEnfermedad,@idHistoriaClinica,@idImpresionDIagnosticaAlterna)
SELECT @@identity
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarHistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Script T-SQL Generado por LayerHelper by Hatred */

------------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA HistoriaClinica--
------------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla HistoriaClinica
--Fecha de Creacion : lunes, 8 de abril de 2013
create PROCEDURE [dbo].[spr_AgregarHistoriaClinica]
(
    
            @nombres varchar(100),
            @apellidoPaterno varchar(100),
            @codigoHistoriaClinica varchar(20),
            @apellidoMaterno varchar(100),
            @documentoIdentidad varchar(20),
            @estadoCivil varchar(20),
            @edad int,
            @sexo varchar(20),
            @profesion varchar(50),
            @fechaNacimiento datetime,
            @lugarNacimiento varchar(50),
            @provincia varchar(50),
            @ocupacion varchar(50),
            @centroTrabajo varchar(100),
            @direccionDomiciliaria varchar(100),
            @fono varchar(20),
            @diistritoDomicilio varchar(50),
            @provinciaDomicilio varchar(50),
            @nombreContacto varchar(50),
            @parentescoContacto varchar(20),
            @domicilioContacto varchar(100),
            @fonoContacto varchar(50),
            @grupoEtnico varchar(100),
            @nacionalidad varchar(50),
            @departamentoDomicilio varchar(100),
            @apellidosContacto varchar(100)
)
AS
INSERT INTO HistoriaClinica 
(nombres,apellidoPaterno,codigoHistoriaClinica,apellidoMaterno,documentoIdentidad,estadoCivil,edad,sexo,profesion,fechaNacimiento,lugarNacimiento,provincia,ocupacion,centroTrabajo,direccionDomiciliaria,fono,diistritoDomicilio,provinciaDomicilio,nombreContacto,parentescoContacto,domicilioContacto,fonoContacto,grupoEtnico,nacionalidad,departamentoDomicilio,apellidosContacto)
VALUES
(@nombres,@apellidoPaterno,@codigoHistoriaClinica,@apellidoMaterno,@documentoIdentidad,@estadoCivil,@edad,@sexo,@profesion,@fechaNacimiento,@lugarNacimiento,@provincia,@ocupacion,@centroTrabajo,@direccionDomiciliaria,@fono,@diistritoDomicilio,@provinciaDomicilio,@nombreContacto,@parentescoContacto,@domicilioContacto,@fonoContacto,@grupoEtnico,@nacionalidad,@departamentoDomicilio,@apellidosContacto)
SELECT @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarExamenGabinete]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA ExamenGabinete--
-----------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla ExamenGabinete
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarExamenGabinete]
(
    
           
            @observaciones text,
            @idHistoriaClinica int,
            @idTipoExamen int,
            @fecha datetime
)
AS
INSERT INTO ExamenGabinete 
(observaciones,idHistoriaClinica,idTipoExamen,fecha)
VALUES
(@observaciones,@idHistoriaClinica,@idTipoExamen,@fecha)
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarEnfermedad]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_AgregarEnfermedad]
(
			
            @nombre varchar(200),
            @descripcion varchar(200),
            @tipo varchar(100)
)
AS
INSERT INTO Enfermedad 
(nombre,descripcion,tipo)
VALUES
(@nombre,@descripcion,@tipo)
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarEmpleado]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Script T-SQL Generado por LayerHelper by Hatred */

-----------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA Empleado--
-----------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Empleado
--Fecha de Creacion : domingo, 14 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarEmpleado]
(
    
            @nombres varchar(100),
            @apellidos varchar(100),
            @direccionDomiciliaria varchar(200),
            @fono varchar(20),
            @clave varchar(20),
            @cargo varchar(50),
            @dni varchar(11)
)
AS
INSERT INTO Empleado 
(nombres,apellidos,direccionDomiciliaria,fono,clave,cargo,dni)
VALUES
(@nombres,@apellidos,@direccionDomiciliaria,@fono,@clave,@cargo,@dni)
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarDatosClinicos]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA DatosClinicos--
----------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla DatosClinicos
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarDatosClinicos]
(
    
            @enfermedadActual text,
            @antecedenteFamiliares text,
            @antecedentesPatologicos text,
            @FC varchar(50),
            @T varchar(50),
            @PA varchar(50),
            @peso varchar(50),
            @talla varchar(50),
            @observacionesFisicas text,
            @examenesDeLaboratorio text,
            @idHistoriaClinica int
)
AS
INSERT INTO DatosClinicos 
(enfermedadActual,antecedenteFamiliares,antecedentesPatologicos,FC,T,PA,peso,talla,observacionesFisicas,examenesDeLaboratorio,idHistoriaClinica)
VALUES
(@enfermedadActual,@antecedenteFamiliares,@antecedentesPatologicos,@FC,@T,@PA,@peso,@talla,@observacionesFisicas,@examenesDeLaboratorio,@idHistoriaClinica)
SELECT @@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarAuditoria]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_AgregarAuditoria]
(
    
            @idEmpleado int,
            @idRegistro int,
            @tipo varchar(50),
            @tabla varchar(50),
            @fecha datetime
)
AS
INSERT INTO Auditoria 
(idEmpleado,idRegistro,tipo,tabla,fecha)
VALUES
(@idEmpleado,@idRegistro,@tipo,@tabla,@fecha)
GO
/****** Object:  Trigger [tU_HistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_HistoriaClinica] ON [dbo].[HistoriaClinica] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on HistoriaClinica */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidHistoriaClinica integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* HistoriaClinica  ExamenGabinete on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0003aa78", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ExamenGabinete
      WHERE
        /*  %JoinFKPK(ExamenGabinete,deleted," = "," AND") */
        ExamenGabinete.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update HistoriaClinica because ExamenGabinete exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* HistoriaClinica  DatosClinicos on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="DatosClinicos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,DatosClinicos
      WHERE
        /*  %JoinFKPK(DatosClinicos,deleted," = "," AND") */
        DatosClinicos.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update HistoriaClinica because DatosClinicos exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* HistoriaClinica  ImpresionDiagnostica on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ImpresionDiagnostica
      WHERE
        /*  %JoinFKPK(ImpresionDiagnostica,deleted," = "," AND") */
        ImpresionDiagnostica.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update HistoriaClinica because ImpresionDiagnostica exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_Enfermedad]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_Enfermedad] ON [dbo].[Enfermedad] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Enfermedad */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidEnfermedad integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Enfermedad  ImpresionDiagnostica on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000129d4", PARENT_OWNER="", PARENT_TABLE="Enfermedad"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="idEnfermedad" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idEnfermedad)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ImpresionDiagnostica
      WHERE
        /*  %JoinFKPK(ImpresionDiagnostica,deleted," = "," AND") */
        ImpresionDiagnostica.idEnfermedad = deleted.idEnfermedad
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Enfermedad because ImpresionDiagnostica exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_Empleado]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_Empleado] ON [dbo].[Empleado] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Empleado */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidEmpleado integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Empleado  Auditoria on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00023dea", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="Auditoria"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="idEmpleado" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idEmpleado)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Auditoria
      WHERE
        /*  %JoinFKPK(Auditoria,deleted," = "," AND") */
        Auditoria.idEmpleado = deleted.idEmpleado
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Empleado because Auditoria exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Empleado  SesionesTratamiento on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="idEmpleado" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idEmpleado)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SesionesTratamiento
      WHERE
        /*  %JoinFKPK(SesionesTratamiento,deleted," = "," AND") */
        SesionesTratamiento.idEmpleado = deleted.idEmpleado
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Empleado because SesionesTratamiento exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_DatosClinicos]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_DatosClinicos] ON [dbo].[DatosClinicos] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on DatosClinicos */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidDatosClinicos integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* HistoriaClinica  DatosClinicos on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00019ff3", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="DatosClinicos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,HistoriaClinica
        WHERE
          /* %JoinFKPK(inserted,HistoriaClinica) */
          inserted.idHistoriaClinica = HistoriaClinica.idHistoriaClinica
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idHistoriaClinica IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update DatosClinicos because HistoriaClinica does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_Auditoria]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_Auditoria] ON [dbo].[Auditoria] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Auditoria */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidAuditoria integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Empleado  Auditoria on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0001780d", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="Auditoria"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="idEmpleado" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idEmpleado)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Empleado
        WHERE
          /* %JoinFKPK(inserted,Empleado) */
          inserted.idEmpleado = Empleado.idEmpleado
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idEmpleado IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Auditoria because Empleado does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_Tratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_Tratamiento] ON [dbo].[Tratamiento] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on Tratamiento */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidTratamiento integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Tratamiento  SesionesTratamiento on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="0002d919", PARENT_OWNER="", PARENT_TABLE="Tratamiento"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="idTratamiento" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idTratamiento)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,SesionesTratamiento
      WHERE
        /*  %JoinFKPK(SesionesTratamiento,deleted," = "," AND") */
        SesionesTratamiento.idTratamiento = deleted.idTratamiento
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update Tratamiento because SesionesTratamiento exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* ImpresionDiagnostica  Tratamiento on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="ImpresionDiagnostica"
    CHILD_OWNER="", CHILD_TABLE="Tratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="idImpresionDiagnostica" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idImpresionDiagnostica)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,ImpresionDiagnostica
        WHERE
          /* %JoinFKPK(inserted,ImpresionDiagnostica) */
          inserted.idImpresionDiagnostica = ImpresionDiagnostica.idImpresionDiagnostica
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idImpresionDiagnostica IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update Tratamiento because ImpresionDiagnostica does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_SesionesTratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_SesionesTratamiento] ON [dbo].[SesionesTratamiento] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on SesionesTratamiento */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidSesionTratamiento integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* Tratamiento  SesionesTratamiento on child update no action */
  /* ERWIN_RELATION:CHECKSUM="0003114a", PARENT_OWNER="", PARENT_TABLE="Tratamiento"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="idTratamiento" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idTratamiento)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Tratamiento
        WHERE
          /* %JoinFKPK(inserted,Tratamiento) */
          inserted.idTratamiento = Tratamiento.idTratamiento
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idTratamiento IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SesionesTratamiento because Tratamiento does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Empleado  SesionesTratamiento on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="idEmpleado" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idEmpleado)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Empleado
        WHERE
          /* %JoinFKPK(inserted,Empleado) */
          inserted.idEmpleado = Empleado.idEmpleado
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idEmpleado IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update SesionesTratamiento because Empleado does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_ImpresionDiagnostica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_ImpresionDiagnostica] ON [dbo].[ImpresionDiagnostica] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on ImpresionDiagnostica */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidImpresionDiagnostica integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* ImpresionDiagnostica  Tratamiento on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000453ec", PARENT_OWNER="", PARENT_TABLE="ImpresionDiagnostica"
    CHILD_OWNER="", CHILD_TABLE="Tratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="idImpresionDiagnostica" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idImpresionDiagnostica)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,Tratamiento
      WHERE
        /*  %JoinFKPK(Tratamiento,deleted," = "," AND") */
        Tratamiento.idImpresionDiagnostica = deleted.idImpresionDiagnostica
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update ImpresionDiagnostica because Tratamiento exists.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* HistoriaClinica  ImpresionDiagnostica on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,HistoriaClinica
        WHERE
          /* %JoinFKPK(inserted,HistoriaClinica) */
          inserted.idHistoriaClinica = HistoriaClinica.idHistoriaClinica
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idHistoriaClinica IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ImpresionDiagnostica because HistoriaClinica does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* Enfermedad  ImpresionDiagnostica on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Enfermedad"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="idEnfermedad" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idEnfermedad)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,Enfermedad
        WHERE
          /* %JoinFKPK(inserted,Enfermedad) */
          inserted.idEnfermedad = Enfermedad.idEnfermedad
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idEnfermedad IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ImpresionDiagnostica because Enfermedad does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  StoredProcedure [dbo].[spr_ReporteEnfermedadesTratamientoCamaraHiperbarica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_ReporteEnfermedadesTratamientoCamaraHiperbarica]
AS
declare @TotalIH int;
SELECT @TotalIH=HistoriaClinica.idHistoriaClinica from HistoriaClinica
Select E.nombre,
'Paciente'=Count(HC.idHistoriaClinica),
'TratamientoCompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Completo' THEN 1 ELSE 0 END),	
'TratamientoIncompleto'=SUM(CASE WHEN T.estadoTratamiento = 'Incompleto' THEN 1 ELSE 0 END),
'NroSesionesMin'=Min(T.nroSesiones),
'NroSesionesMax'=MAX(T.nroSesiones),
'PromedioNroSesiones'=AVG(T.nroSesiones)
from 
ImpresionDiagnostica ID inner join Enfermedad E
	on E.idEnfermedad = ID.idEnfermedad
			 inner join HistoriaClinica HC
	on HC.idHistoriaClinica = ID.idHistoriaClinica
			 inner join Tratamiento T
	on T.idImpresionDiagnostica = ID.idImpresionDiagnostica
		Where T.tipoTratamiento = 'Camara Hiperbárica'
		
GROUP BY E.nombre
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarTratamientoCamaraHiperbarica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Tratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarTratamientoCamaraHiperbarica]
(
    
            @idTratamiento int,
            @nroSesiones int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @promedioOxigeno decimal(8,2),
            @idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
UPDATE Tratamiento 
SET
nroSesiones = @nroSesiones,
estadoTratamiento = @estadoTratamiento,
observacionesTratamiento = @observacionesTratamiento,
promedioOxigeno = @promedioOxigeno,
idImpresionDiagnostica = @idImpresionDiagnostica,
tipoTratamiento = @tipoTratamiento,
fechaInicioTratamiento = @fechaInicioTratamiento

WHERE idTratamiento = @idTratamiento;
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarTratamientoAlterno]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla Tratamiento
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarTratamientoAlterno]
(
    
            @idTratamiento int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
UPDATE Tratamiento 
SET

estadoTratamiento = @estadoTratamiento,
observacionesTratamiento = @observacionesTratamiento,
idImpresionDiagnostica = @idImpresionDiagnostica,
tipoTratamiento = @tipoTratamiento,
fechaInicioTratamiento = @fechaInicioTratamiento

WHERE idTratamiento = @idTratamiento;
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarTratamientoPorIDImpresionDiagnostica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarTratamientoPorIDImpresionDiagnostica]
(
	@idImpresionDiagnostica int
)
AS
SELECT * FROM Tratamiento WHERE idImpresionDiagnostica = @idImpresionDiagnostica
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarTratamientoPorID]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_BuscarTratamientoPorID]
(
	@idTratamiento int
)
AS
SELECT * FROM Tratamiento WHERE idTratamiento = @idTratamiento
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarTratamientoCamaraHiperbarica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA Tratamiento--
--------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarTratamientoCamaraHiperbarica]
(
    
            @nroSesiones int,
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @promedioOxigeno decimal(8,2),
			@idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
INSERT INTO Tratamiento 
(nroSesiones,estadoTratamiento,observacionesTratamiento,promedioOxigeno,idImpresionDiagnostica,tipoTratamiento,fechaInicioTratamiento)
VALUES
(@nroSesiones,@estadoTratamiento,@observacionesTratamiento,@promedioOxigeno,@idImpresionDiagnostica,@tipoTratamiento,@fechaInicioTratamiento)
select @@Identity
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarTratamientoAlterno]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla Tratamiento
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarTratamientoAlterno]
(
    
            @estadoTratamiento varchar(20),
            @observacionesTratamiento text,
            @idImpresionDiagnostica int,
            @tipoTratamiento varchar(100),
            @fechaInicioTratamiento datetime
)
AS
INSERT INTO Tratamiento 
(estadoTratamiento,observacionesTratamiento,idImpresionDiagnostica,tipoTratamiento,fechaInicioTratamiento)
VALUES
(@estadoTratamiento,@observacionesTratamiento,@idImpresionDiagnostica,@tipoTratamiento,@fechaInicioTratamiento)
GO
/****** Object:  Trigger [TR_ObtenerPromedioConsumoOxigenoUpdate]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_ObtenerPromedioConsumoOxigenoUpdate]
on [dbo].[SesionesTratamiento]
for update
as
declare @idTratamiento int;
declare @consumoOxigeno decimal(8,2);
declare @total decimal(8,2);
declare @contador int;
set @total = 0;
set @contador = 0;
begin try
begin transaction PromedioConsumo

select @idTratamiento=inserted.idTratamiento from inserted
		declare SesionesT cursor for
		select s.consumoOxigeno from SesionesTratamiento s where s.idTratamiento = @idTratamiento
		open SesionesT
		fetch SesionesT into @consumoOxigeno
		while(@@FETCH_STATUS=0)
		begin
			set @total = @total + @consumoOxigeno;
			set @contador = @contador +1;
			fetch SesionesT into @consumoOxigeno
		end
		update Tratamiento
		set
			promedioOxigeno = @total/@contador
		where Tratamiento.idTratamiento = @idTratamiento;
commit transaction PromedioConsumo
end try
begin catch
	rollback transaction PromedioConsumo
end catch
GO
/****** Object:  Trigger [TR_ObtenerPromedioConsumoOxigeno]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_ObtenerPromedioConsumoOxigeno]
on [dbo].[SesionesTratamiento]
for insert
as
declare @idTratamiento int;
declare @consumoOxigeno decimal(8,2);
declare @total decimal(8,2);
declare @contador int;
set @total = 0;
set @contador = 0;
begin try
begin transaction PromedioConsumo

select @idTratamiento=inserted.idTratamiento from inserted
		declare SesionesT cursor for
		select s.consumoOxigeno from SesionesTratamiento s where s.idTratamiento = @idTratamiento
		open SesionesT
		fetch SesionesT into @consumoOxigeno
		while(@@FETCH_STATUS=0)
		begin
			set @total = @total + @consumoOxigeno;
			set @contador = @contador +1;
			fetch SesionesT into @consumoOxigeno
		end
		update Tratamiento
		set
			promedioOxigeno = @total/@contador
		where Tratamiento.idTratamiento = @idTratamiento;
commit transaction PromedioConsumo
end try
begin catch
	rollback transaction PromedioConsumo
end catch
GO
/****** Object:  Trigger [tr_InsertarCodigoHistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Trigger para generar automaticamente el codigo al insertar registro
--con el formato <incial apellido><numero> ejemplo : O-0001
--Fecha de Creacion : lunes, 8 de abril de 2013

create trigger [dbo].[tr_InsertarCodigoHistoriaClinica]
on [dbo].[HistoriaClinica]
for insert
as 
declare @codigo int;
declare @cantidad int;
declare @apellido varchar(100);
begin try
begin transaction InsertarPaciente
	select @apellido=SUBSTRING(apellidoPaterno,1,1),@codigo=idHistoriaClinica from inserted;
	select @cantidad=COUNT(*) from HistoriaClinica where apellidoPaterno like @apellido+'%';
	
		
		update HistoriaClinica
		set
			codigoHistoriaClinica = @apellido+'-' + replace(str(@cantidad, 5), ' ', '0')
		where idHistoriaClinica = @codigo;
	
		
commit transaction InsertarPaciente
end try
begin catch
rollback transaction InsertarPaciente
end catch
GO
/****** Object:  Table [dbo].[TipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoExamen](
	[idTipoExamen] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](200) NULL,
	[descripcion] [text] NULL,
 CONSTRAINT [XPKTipoExamen] PRIMARY KEY CLUSTERED 
(
	[idTipoExamen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoExamen] ON
INSERT [dbo].[TipoExamen] ([idTipoExamen], [nombre], [descripcion]) VALUES (1, N'A', N'BB')
SET IDENTITY_INSERT [dbo].[TipoExamen] OFF
/****** Object:  Trigger [tU_TipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_TipoExamen] ON [dbo].[TipoExamen] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on TipoExamen */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidTipoExamen integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* TipoExamen  ExamenGabinete on parent update no action */
  /* ERWIN_RELATION:CHECKSUM="000117b9", PARENT_OWNER="", PARENT_TABLE="TipoExamen"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="idTipoExamen" */
  IF
    /* %ParentPK(" OR",UPDATE) */
    UPDATE(idTipoExamen)
  BEGIN
    IF EXISTS (
      SELECT * FROM deleted,ExamenGabinete
      WHERE
        /*  %JoinFKPK(ExamenGabinete,deleted," = "," AND") */
        ExamenGabinete.idTipoExamen = deleted.idTipoExamen
    )
    BEGIN
      SELECT @errno  = 30005,
             @errmsg = 'Cannot update TipoExamen because ExamenGabinete exists.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tU_ExamenGabinete]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tU_ExamenGabinete] ON [dbo].[ExamenGabinete] FOR UPDATE AS
/* ERwin Builtin Trigger */
/* UPDATE trigger on ExamenGabinete */
BEGIN
  DECLARE  @NUMROWS int,
           @nullcnt int,
           @validcnt int,
           @insidExamenGabinete integer,
           @errno   int,
           @errmsg  varchar(255)

  SELECT @NUMROWS = @@rowcount
  /* ERwin Builtin Trigger */
  /* TipoExamen  ExamenGabinete on child update no action */
  /* ERWIN_RELATION:CHECKSUM="000305a9", PARENT_OWNER="", PARENT_TABLE="TipoExamen"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="idTipoExamen" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idTipoExamen)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,TipoExamen
        WHERE
          /* %JoinFKPK(inserted,TipoExamen) */
          inserted.idTipoExamen = TipoExamen.idTipoExamen
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idTipoExamen IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ExamenGabinete because TipoExamen does not exist.'
      GOTO ERROR
    END
  END

  /* ERwin Builtin Trigger */
  /* HistoriaClinica  ExamenGabinete on child update no action */
  /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="idHistoriaClinica" */
  IF
    /* %ChildFK(" OR",UPDATE) */
    UPDATE(idHistoriaClinica)
  BEGIN
    SELECT @nullcnt = 0
    SELECT @validcnt = count(*)
      FROM inserted,HistoriaClinica
        WHERE
          /* %JoinFKPK(inserted,HistoriaClinica) */
          inserted.idHistoriaClinica = HistoriaClinica.idHistoriaClinica
    /* %NotnullFK(inserted," IS NULL","select @nullcnt = count(*) from inserted where"," AND") */
    select @nullcnt = count(*) from inserted where
      inserted.idHistoriaClinica IS NULL
    IF @validcnt + @nullcnt != @NUMROWS
    BEGIN
      SELECT @errno  = 30007,
             @errmsg = 'Cannot update ExamenGabinete because HistoriaClinica does not exist.'
      GOTO ERROR
    END
  END


  /* ERwin Builtin Trigger */
  RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  StoredProcedure [dbo].[spr_ModificarTipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Actualizar sobre la tabla TipoExamen
--Autor : 
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_ModificarTipoExamen]
(
    
            @idTipoExamen int,
            @nombre varchar(200),
            @descripcion text
)
AS
UPDATE TipoExamen 
SET

nombre = @nombre,
descripcion = @descripcion

WHERE idTipoExamen = @idTipoExamen;
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarTipoExamenPorID]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla Enfermedad
--Fecha de Creacion : sábado, 13 de abril de 2013

CREATE PROCEDURE [dbo].[spr_BuscarTipoExamenPorID]
(
	@idTipoExamen int
)
AS
SELECT * FROM TipoExamen where idTipoExamen = @idTipoExamen
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarTipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Descripcion : Procedimiento Almacenado para Seleccionar Toda la informacion de la tabla TipoExamen
--Fecha de Creacion : miércoles, 10 de abril de 2013



CREATE PROCEDURE [dbo].[spr_BuscarTipoExamen]
AS
SELECT * FROM TipoExamen
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarExamenDeGabinetePorIDHistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarExamenDeGabinetePorIDHistoriaClinica]
(
	@idHistoriaClinica int
)
AS
SELECT ExamenGabinete.*,TipoExamen.nombre 
FROM ExamenGabinete inner join TipoExamen
on ExamenGabinete.idTipoExamen = TipoExamen.idTipoExamen
WHERE idHistoriaClinica = @idHistoriaClinica;

SELECT ExamenGabinete.*,TipoExamen.nombre 
FROM ExamenGabinete inner join TipoExamen
on ExamenGabinete.idTipoExamen = TipoExamen.idTipoExamen
WHERE idHistoriaClinica = 1;
GO
/****** Object:  StoredProcedure [dbo].[spr_AgregarTipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-------------------------------------------------------            
--PROCEDIMIENTOS ALMACENADOS PARA LA TABLA TipoExamen--
-------------------------------------------------------


--Descripcion : Procedimiento Almacenado para Insertar sobre la tabla TipoExamen
--Fecha de Creacion : miércoles, 10 de abril de 2013
CREATE PROCEDURE [dbo].[spr_AgregarTipoExamen]
(
    
           
            @nombre varchar(200),
            @descripcion text
)
AS
INSERT INTO TipoExamen 
(nombre,descripcion)
VALUES
(@nombre,@descripcion)
GO
/****** Object:  Trigger [tD_Tratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_Tratamiento] ON [dbo].[Tratamiento] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Tratamiento */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Tratamiento  SesionesTratamiento on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002975d", PARENT_OWNER="", PARENT_TABLE="Tratamiento"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="idTratamiento" */
    IF EXISTS (
      SELECT * FROM deleted,SesionesTratamiento
      WHERE
        /*  %JoinFKPK(SesionesTratamiento,deleted," = "," AND") */
        SesionesTratamiento.idTratamiento = deleted.idTratamiento
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Tratamiento because SesionesTratamiento exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* ImpresionDiagnostica  Tratamiento on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="ImpresionDiagnostica"
    CHILD_OWNER="", CHILD_TABLE="Tratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="idImpresionDiagnostica" */
    IF EXISTS (SELECT * FROM deleted,ImpresionDiagnostica
      WHERE
        /* %JoinFKPK(deleted,ImpresionDiagnostica," = "," AND") */
        deleted.idImpresionDiagnostica = ImpresionDiagnostica.idImpresionDiagnostica AND
        NOT EXISTS (
          SELECT * FROM Tratamiento
          WHERE
            /* %JoinFKPK(Tratamiento,ImpresionDiagnostica," = "," AND") */
            Tratamiento.idImpresionDiagnostica = ImpresionDiagnostica.idImpresionDiagnostica
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Tratamiento because ImpresionDiagnostica exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_TipoExamen]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_TipoExamen] ON [dbo].[TipoExamen] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on TipoExamen */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* TipoExamen  ExamenGabinete on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0000fe3f", PARENT_OWNER="", PARENT_TABLE="TipoExamen"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="idTipoExamen" */
    IF EXISTS (
      SELECT * FROM deleted,ExamenGabinete
      WHERE
        /*  %JoinFKPK(ExamenGabinete,deleted," = "," AND") */
        ExamenGabinete.idTipoExamen = deleted.idTipoExamen
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete TipoExamen because ExamenGabinete exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_SesionesTratamiento]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_SesionesTratamiento] ON [dbo].[SesionesTratamiento] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on SesionesTratamiento */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Tratamiento  SesionesTratamiento on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00029a21", PARENT_OWNER="", PARENT_TABLE="Tratamiento"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_17", FK_COLUMNS="idTratamiento" */
    IF EXISTS (SELECT * FROM deleted,Tratamiento
      WHERE
        /* %JoinFKPK(deleted,Tratamiento," = "," AND") */
        deleted.idTratamiento = Tratamiento.idTratamiento AND
        NOT EXISTS (
          SELECT * FROM SesionesTratamiento
          WHERE
            /* %JoinFKPK(SesionesTratamiento,Tratamiento," = "," AND") */
            SesionesTratamiento.idTratamiento = Tratamiento.idTratamiento
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SesionesTratamiento because Tratamiento exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Empleado  SesionesTratamiento on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="idEmpleado" */
    IF EXISTS (SELECT * FROM deleted,Empleado
      WHERE
        /* %JoinFKPK(deleted,Empleado," = "," AND") */
        deleted.idEmpleado = Empleado.idEmpleado AND
        NOT EXISTS (
          SELECT * FROM SesionesTratamiento
          WHERE
            /* %JoinFKPK(SesionesTratamiento,Empleado," = "," AND") */
            SesionesTratamiento.idEmpleado = Empleado.idEmpleado
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last SesionesTratamiento because Empleado exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_ImpresionDiagnostica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_ImpresionDiagnostica] ON [dbo].[ImpresionDiagnostica] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on ImpresionDiagnostica */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* ImpresionDiagnostica  Tratamiento on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0003db91", PARENT_OWNER="", PARENT_TABLE="ImpresionDiagnostica"
    CHILD_OWNER="", CHILD_TABLE="Tratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_21", FK_COLUMNS="idImpresionDiagnostica" */
    IF EXISTS (
      SELECT * FROM deleted,Tratamiento
      WHERE
        /*  %JoinFKPK(Tratamiento,deleted," = "," AND") */
        Tratamiento.idImpresionDiagnostica = deleted.idImpresionDiagnostica
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete ImpresionDiagnostica because Tratamiento exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* HistoriaClinica  ImpresionDiagnostica on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="idHistoriaClinica" */
    IF EXISTS (SELECT * FROM deleted,HistoriaClinica
      WHERE
        /* %JoinFKPK(deleted,HistoriaClinica," = "," AND") */
        deleted.idHistoriaClinica = HistoriaClinica.idHistoriaClinica AND
        NOT EXISTS (
          SELECT * FROM ImpresionDiagnostica
          WHERE
            /* %JoinFKPK(ImpresionDiagnostica,HistoriaClinica," = "," AND") */
            ImpresionDiagnostica.idHistoriaClinica = HistoriaClinica.idHistoriaClinica
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ImpresionDiagnostica because HistoriaClinica exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Enfermedad  ImpresionDiagnostica on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Enfermedad"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="idEnfermedad" */
    IF EXISTS (SELECT * FROM deleted,Enfermedad
      WHERE
        /* %JoinFKPK(deleted,Enfermedad," = "," AND") */
        deleted.idEnfermedad = Enfermedad.idEnfermedad AND
        NOT EXISTS (
          SELECT * FROM ImpresionDiagnostica
          WHERE
            /* %JoinFKPK(ImpresionDiagnostica,Enfermedad," = "," AND") */
            ImpresionDiagnostica.idEnfermedad = Enfermedad.idEnfermedad
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ImpresionDiagnostica because Enfermedad exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_HistoriaClinica]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_HistoriaClinica] ON [dbo].[HistoriaClinica] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on HistoriaClinica */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* HistoriaClinica  ExamenGabinete on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00032d7b", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="idHistoriaClinica" */
    IF EXISTS (
      SELECT * FROM deleted,ExamenGabinete
      WHERE
        /*  %JoinFKPK(ExamenGabinete,deleted," = "," AND") */
        ExamenGabinete.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete HistoriaClinica because ExamenGabinete exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* HistoriaClinica  DatosClinicos on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="DatosClinicos"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_14", FK_COLUMNS="idHistoriaClinica" */
    IF EXISTS (
      SELECT * FROM deleted,DatosClinicos
      WHERE
        /*  %JoinFKPK(DatosClinicos,deleted," = "," AND") */
        DatosClinicos.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete HistoriaClinica because DatosClinicos exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* HistoriaClinica  ImpresionDiagnostica on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_19", FK_COLUMNS="idHistoriaClinica" */
    IF EXISTS (
      SELECT * FROM deleted,ImpresionDiagnostica
      WHERE
        /*  %JoinFKPK(ImpresionDiagnostica,deleted," = "," AND") */
        ImpresionDiagnostica.idHistoriaClinica = deleted.idHistoriaClinica
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete HistoriaClinica because ImpresionDiagnostica exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_ExamenGabinete]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_ExamenGabinete] ON [dbo].[ExamenGabinete] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on ExamenGabinete */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* TipoExamen  ExamenGabinete on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="0002b2fd", PARENT_OWNER="", PARENT_TABLE="TipoExamen"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_12", FK_COLUMNS="idTipoExamen" */
    IF EXISTS (SELECT * FROM deleted,TipoExamen
      WHERE
        /* %JoinFKPK(deleted,TipoExamen," = "," AND") */
        deleted.idTipoExamen = TipoExamen.idTipoExamen AND
        NOT EXISTS (
          SELECT * FROM ExamenGabinete
          WHERE
            /* %JoinFKPK(ExamenGabinete,TipoExamen," = "," AND") */
            ExamenGabinete.idTipoExamen = TipoExamen.idTipoExamen
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ExamenGabinete because TipoExamen exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* HistoriaClinica  ExamenGabinete on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="HistoriaClinica"
    CHILD_OWNER="", CHILD_TABLE="ExamenGabinete"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_13", FK_COLUMNS="idHistoriaClinica" */
    IF EXISTS (SELECT * FROM deleted,HistoriaClinica
      WHERE
        /* %JoinFKPK(deleted,HistoriaClinica," = "," AND") */
        deleted.idHistoriaClinica = HistoriaClinica.idHistoriaClinica AND
        NOT EXISTS (
          SELECT * FROM ExamenGabinete
          WHERE
            /* %JoinFKPK(ExamenGabinete,HistoriaClinica," = "," AND") */
            ExamenGabinete.idHistoriaClinica = HistoriaClinica.idHistoriaClinica
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last ExamenGabinete because HistoriaClinica exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_Enfermedad]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_Enfermedad] ON [dbo].[Enfermedad] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Enfermedad */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Enfermedad  ImpresionDiagnostica on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="000115e6", PARENT_OWNER="", PARENT_TABLE="Enfermedad"
    CHILD_OWNER="", CHILD_TABLE="ImpresionDiagnostica"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_20", FK_COLUMNS="idEnfermedad" */
    IF EXISTS (
      SELECT * FROM deleted,ImpresionDiagnostica
      WHERE
        /*  %JoinFKPK(ImpresionDiagnostica,deleted," = "," AND") */
        ImpresionDiagnostica.idEnfermedad = deleted.idEnfermedad
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Enfermedad because ImpresionDiagnostica exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_Empleado]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_Empleado] ON [dbo].[Empleado] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Empleado */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Empleado  Auditoria on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="0001fcd2", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="Auditoria"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="idEmpleado" */
    IF EXISTS (
      SELECT * FROM deleted,Auditoria
      WHERE
        /*  %JoinFKPK(Auditoria,deleted," = "," AND") */
        Auditoria.idEmpleado = deleted.idEmpleado
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Empleado because Auditoria exists.'
      GOTO ERROR
    END

    /* ERwin Builtin Trigger */
    /* Empleado  SesionesTratamiento on parent delete no action */
    /* ERWIN_RELATION:CHECKSUM="00000000", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="SesionesTratamiento"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_18", FK_COLUMNS="idEmpleado" */
    IF EXISTS (
      SELECT * FROM deleted,SesionesTratamiento
      WHERE
        /*  %JoinFKPK(SesionesTratamiento,deleted," = "," AND") */
        SesionesTratamiento.idEmpleado = deleted.idEmpleado
    )
    BEGIN
      SELECT @errno  = 30001,
             @errmsg = 'Cannot delete Empleado because SesionesTratamiento exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  Trigger [tD_Auditoria]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tD_Auditoria] ON [dbo].[Auditoria] FOR DELETE AS
/* ERwin Builtin Trigger */
/* DELETE trigger on Auditoria */
BEGIN
  DECLARE  @errno   int,
           @errmsg  varchar(255)
    /* ERwin Builtin Trigger */
    /* Empleado  Auditoria on child delete no action */
    /* ERWIN_RELATION:CHECKSUM="00013101", PARENT_OWNER="", PARENT_TABLE="Empleado"
    CHILD_OWNER="", CHILD_TABLE="Auditoria"
    P2C_VERB_PHRASE="", C2P_VERB_PHRASE="", 
    FK_CONSTRAINT="R_16", FK_COLUMNS="idEmpleado" */
    IF EXISTS (SELECT * FROM deleted,Empleado
      WHERE
        /* %JoinFKPK(deleted,Empleado," = "," AND") */
        deleted.idEmpleado = Empleado.idEmpleado AND
        NOT EXISTS (
          SELECT * FROM Auditoria
          WHERE
            /* %JoinFKPK(Auditoria,Empleado," = "," AND") */
            Auditoria.idEmpleado = Empleado.idEmpleado
        )
    )
    BEGIN
      SELECT @errno  = 30010,
             @errmsg = 'Cannot delete last Auditoria because Empleado exists.'
      GOTO ERROR
    END


    /* ERwin Builtin Trigger */
    RETURN
ERROR:
    raiserror @errno @errmsg
    rollback transaction
END
GO
/****** Object:  UserDefinedTableType [dbo].[TBEnfermedad]    Script Date: 06/13/2013 23:33:02 ******/
CREATE TYPE [dbo].[TBEnfermedad] AS TABLE(
	[nombre] [varchar](100) NOT NULL
)
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEnfermedadHistoriaAsociada]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarEnfermedadHistoriaAsociada]
(
	@enfermedad as TBEnfermedad readonly
)
AS
SELECT * FROM Enfermedad WHERE Enfermedad.nombre NOT IN (select nombre from @enfermedad) and Enfermedad.tipo = 'Enfermedad Asociada'
GO
/****** Object:  StoredProcedure [dbo].[spr_BuscarEnfermedadHistoria]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spr_BuscarEnfermedadHistoria]
(
	@enfermedad as TBEnfermedad readonly
)
AS
SELECT * FROM Enfermedad WHERE Enfermedad.nombre NOT IN (select nombre from @enfermedad) and Enfermedad.tipo = 'Enfermedad Principal'
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAllData]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteAllData]
AS
    EXEC sp_MSForEachTable 'DELETE FROM ?'
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAllConstraints]    Script Date: 06/13/2013 23:33:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteAllConstraints]
AS
    EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
    EXEC sp_MSForEachTable 'ALTER TABLE ? DISABLE TRIGGER ALL'
GO
/****** Object:  ForeignKey [R_14]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[DatosClinicos]  WITH CHECK ADD  CONSTRAINT [R_14] FOREIGN KEY([idHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idHistoriaClinica])
GO
ALTER TABLE [dbo].[DatosClinicos] CHECK CONSTRAINT [R_14]
GO
/****** Object:  ForeignKey [R_16]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[Auditoria]  WITH CHECK ADD  CONSTRAINT [R_16] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[Auditoria] CHECK CONSTRAINT [R_16]
GO
/****** Object:  ForeignKey [R_17]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[SesionesTratamiento]  WITH CHECK ADD  CONSTRAINT [R_17] FOREIGN KEY([idTratamiento])
REFERENCES [dbo].[Tratamiento] ([idTratamiento])
GO
ALTER TABLE [dbo].[SesionesTratamiento] CHECK CONSTRAINT [R_17]
GO
/****** Object:  ForeignKey [R_18]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[SesionesTratamiento]  WITH CHECK ADD  CONSTRAINT [R_18] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[SesionesTratamiento] CHECK CONSTRAINT [R_18]
GO
/****** Object:  ForeignKey [R_12]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[ExamenGabinete]  WITH CHECK ADD  CONSTRAINT [R_12] FOREIGN KEY([idTipoExamen])
REFERENCES [dbo].[TipoExamen] ([idTipoExamen])
GO
ALTER TABLE [dbo].[ExamenGabinete] CHECK CONSTRAINT [R_12]
GO
/****** Object:  ForeignKey [R_13]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[ExamenGabinete]  WITH CHECK ADD  CONSTRAINT [R_13] FOREIGN KEY([idHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idHistoriaClinica])
GO
ALTER TABLE [dbo].[ExamenGabinete] CHECK CONSTRAINT [R_13]
GO
/****** Object:  ForeignKey [fk_ImpresionDiagnostica_ImpresionDiagnostica]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[ImpresionDiagnostica]  WITH CHECK ADD  CONSTRAINT [fk_ImpresionDiagnostica_ImpresionDiagnostica] FOREIGN KEY([idImpresionDiagnosticaAlterna])
REFERENCES [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica])
GO
ALTER TABLE [dbo].[ImpresionDiagnostica] CHECK CONSTRAINT [fk_ImpresionDiagnostica_ImpresionDiagnostica]
GO
/****** Object:  ForeignKey [R_19]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[ImpresionDiagnostica]  WITH CHECK ADD  CONSTRAINT [R_19] FOREIGN KEY([idHistoriaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idHistoriaClinica])
GO
ALTER TABLE [dbo].[ImpresionDiagnostica] CHECK CONSTRAINT [R_19]
GO
/****** Object:  ForeignKey [R_20]    Script Date: 06/13/2013 23:33:01 ******/
ALTER TABLE [dbo].[ImpresionDiagnostica]  WITH CHECK ADD  CONSTRAINT [R_20] FOREIGN KEY([idEnfermedad])
REFERENCES [dbo].[Enfermedad] ([idEnfermedad])
GO
ALTER TABLE [dbo].[ImpresionDiagnostica] CHECK CONSTRAINT [R_20]
GO
/****** Object:  ForeignKey [R_21]    Script Date: 06/13/2013 23:33:02 ******/
ALTER TABLE [dbo].[Tratamiento]  WITH CHECK ADD  CONSTRAINT [R_21] FOREIGN KEY([idImpresionDiagnostica])
REFERENCES [dbo].[ImpresionDiagnostica] ([idImpresionDiagnostica])
GO
ALTER TABLE [dbo].[Tratamiento] CHECK CONSTRAINT [R_21]
GO
