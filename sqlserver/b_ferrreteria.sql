USE [master]
GO
/****** Object:  Database [ferreteria]    Script Date: 23/9/2024 10:15:56 ******/
CREATE DATABASE [ferreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ferreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ferreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ferreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ferreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ferreteria] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ferreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ferreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ferreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ferreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ferreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ferreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [ferreteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ferreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ferreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ferreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ferreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ferreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ferreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ferreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ferreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ferreteria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ferreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ferreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ferreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ferreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ferreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ferreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ferreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ferreteria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ferreteria] SET  MULTI_USER 
GO
ALTER DATABASE [ferreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ferreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ferreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ferreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ferreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ferreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ferreteria] SET QUERY_STORE = ON
GO
ALTER DATABASE [ferreteria] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ferreteria]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 23/9/2024 10:15:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 23/9/2024 10:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[usuario] [nvarchar](50) NOT NULL,
	[contraseña] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[empleados] ON 

INSERT [dbo].[empleados] ([id], [tipo], [nombre], [usuario], [contraseña]) VALUES (2, N'admin', N'kevin', N'elmasguapo', N'1234')
INSERT [dbo].[empleados] ([id], [tipo], [nombre], [usuario], [contraseña]) VALUES (3, N'empleado', N'alexis', N'jefe4', N'3452')
SET IDENTITY_INSERT [dbo].[empleados] OFF
GO
/****** Object:  StoredProcedure [dbo].[baja]    Script Date: 23/9/2024 10:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[baja]
@id int
as
delete from empleados 
where id=@id
GO
/****** Object:  StoredProcedure [dbo].[modificacion_empleados]    Script Date: 23/9/2024 10:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[modificacion_empleados]
@id int,
@tipo nvarchar(50),
@nombre nvarchar(50),
@usuario nvarchar(50),
@contraseña nvarchar(50)
as
update empleados set tipo=@tipo, nombre=@nombre, usuario=@usuario, contraseña=@contraseña 
where id=@id  
GO
/****** Object:  StoredProcedure [dbo].[registro_empleados]    Script Date: 23/9/2024 10:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[registro_empleados]
@id int,
@tipo nvarchar(50),
@nombre nvarchar(50),
@usuario nvarchar(50),
@contraseña nvarchar(50)
as
insert into empleados(id,tipo,nombre,usuario,contraseña)
values(@id, @tipo,@nombre,@usuario,@contraseña)
GO
/****** Object:  StoredProcedure [dbo].[regristro]    Script Date: 23/9/2024 10:15:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[regristro]
@id int,
@tipo nvarchar(50),
@nombre nvarchar(50),
@usuario nvarchar(50),
@contraseña nvarchar(50)
as
insert into empleados(id,tipo,nombre,usuario,contraseña)
values(@id, @tipo,@nombre,@usuario,@contraseña)
GO
USE [master]
GO
ALTER DATABASE [ferreteria] SET  READ_WRITE 
GO
