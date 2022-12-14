USE [master]
GO

/****** Object:  Database [Z36GaleriDB]    Script Date: 2.12.2022 14:59:55 ******/
CREATE DATABASE [Z36GaleriDB]
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Z36GaleriDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Z36GaleriDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Z36GaleriDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Z36GaleriDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Z36GaleriDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Z36GaleriDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET RECOVERY FULL 
GO

ALTER DATABASE [Z36GaleriDB] SET  MULTI_USER 
GO

ALTER DATABASE [Z36GaleriDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Z36GaleriDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Z36GaleriDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Z36GaleriDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Z36GaleriDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Z36GaleriDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Z36GaleriDB] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Z36GaleriDB] SET  READ_WRITE 
GO


