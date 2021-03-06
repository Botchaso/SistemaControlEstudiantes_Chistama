USE [master]
GO
/****** Object:  Database [SisAlumnia]    Script Date: 29/11/2019 12:45:09 p.m. ******/
CREATE DATABASE [SisAlumnia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SisAlumnia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\SisAlumnia.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SisAlumnia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQL_2014\MSSQL\DATA\SisAlumnia_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SisAlumnia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SisAlumnia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SisAlumnia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SisAlumnia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SisAlumnia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SisAlumnia] SET ARITHABORT OFF 
GO
ALTER DATABASE [SisAlumnia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SisAlumnia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SisAlumnia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SisAlumnia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SisAlumnia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SisAlumnia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SisAlumnia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SisAlumnia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SisAlumnia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SisAlumnia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SisAlumnia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SisAlumnia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SisAlumnia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SisAlumnia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SisAlumnia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SisAlumnia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SisAlumnia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SisAlumnia] SET RECOVERY FULL 
GO
ALTER DATABASE [SisAlumnia] SET  MULTI_USER 
GO
ALTER DATABASE [SisAlumnia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SisAlumnia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SisAlumnia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SisAlumnia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SisAlumnia', N'ON'
GO
USE [SisAlumnia]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[IdAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [varchar](8) NOT NULL,
	[Carrera] [varchar](60) NOT NULL,
	[Especialidad] [varchar](70) NOT NULL,
	[DocenteAsignado] [int] NOT NULL,
	[NotasAdicionales] [varchar](250) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[IdAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docente](
	[IdDocente] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [varchar](8) NOT NULL,
	[CarreraProfesion] [varchar](70) NOT NULL,
	[FechaIngreso_a_Laborar] [date] NOT NULL,
 CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED 
(
	[IdDocente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DocentesAlumnos]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocentesAlumnos](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[IdDocente] [int] NOT NULL,
	[IdAlumno] [int] NOT NULL,
 CONSTRAINT [PK_DocentesAlumnos] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Persona]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[Dni] [varchar](8) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](60) NOT NULL,
	[FechaNac] [date] NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[IdDocente] [int] NOT NULL,
	[NomUsuario] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (1, N'78451298', N'Sistemas', N'Ingeniería Informática y de Sistemas', 6, N'Ingresó mediante la pre de la universidad, con notas sobresalientes.', 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (3, N'78522222', N'Sistemas', N'Ingeniería Informática y de Sistemas', 6, N'Lorem ipsum dolor sit amet', 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (5, N'71653014', N'Administración', N'Clima laboral y Desarrollo Personal', 6, N'Estudiante becado por sus habilidades con los números.', 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (6, N'71124578', N'Finanzas', N'Contabilidad', 6, NULL, 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (8, N'71124578', N'Finanzas', N'Contabilidad', 6, N'Lorem ipsum dolor sit amet', 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (11, N'78451298', N'Sistemas', N'Ingeniería Informática y de Sistemas', 6, N'Ingresó mediante la pre de la universidad, con notas sobresalientes - LOREM IPSUUUUM', 1)
INSERT [dbo].[Alumno] ([IdAlumno], [Dni], [Carrera], [Especialidad], [DocenteAsignado], [NotasAdicionales], [Estado]) VALUES (12, N'78954322', N'contabilidad', N'concar', 6, N'', 0)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[Docente] ON 

INSERT [dbo].[Docente] ([IdDocente], [Dni], [CarreraProfesion], [FechaIngreso_a_Laborar]) VALUES (6, N'05247812', N'Ingeniería Informática y de Sistemas', CAST(N'2017-03-15' AS Date))
INSERT [dbo].[Docente] ([IdDocente], [Dni], [CarreraProfesion], [FechaIngreso_a_Laborar]) VALUES (7, N'76451245', N'Forestales', CAST(N'2018-03-15' AS Date))
SET IDENTITY_INSERT [dbo].[Docente] OFF
SET IDENTITY_INSERT [dbo].[DocentesAlumnos] ON 

INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (1, 6, 1)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (2, 6, 3)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (3, 6, 5)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (4, 6, 6)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (7, 6, 8)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (10, 6, 11)
INSERT [dbo].[DocentesAlumnos] ([IdRegistro], [IdDocente], [IdAlumno]) VALUES (11, 6, 12)
SET IDENTITY_INSERT [dbo].[DocentesAlumnos] OFF
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'05247812', N'Gustavo Rodrigo', N'Del Valle Solar', CAST(N'1960-02-19' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'71124578', N'Milton Cristian', N'Leon Cueva', CAST(N'1993-12-10' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'71653014', N'Milton Fernando', N'García Roja', CAST(N'1993-12-12' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'76451245', N'Daniel', N'Chistama', CAST(N'1988-05-17' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'78451298', N'Alejandro', N'Gallegos Viena', CAST(N'1996-02-02' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'78522222', N'María Rosa', N'Viena Valle', CAST(N'1996-02-12' AS Date))
INSERT [dbo].[Persona] ([Dni], [Nombre], [Apellidos], [FechaNac]) VALUES (N'78954322', N'heimmer', N'chavez', CAST(N'1960-02-19' AS Date))
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUser], [IdDocente], [NomUsuario], [Contrasenia]) VALUES (1, 6, N'gusdel60', N'admin123456')
INSERT [dbo].[Usuarios] ([IdUser], [IdDocente], [NomUsuario], [Contrasenia]) VALUES (2, 7, N'danchis88', N'loko')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Persona] FOREIGN KEY([Dni])
REFERENCES [dbo].[Persona] ([Dni])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Persona]
GO
ALTER TABLE [dbo].[Docente]  WITH CHECK ADD  CONSTRAINT [FK_Docente_Persona] FOREIGN KEY([Dni])
REFERENCES [dbo].[Persona] ([Dni])
GO
ALTER TABLE [dbo].[Docente] CHECK CONSTRAINT [FK_Docente_Persona]
GO
ALTER TABLE [dbo].[DocentesAlumnos]  WITH CHECK ADD  CONSTRAINT [FK_DocentesAlumnos_Alumno] FOREIGN KEY([IdAlumno])
REFERENCES [dbo].[Alumno] ([IdAlumno])
GO
ALTER TABLE [dbo].[DocentesAlumnos] CHECK CONSTRAINT [FK_DocentesAlumnos_Alumno]
GO
ALTER TABLE [dbo].[DocentesAlumnos]  WITH CHECK ADD  CONSTRAINT [FK_DocentesAlumnos_Docente] FOREIGN KEY([IdDocente])
REFERENCES [dbo].[Docente] ([IdDocente])
GO
ALTER TABLE [dbo].[DocentesAlumnos] CHECK CONSTRAINT [FK_DocentesAlumnos_Docente]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Docente] FOREIGN KEY([IdDocente])
REFERENCES [dbo].[Docente] ([IdDocente])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Docente]
GO
/****** Object:  StoredProcedure [dbo].[SP_Actualizar_alumno]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Actualizar_alumno] 
	-- Datos de la Persona
	@Dni AS VARCHAR(8),
	@Nombre AS VARCHAR(50),
	@Apellidos AS VARCHAR(60),
	@FechaNac AS DATE,
	-- Datos del Alumno
	@Carrera AS VARCHAR(60),
	@Especialidad AS VARCHAR(70),
	@NotasAdicionales AS VARCHAR(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

	UPDATE Persona SET Nombre = @Nombre, Apellidos = @Apellidos, FechaNac = @FechaNac
	WHERE Persona.Dni = @Dni;
	
	UPDATE Alumno SET Carrera =  @Carrera, Especialidad = @Especialidad, DocenteAsignado = 6, NotasAdicionales = @NotasAdicionales,  Estado = 1
	WHERE Alumno.Dni = @Dni;
	
END


GO
/****** Object:  StoredProcedure [dbo].[SP_CargarNombresAlumno]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_CargarNombresAlumno] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Alumno.IdAlumno, CONCAT(alu.Nombre, ' ', alu.Apellidos) AS Nombre FROM Alumno
	INNER JOIN Persona alu
	ON alu.Dni = Alumno.Dni
	WHERE Alumno.Estado = 1;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Dar_de_bajaAlumno]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Dar_de_bajaAlumno] 
	-- Add the parameters for the stored procedure here
	@idAlumno AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT OFF;

    -- Insert statements for procedure here
	UPDATE Alumno 
	SET Alumno.Estado = 0
	WHERE Alumno.IdAlumno = @idAlumno;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Listar_alumnos]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Listar_alumnos]
	-- Add the parameters for the stored procedure here
	@modoCarga AS INT
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @modoCarga = 1
	BEGIN
		SELECT Alumno.IdAlumno AS ID, Alumno.Dni AS DNI, CONCAT(AlumnoDet.Nombre, ' ', AlumnoDet.Apellidos) AS Nombre, Persona.FechaNac AS [Fecha Nacimiento], Alumno.Carrera, Alumno.Especialidad, 
		CONCAT(Persona.Nombre, ' ', Persona.Apellidos) AS Docente, Alumno.NotasAdicionales AS Comentarios 
		FROM DocentesAlumnos
		INNER JOIN Alumno
		ON DocentesAlumnos.IdAlumno = Alumno.IdAlumno
		INNER JOIN Docente
		ON DocentesAlumnos.IdDocente = Docente.IdDocente
		INNER JOIN Persona
		ON Docente.Dni = Persona.Dni
		INNER JOIN Persona AS AlumnoDet
		ON Alumno.Dni = AlumnoDet.Dni
		WHERE Alumno.Estado = 1;
	END
	ELSE 
	BEGIN
		SELECT Alumno.IdAlumno AS ID, Alumno.Dni AS DNI, AlumnoDet.Nombre, AlumnoDet.Apellidos, CONCAT(AlumnoDet.Nombre, ' ', AlumnoDet.Apellidos) AS [Nombre Completo], Persona.FechaNac AS [Fecha Nacimiento], Alumno.Carrera, Alumno.Especialidad, 
		CONCAT(Persona.Nombre, ' ', Persona.Apellidos) AS Docente, Alumno.NotasAdicionales AS Comentarios 
		FROM DocentesAlumnos
		INNER JOIN Alumno
		ON DocentesAlumnos.IdAlumno = Alumno.IdAlumno
		INNER JOIN Docente
		ON DocentesAlumnos.IdDocente = Docente.IdDocente
		INNER JOIN Persona
		ON Docente.Dni = Persona.Dni
		INNER JOIN Persona AS AlumnoDet
		ON Alumno.Dni = AlumnoDet.Dni
		WHERE Alumno.Estado = 1;
	END
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LoginDocente]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_LoginDocente]
	-- Add the parameters for the stored procedure here
	@NomUsuario AS VARCHAR(20),
	@Contrasenia AS VARCHAR(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 'True' FROM Usuarios WHERE Usuarios.NomUsuario = @NomUsuario AND @Contrasenia = Usuarios.Contrasenia;

END

GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarNuevoAlumno]    Script Date: 29/11/2019 12:45:09 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_RegistrarNuevoAlumno]
	-- Add the parameters for the stored procedure here
	-- Datos de la Persona
	@Dni AS VARCHAR(8),
	@Nombre AS VARCHAR(50),
	@Apellidos AS VARCHAR(60),
	@FechaNac AS DATE,
	-- Datos del Alumno
	@Carrera AS VARCHAR(60),
	@Especialidad AS VARCHAR(70),
	@NotasAdicionales AS VARCHAR(250)

AS
BEGIN
	SET NOCOUNT OFF;

    -- Primero registramos al alumno como una persona nueva
	INSERT INTO Persona VALUES (@Dni, @Nombre, @Apellidos, @FechaNac);
	-- Después lo guardamos como un alumno
	INSERT INTO Alumno VALUES (@Dni, @Carrera, @Especialidad, 6, @NotasAdicionales, 1);
	-- Finalmente, asociamos este alumno con el docente en la tabla intermedia
	INSERT INTO DocentesAlumnos VALUES (6, (SELECT TOP 1 IdAlumno FROM Alumno ORDER BY Alumno.IdAlumno DESC)); 
END

GO
USE [master]
GO
ALTER DATABASE [SisAlumnia] SET  READ_WRITE 
GO
