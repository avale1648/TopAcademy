USE [master]
GO
/****** Object:  Database [Company_DB_PV_113]    Script Date: 18.01.2023 18:23:12 ******/
CREATE DATABASE [Company_DB_PV_113]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Company_DB_PV_113', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Company_DB_PV_113.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Company_DB_PV_113_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Company_DB_PV_113_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Company_DB_PV_113] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Company_DB_PV_113].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Company_DB_PV_113] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET ARITHABORT OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Company_DB_PV_113] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Company_DB_PV_113] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Company_DB_PV_113] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Company_DB_PV_113] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET RECOVERY FULL 
GO
ALTER DATABASE [Company_DB_PV_113] SET  MULTI_USER 
GO
ALTER DATABASE [Company_DB_PV_113] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Company_DB_PV_113] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Company_DB_PV_113] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Company_DB_PV_113] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Company_DB_PV_113] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Company_DB_PV_113] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Company_DB_PV_113', N'ON'
GO
ALTER DATABASE [Company_DB_PV_113] SET QUERY_STORE = OFF
GO
USE [Company_DB_PV_113]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[DateOfBirth] [date] NULL,
	[Picture] [varbinary](max) NULL,
 CONSTRAINT [PK_dbo.Customers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_Customer]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Customer] AS SELECT * FROM Customers


GO
/****** Object:  Table [dbo].[BuyOrder]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyOrder](
	[BuyOrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[OrderNumber] [nvarchar](500) NULL,
	[OrderDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BuyOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuyOrderDetails]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuyOrderDetails](
	[DetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[CatalogID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catalog]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalog](
	[CatalogID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ManufacturerID] [int] NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Price] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[CatalogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](500) NULL,
	[LastName] [nvarchar](500) NULL,
	[BirthDate] [date] NULL,
	[PositionID] [int] NULL,
	[Salary] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryPayout]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryPayout](
	[PayoutID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Salary] [money] NOT NULL,
	[Bonus] [money] NOT NULL,
	[PayoutDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PayoutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryRate]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryRate](
	[RateID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MonthlyRate] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ManagerID] [int] NOT NULL,
	[OrderID] [int] NOT NULL,
	[CatalogID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Discount] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([id], [FirstName], [LastName], [DateOfBirth], [Picture]) VALUES (1, N'Ira', N'Ivanova', CAST(N'1999-05-20' AS Date), NULL)
INSERT [dbo].[Customers] ([id], [FirstName], [LastName], [DateOfBirth], [Picture]) VALUES (2, N'Ivan', N'Smirnov', CAST(N'2000-01-01' AS Date), NULL)
INSERT [dbo].[Customers] ([id], [FirstName], [LastName], [DateOfBirth], [Picture]) VALUES (3, N'Petr', N'Belov', CAST(N'2001-02-02' AS Date), NULL)
INSERT [dbo].[Customers] ([id], [FirstName], [LastName], [DateOfBirth], [Picture]) VALUES (4, N'Sergey', N'Kozlov', CAST(N'2002-03-03' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [BirthDate], [PositionID], [Salary]) VALUES (1, N'Ivan', N'Ivanov', CAST(N'1988-01-05' AS Date), 1, 3000)
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [BirthDate], [PositionID], [Salary]) VALUES (2, N'Petr', N'Petrov', CAST(N'2000-06-06' AS Date), 2, 1200)
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [BirthDate], [PositionID], [Salary]) VALUES (3, N'Olga', N'Fedorova', CAST(N'2000-10-05' AS Date), 3, 1800)
INSERT [dbo].[Employee] ([EmployeeID], [FirstName], [LastName], [BirthDate], [PositionID], [Salary]) VALUES (4, N'Igor', N'Smirnov', CAST(N'1999-03-20' AS Date), 4, 1400)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (1, N'CEO')
INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (3, N'Accountant')
INSERT [dbo].[Position] ([PositionID], [PositionName]) VALUES (4, N'Programmer')
SET IDENTITY_INSERT [dbo].[Position] OFF
GO
/****** Object:  StoredProcedure [dbo].[stp_CustomerAdd]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_CustomerAdd]
	@FirstName nvarchar(max), 
	@LastName nvarchar(max),
	@DateOfBirth date,
	@CustomerID int output
	
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Customers]
           ([FirstName]
           ,[LastName]
           ,[DateOfBirth])
     VALUES
           (@FirstName,
           @LastName, 
           @DateOfBirth)
--Return SCOPE_IDENTITY();
SET @CustomerID=SCOPE_IDENTITY();
END


GO
/****** Object:  StoredProcedure [dbo].[stp_CustomerALL]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[stp_CustomerALL] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * From Customers
END

GO
/****** Object:  StoredProcedure [dbo].[stp_CustomerByID]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[stp_CustomerByID]

	@customerID int

AS
BEGIN

	SET NOCOUNT ON;

	SELECT * FROM [Customers] WHERE id = @customerID

END

GO
/****** Object:  StoredProcedure [dbo].[stp_CustomerDelete]    Script Date: 18.01.2023 18:23:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[stp_CustomerDelete]
	
	@CustomerID int,
	@Result bit OUTPUT
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SET @Result = 0;
	
	IF EXISTS(SELECT * FROM Customers WHERE id = @CustomerID)
	BEGIN

		BEGIN TRY

			BEGIN TRANSACTION

				DELETE FROM Customers WHERE id = @CustomerID
				SET @Result = 1;
				--Throw 5001, 'Test error.', 1;
			COMMIT

		END TRY

		BEGIN CATCH
		SET @Result=0;
			ROLLBACK

		END CATCH

	END

END

GO
USE [master]
GO
ALTER DATABASE [Company_DB_PV_113] SET  READ_WRITE 
GO
