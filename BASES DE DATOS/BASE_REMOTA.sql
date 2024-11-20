USE [master]
GO

/****** Object:  Database [Trabajo_Crud_Remoto]    Script Date: 20-11-24 1:34:38 ******/
CREATE DATABASE [Trabajo_Crud_Remoto]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Trabajo_Crud_Remoto', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Crud_Remoto.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Trabajo_Crud_Remoto_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Trabajo_Crud_Remoto_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Trabajo_Crud_Remoto].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ARITHABORT OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET  MULTI_USER 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Trabajo_Crud_Remoto] SET  READ_WRITE 
GO

