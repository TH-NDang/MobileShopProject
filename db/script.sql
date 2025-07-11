USE [master]
GO
/****** Object:  Database [MobileShopDB]    Script Date: 7/4/2025 6:28:38 PM ******/
CREATE DATABASE [MobileShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MobileShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MobileShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MobileShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\MobileShopDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [MobileShopDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobileShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobileShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobileShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobileShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobileShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobileShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobileShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MobileShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobileShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobileShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobileShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MobileShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobileShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobileShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobileShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobileShopDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MobileShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobileShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobileShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobileShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MobileShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobileShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MobileShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobileShopDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MobileShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [MobileShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MobileShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MobileShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MobileShopDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MobileShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MobileShopDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MobileShopDB', N'ON'
GO
ALTER DATABASE [MobileShopDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MobileShopDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [MobileShopDB]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompId] [int] NOT NULL,
	[CompName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CompId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustId] [int] NOT NULL,
	[CustName] [nvarchar](100) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[MailId] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mobile]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mobile](
	[IMEINo] [nvarchar](50) NOT NULL,
	[ModelId] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[Warranty] [int] NULL,
	[Price] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[IMEINo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[ModelId] [int] NOT NULL,
	[CompId] [int] NULL,
	[ModelNo] [nvarchar](100) NULL,
	[AvalableQty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SalesId] [int] NOT NULL,
	[IMEINo] [nvarchar](50) NULL,
	[SalesDate] [date] NULL,
	[Price] [decimal](18, 2) NULL,
	[CustId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[TransId] [int] NOT NULL,
	[ModelId] [int] NULL,
	[Quantity] [int] NULL,
	[Date] [date] NULL,
	[Amount] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[TransId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/4/2025 6:28:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [nvarchar](50) NOT NULL,
	[Pwd] [nvarchar](50) NULL,
	[EmployeeName] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[MobileNo] [nvarchar](max) NULL,
	[Hint] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (1, N'Brennan LLC')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (2, N'Bryant, Parker and Jackson')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (3, N'Kim-Jenkins')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (4, N'Henry, Bowers and Smith')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (5, N'Brennan-Barajas')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (6, N'Mccarthy PLC')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (7, N'Taylor Ltd')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (8, N'Snow-Flores')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (9, N'Wright, Lewis and Cameron')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (10, N'Johnson-Jensen')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (11, N'Rodriguez-Smith')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (12, N'Price-Flores')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (13, N'Miles, Mitchell and Haley')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (14, N'Nelson-Vargas')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (15, N'Rhodes, Reynolds and Bush')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (16, N'Hunt PLC')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (17, N'Guerrero-Jackson')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (18, N'Bowers-Mcgee')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (19, N'Graham-Cherry')
INSERT [dbo].[Company] ([CompId], [CompName]) VALUES (20, N'Anthony, Ramirez and Howard')
GO
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (1, N'Brandon Long', N'+1-098-262-2544', N'carl11@johnson-bennett.com', N'34489 Linda Pike
Perkinsville, SD 41558')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (2, N'Dr. Jacqueline Oneal DDS', N'3259243699', N'greenjennifer@yahoo.com', N'06693 Brown Plains Apt. 569
West Moniqueberg, ID 80041')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (3, N'Sara Hess', N'236-035-3202', N'howardbrandon@yahoo.com', N'347 Patterson Cape
South Christina, CA 90304')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (4, N'Mrs. Deborah Cooper', N'(602)751-7629', N'matthew32@casey.biz', N'USS Gilbert
FPO AP 98336')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (5, N'Timothy Sherman', N'+1-979-432-2446', N'elizabethdeleon@brooks.info', N'3702 Snyder Road Apt. 837
New Vanessafurt, MN 00917')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (6, N'Kristina Hess', N'001-776-673-8608x20327', N'fmitchell@yahoo.com', N'75860 Russell Mountains Apt. 807
East Kathleen, SC 67347')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (7, N'Antonio Brooks', N'699.389.9686', N'davilatravis@yahoo.com', N'374 Henry Courts Apt. 641
West Lee, KY 12194')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (8, N'Clayton Roberts', N'558.399.4943x192', N'randyrodriguez@rush.net', N'194 Todd Bypass
Mirandatown, ID 37751')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (9, N'Melinda Fischer', N'824.145.8412', N'brandon63@pollard-arnold.org', N'158 Mcdaniel Mews Apt. 943
South Bruceview, OH 53504')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (10, N'Jennifer Duran', N'+1-767-816-5967', N'lwebb@cabrera.biz', N'6634 Alexander Highway
Lake Beverlyview, NE 36982')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (11, N'Paul Frazier', N'9155655212', N'austinwolf@gmail.com', N'8831 Miranda Rest
Lake Michaelmouth, MN 30140')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (12, N'Scott Everett', N'9399625462', N'ndonovan@gmail.com', N'USNV Simpson
FPO AE 83713')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (13, N'Justin Martin', N'(469)989-1780', N'xolson@yahoo.com', N'PSC 4443, Box 8340
APO AP 13578')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (14, N'Brett Clarke', N'246.473.6472', N'thorntongeorge@krueger.info', N'924 Valerie Mountains Apt. 460
South Stacy, IL 27948')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (15, N'Karen Gardner', N'+1-660-546-8827x12336', N'jennifercarter@kim.com', N'4176 John Neck Suite 218
North Sean, KS 84078')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (16, N'Jonathan Brown', N'246.590.4491x894', N'christian25@yahoo.com', N'129 Baker Lake
Port Beth, WV 36946')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (17, N'Taylor Diaz', N'4617805275', N'wilsonjennifer@murphy-roberts.com', N'085 Marshall Track Apt. 327
North Johnberg, OR 02669')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (18, N'John Diaz', N'083.927.8054x5756', N'dustin96@gmail.com', N'PSC 7223, Box 6225
APO AE 11166')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (19, N'Louis Harris', N'653-699-7027', N'watkinsbrittany@bradshaw-welch.org', N'61893 Michael Valley Suite 647
East Margaret, FL 82728')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (20, N'Kristen Lewis', N'380-463-7171', N'tonya96@gallagher-walker.com', N'5316 Lopez Lakes Apt. 366
West Dianehaven, MD 52414')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (21, N'Tiffany Cannon', N'001-471-324-1025x37178', N'theodore57@dennis-francis.com', N'9940 Joseph Corner
Port Scottmouth, CA 68245')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (22, N'Stephanie Newman', N'580.890.4365x372', N'nelsonmark@saunders-cole.biz', N'0749 Paul Ford
New Melanieton, KY 90454')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (23, N'Michelle Ross', N'001-741-471-6003x603', N'nicholaslloyd@gmail.com', N'Unit 1188 Box 0991
DPO AA 31566')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (24, N'David Mcdonald', N'436.491.3869x62733', N'zprice@weber-white.com', N'33309 Gallagher Harbors
South Carlyshire, WA 94878')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (25, N'Daniel Huffman', N'(270)897-7838', N'srussell@salinas-ward.org', N'849 Robert Mountain Suite 955
Michellechester, MA 36727')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (26, N'Glenn Gallagher', N'(454)914-5268', N'oreed@lam.com', N'641 Paul Trail Suite 365
West Brittanyborough, AR 05183')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (27, N'Laura Estrada', N'(103)252-7720x8509', N'vangtimothy@scott.biz', N'0994 Richard Via
Gregoryport, TX 31089')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (28, N'Yvonne Avila', N'001-871-387-1439x348', N'zyoung@leblanc-smith.com', N'284 Joanna Cliffs
New Jesus, SC 88408')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (29, N'Brad Johnson', N'909-936-3075', N'davischristina@hotmail.com', N'USNS Morris
FPO AE 93615')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (30, N'Shannon Nelson', N'+1-608-737-4122x5178', N'kaitlinwilson@hotmail.com', N'719 Megan Divide Suite 501
Lake Stephanieburgh, VT 85867')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (31, N'Gerald Keller', N'001-921-042-1068x692', N'jondavis@fletcher.com', N'7895 Garcia Meadows Apt. 289
Lake Kyleton, ID 18891')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (32, N'Jeremy May', N'0343809206', N'krystal80@gmail.com', N'2768 Murray Parkways Apt. 088
Barnesmouth, SC 58476')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (33, N'Daniel Short', N'(524)244-2212', N'jamesfoster@yahoo.com', N'2017 John Common
North Amyton, AR 47934')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (34, N'Laura Griffin', N'001-656-701-4880x73905', N'hannahaguilar@gmail.com', N'57833 Ryan Causeway Apt. 217
Brandonshire, NE 21885')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (35, N'Cindy Castaneda', N'(671)384-3811x4768', N'taylorkimberly@hotmail.com', N'19444 Robert Viaduct
West Tina, MI 50112')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (36, N'Gene Thomas', N'447.664.9685x714', N'kpatterson@anderson.com', N'256 Dunn Cliff
West Stephanie, GA 86927')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (37, N'Jessica Castro', N'542.858.0062', N'charles63@mitchell.com', N'388 Klein Causeway
Mackfort, OK 73328')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (38, N'Angelica Schroeder', N'(449)748-2165', N'powellkelly@brooks.com', N'79214 James Estate Apt. 637
New Bradley, PA 81946')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (39, N'Russell Gillespie', N'(317)699-5953', N'chelsea86@cook.com', N'7352 Jonathan Junction Suite 045
West Brianna, NV 69238')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (40, N'David Mcgrath', N'363.256.6656x705', N'brandon22@gmail.com', N'8374 Gregory Oval Apt. 898
East Alexander, MD 22874')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (41, N'Katherine Taylor', N'+1-797-501-3454x84598', N'jkirk@bruce.info', N'2806 Smith Vista Suite 281
Kimchester, OR 06875')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (42, N'Diana Montoya', N'(646)534-1061x84619', N'stevenferrell@yahoo.com', N'4377 Rhonda Bridge
Christinestad, WV 56609')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (43, N'Alexandra Brown MD', N'361-194-4301x6914', N'william27@little.com', N'09668 Delacruz Trafficway
Debraview, ID 97834')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (44, N'Erin Richardson', N'0907841060', N'acastaneda@yahoo.com', N'3182 John Isle
New Leah, AK 16197')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (45, N'Lori Brown', N'025.588.3052x3163', N'allenian@cook-reynolds.info', N'548 Julie Flats Apt. 930
Caitlynfort, VA 09768')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (46, N'Tracy Jones', N'+1-969-869-8381x9016', N'rebeccarichardson@dixon.com', N'077 Heather Harbors Suite 800
Johnsontown, AK 86432')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (47, N'John Wiggins', N'+1-201-189-7512x02595', N'lisahunter@king.com', N'654 Rhonda Groves Apt. 905
Brittanyfurt, AK 03111')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (48, N'Keith Olsen', N'001-803-705-7378x252', N'nguyenheather@gmail.com', N'13203 Scott Oval
New Danielburgh, WA 76187')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (49, N'Ashley Mccarty', N'362-858-7146', N'hughessally@french.com', N'1420 Shannon Meadows
East Kellyberg, WV 93984')
INSERT [dbo].[Customer] ([CustId], [CustName], [MobileNo], [MailId], [Address]) VALUES (50, N'Donald Owens', N'001-461-906-9967x920', N'chaveztasha@navarro.com', N'134 Martin Ports
Port Timothymouth, OK 20130')
GO
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1019609', 29, N'Available', 13, CAST(837.63 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1091754', 36, N'Available', 9, CAST(635.05 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1134453', 19, N'Available', 6, CAST(978.28 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1201455', 50, N'Sold', 10, CAST(858.11 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1231210', 9, N'Available', 8, CAST(378.13 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1231806', 29, N'Sold', 24, CAST(830.82 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1239118', 17, N'Sold', 11, CAST(469.96 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1514437', 43, N'Available', 9, CAST(361.75 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1519792', 32, N'Sold', 8, CAST(975.43 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1727985', 46, N'Sold', 12, CAST(408.99 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1758922', 4, N'Available', 16, CAST(345.82 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1888583', 26, N'Available', 15, CAST(740.15 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI1896694', 43, N'Sold', 22, CAST(415.10 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI2061729', 13, N'Sold', 16, CAST(289.39 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI2161037', 31, N'Available', 13, CAST(246.41 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI2495819', 37, N'Available', 12, CAST(956.86 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI2561466', 16, N'Available', 10, CAST(941.19 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI2757869', 18, N'Sold', 19, CAST(344.72 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3065664', 26, N'Available', 13, CAST(795.22 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3186958', 17, N'Sold', 7, CAST(746.92 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3304319', 49, N'Sold', 21, CAST(313.33 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3400905', 21, N'Available', 7, CAST(599.55 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3437089', 21, N'Sold', 20, CAST(204.43 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3698217', 12, N'Sold', 21, CAST(482.58 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3790424', 9, N'Sold', 17, CAST(625.25 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3832578', 45, N'Sold', 13, CAST(296.88 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI3901417', 27, N'Sold', 11, CAST(971.60 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4143669', 23, N'Available', 19, CAST(477.95 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4220416', 47, N'Sold', 14, CAST(834.64 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4232451', 12, N'Sold', 6, CAST(808.04 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4264815', 9, N'Sold', 16, CAST(336.60 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4427272', 41, N'Sold', 16, CAST(920.00 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4576509', 26, N'Sold', 13, CAST(930.33 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4633510', 11, N'Sold', 10, CAST(969.01 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4672357', 28, N'Available', 13, CAST(288.06 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4684611', 24, N'Available', 24, CAST(267.16 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4816241', 21, N'Available', 12, CAST(594.10 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4840050', 37, N'Sold', 17, CAST(818.71 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4874393', 28, N'Available', 6, CAST(825.69 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4910789', 25, N'Sold', 15, CAST(443.32 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI4937854', 19, N'Sold', 15, CAST(950.19 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5082233', 34, N'Available', 23, CAST(387.09 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5102946', 26, N'Sold', 17, CAST(841.30 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5146643', 8, N'Sold', 12, CAST(324.72 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5350110', 49, N'Sold', 22, CAST(513.68 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5373765', 16, N'Available', 17, CAST(828.35 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5697154', 48, N'Available', 8, CAST(586.07 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5823057', 45, N'Available', 11, CAST(384.12 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5854454', 26, N'Available', 20, CAST(747.16 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5911134', 49, N'Available', 13, CAST(465.66 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI5993379', 40, N'Available', 7, CAST(883.98 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6235577', 5, N'Sold', 16, CAST(720.21 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6249429', 16, N'Available', 17, CAST(343.41 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6297036', 23, N'Available', 10, CAST(505.22 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6305281', 13, N'Available', 19, CAST(792.03 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6314045', 35, N'Available', 20, CAST(989.92 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6371069', 31, N'Sold', 12, CAST(973.47 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6454031', 3, N'Sold', 6, CAST(606.47 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6479892', 40, N'Sold', 13, CAST(719.46 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6638091', 38, N'Available', 11, CAST(547.71 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6664424', 32, N'Available', 11, CAST(270.68 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6669093', 44, N'Available', 14, CAST(694.32 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6718096', 23, N'Available', 16, CAST(423.54 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6725891', 20, N'Sold', 10, CAST(751.14 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6810736', 46, N'Sold', 9, CAST(494.37 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI6915105', 4, N'Available', 16, CAST(448.25 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7056129', 14, N'Available', 13, CAST(677.44 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7059546', 11, N'Available', 24, CAST(729.32 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7234963', 50, N'Sold', 20, CAST(333.38 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7307632', 8, N'Available', 9, CAST(561.84 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7321838', 40, N'Available', 22, CAST(907.51 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7383359', 7, N'Sold', 20, CAST(624.66 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7419374', 1, N'Sold', 10, CAST(758.15 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7474983', 20, N'Sold', 8, CAST(693.38 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7598495', 18, N'Sold', 20, CAST(826.18 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7727087', 12, N'Sold', 6, CAST(517.39 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7902264', 46, N'Available', 19, CAST(697.64 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI7970669', 13, N'Sold', 13, CAST(499.92 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8030464', 37, N'Sold', 21, CAST(513.26 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8067049', 31, N'Sold', 11, CAST(552.71 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8221072', 9, N'Available', 10, CAST(979.45 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8497261', 24, N'Sold', 23, CAST(375.06 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8648581', 44, N'Sold', 12, CAST(314.21 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8663175', 47, N'Sold', 9, CAST(994.49 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8905640', 17, N'Available', 10, CAST(399.64 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8951580', 2, N'Available', 9, CAST(219.32 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI8965960', 47, N'Available', 18, CAST(719.97 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9074327', 38, N'Available', 19, CAST(508.29 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9110795', 8, N'Available', 10, CAST(783.46 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9147852', 24, N'Sold', 10, CAST(692.77 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9420861', 8, N'Sold', 24, CAST(788.85 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9494510', 45, N'Sold', 15, CAST(479.50 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9554718', 21, N'Available', 9, CAST(206.87 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9603558', 34, N'Sold', 14, CAST(679.99 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9783726', 11, N'Sold', 11, CAST(353.23 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9800439', 10, N'Available', 15, CAST(217.61 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9837346', 18, N'Sold', 13, CAST(922.51 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9881332', 9, N'Sold', 12, CAST(211.52 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9967732', 8, N'Available', 14, CAST(756.59 AS Decimal(18, 2)))
INSERT [dbo].[Mobile] ([IMEINo], [ModelId], [Status], [Warranty], [Price]) VALUES (N'IMEI9989822', 48, N'Sold', 17, CAST(723.53 AS Decimal(18, 2)))
GO
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (1, 13, N'MDL-9084', 10)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (2, 13, N'MDL-7900', 77)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (3, 12, N'MDL-9683', 60)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (4, 13, N'MDL-8252', 42)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (5, 2, N'MDL-2993', 47)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (6, 16, N'MDL-9519', 82)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (7, 3, N'MDL-5079', 33)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (8, 1, N'MDL-4594', 86)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (9, 14, N'MDL-5255', 42)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (10, 15, N'MDL-8455', 60)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (11, 14, N'MDL-8527', 70)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (12, 13, N'MDL-7387', 53)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (13, 7, N'MDL-6725', 49)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (14, 5, N'MDL-4217', 18)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (15, 2, N'MDL-9589', 38)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (16, 17, N'MDL-5206', 37)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (17, 17, N'MDL-4065', 58)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (18, 3, N'MDL-9757', 97)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (19, 13, N'MDL-7349', 66)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (20, 12, N'MDL-4109', 28)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (21, 14, N'MDL-1039', 56)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (22, 4, N'MDL-7051', 16)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (23, 17, N'MDL-1444', 35)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (24, 5, N'MDL-7045', 38)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (25, 8, N'MDL-7162', 50)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (26, 6, N'MDL-2158', 90)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (27, 6, N'MDL-5472', 95)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (28, 14, N'MDL-2223', 15)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (29, 8, N'MDL-1976', 16)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (30, 11, N'MDL-3793', 15)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (31, 1, N'MDL-3959', 90)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (32, 17, N'MDL-3120', 97)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (33, 7, N'MDL-4206', 73)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (34, 3, N'MDL-7247', 100)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (35, 20, N'MDL-2094', 51)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (36, 5, N'MDL-4188', 50)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (37, 10, N'MDL-9909', 76)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (38, 7, N'MDL-1885', 92)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (39, 3, N'MDL-1598', 21)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (40, 1, N'MDL-7879', 57)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (41, 2, N'MDL-5630', 22)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (42, 9, N'MDL-1052', 67)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (43, 4, N'MDL-5199', 57)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (44, 10, N'MDL-5240', 79)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (45, 14, N'MDL-7869', 10)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (46, 5, N'MDL-1511', 71)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (47, 9, N'MDL-6570', 63)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (48, 2, N'MDL-6504', 28)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (49, 3, N'MDL-5782', 43)
INSERT [dbo].[Model] ([ModelId], [CompId], [ModelNo], [AvalableQty]) VALUES (50, 9, N'MDL-9538', 10)
GO
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (1, N'IMEI8951580', CAST(N'2025-01-28' AS Date), CAST(853.98 AS Decimal(18, 2)), 32)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (2, N'IMEI2561466', CAST(N'2024-07-29' AS Date), CAST(978.14 AS Decimal(18, 2)), 30)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (3, N'IMEI1019609', CAST(N'2025-03-12' AS Date), CAST(873.03 AS Decimal(18, 2)), 27)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (4, N'IMEI4264815', CAST(N'2025-06-13' AS Date), CAST(923.25 AS Decimal(18, 2)), 40)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (5, N'IMEI7307632', CAST(N'2024-12-09' AS Date), CAST(714.57 AS Decimal(18, 2)), 1)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (6, N'IMEI6305281', CAST(N'2024-12-08' AS Date), CAST(374.04 AS Decimal(18, 2)), 28)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (7, N'IMEI2495819', CAST(N'2025-05-10' AS Date), CAST(364.28 AS Decimal(18, 2)), 47)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (8, N'IMEI6718096', CAST(N'2025-05-17' AS Date), CAST(694.78 AS Decimal(18, 2)), 50)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (9, N'IMEI9420861', CAST(N'2025-02-01' AS Date), CAST(379.03 AS Decimal(18, 2)), 24)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (10, N'IMEI1231210', CAST(N'2024-10-30' AS Date), CAST(904.09 AS Decimal(18, 2)), 44)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (11, N'IMEI3437089', CAST(N'2024-08-03' AS Date), CAST(884.45 AS Decimal(18, 2)), 29)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (12, N'IMEI6297036', CAST(N'2024-10-28' AS Date), CAST(965.99 AS Decimal(18, 2)), 47)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (13, N'IMEI7727087', CAST(N'2025-04-13' AS Date), CAST(656.95 AS Decimal(18, 2)), 11)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (14, N'IMEI7056129', CAST(N'2024-11-23' AS Date), CAST(398.14 AS Decimal(18, 2)), 23)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (15, N'IMEI2061729', CAST(N'2025-05-29' AS Date), CAST(375.67 AS Decimal(18, 2)), 43)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (16, N'IMEI7307632', CAST(N'2025-04-29' AS Date), CAST(692.51 AS Decimal(18, 2)), 38)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (17, N'IMEI9494510', CAST(N'2024-08-19' AS Date), CAST(875.47 AS Decimal(18, 2)), 31)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (18, N'IMEI1239118', CAST(N'2025-04-01' AS Date), CAST(936.41 AS Decimal(18, 2)), 4)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (19, N'IMEI6638091', CAST(N'2025-04-24' AS Date), CAST(529.63 AS Decimal(18, 2)), 31)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (20, N'IMEI3698217', CAST(N'2024-12-13' AS Date), CAST(861.47 AS Decimal(18, 2)), 49)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (21, N'IMEI6638091', CAST(N'2025-03-30' AS Date), CAST(433.44 AS Decimal(18, 2)), 7)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (22, N'IMEI1231210', CAST(N'2025-02-08' AS Date), CAST(623.96 AS Decimal(18, 2)), 37)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (23, N'IMEI3304319', CAST(N'2024-11-26' AS Date), CAST(922.76 AS Decimal(18, 2)), 3)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (24, N'IMEI6235577', CAST(N'2024-11-17' AS Date), CAST(888.52 AS Decimal(18, 2)), 3)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (25, N'IMEI1239118', CAST(N'2024-10-15' AS Date), CAST(448.21 AS Decimal(18, 2)), 41)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (26, N'IMEI4672357', CAST(N'2025-06-12' AS Date), CAST(585.03 AS Decimal(18, 2)), 25)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (27, N'IMEI9554718', CAST(N'2025-05-06' AS Date), CAST(685.45 AS Decimal(18, 2)), 22)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (28, N'IMEI9783726', CAST(N'2025-05-11' AS Date), CAST(862.18 AS Decimal(18, 2)), 35)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (29, N'IMEI9420861', CAST(N'2025-02-15' AS Date), CAST(684.92 AS Decimal(18, 2)), 28)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (30, N'IMEI6371069', CAST(N'2025-04-15' AS Date), CAST(675.04 AS Decimal(18, 2)), 2)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (31, N'IMEI1091754', CAST(N'2025-07-03' AS Date), CAST(870.34 AS Decimal(18, 2)), 28)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (32, N'IMEI4816241', CAST(N'2025-04-27' AS Date), CAST(685.17 AS Decimal(18, 2)), 22)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (33, N'IMEI4427272', CAST(N'2024-10-20' AS Date), CAST(704.48 AS Decimal(18, 2)), 6)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (34, N'IMEI6454031', CAST(N'2025-03-05' AS Date), CAST(941.33 AS Decimal(18, 2)), 32)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (35, N'IMEI1896694', CAST(N'2024-08-30' AS Date), CAST(614.07 AS Decimal(18, 2)), 46)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (36, N'IMEI5146643', CAST(N'2024-09-08' AS Date), CAST(670.26 AS Decimal(18, 2)), 30)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (37, N'IMEI4672357', CAST(N'2024-08-11' AS Date), CAST(888.08 AS Decimal(18, 2)), 10)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (38, N'IMEI6718096', CAST(N'2024-07-06' AS Date), CAST(921.90 AS Decimal(18, 2)), 27)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (39, N'IMEI6235577', CAST(N'2024-12-15' AS Date), CAST(562.47 AS Decimal(18, 2)), 15)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (40, N'IMEI5823057', CAST(N'2024-08-21' AS Date), CAST(412.30 AS Decimal(18, 2)), 17)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (41, N'IMEI9881332', CAST(N'2025-01-16' AS Date), CAST(418.86 AS Decimal(18, 2)), 21)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (42, N'IMEI9837346', CAST(N'2024-08-20' AS Date), CAST(846.79 AS Decimal(18, 2)), 8)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (43, N'IMEI7727087', CAST(N'2025-05-01' AS Date), CAST(950.78 AS Decimal(18, 2)), 49)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (44, N'IMEI5697154', CAST(N'2024-08-03' AS Date), CAST(484.44 AS Decimal(18, 2)), 6)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (45, N'IMEI1201455', CAST(N'2024-07-08' AS Date), CAST(789.99 AS Decimal(18, 2)), 32)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (46, N'IMEI7902264', CAST(N'2024-12-30' AS Date), CAST(751.27 AS Decimal(18, 2)), 46)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (47, N'IMEI7059546', CAST(N'2024-08-11' AS Date), CAST(373.72 AS Decimal(18, 2)), 32)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (48, N'IMEI4633510', CAST(N'2025-04-28' AS Date), CAST(504.40 AS Decimal(18, 2)), 20)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (49, N'IMEI9420861', CAST(N'2025-06-12' AS Date), CAST(995.37 AS Decimal(18, 2)), 8)
INSERT [dbo].[Sales] ([SalesId], [IMEINo], [SalesDate], [Price], [CustId]) VALUES (50, N'IMEI5146643', CAST(N'2025-04-14' AS Date), CAST(333.10 AS Decimal(18, 2)), 41)
GO
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (1, 28, 7, CAST(N'2024-12-17' AS Date), CAST(3585.26 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (2, 19, 9, CAST(N'2024-12-19' AS Date), CAST(2346.95 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (3, 48, 9, CAST(N'2024-11-08' AS Date), CAST(1418.46 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (4, 23, 8, CAST(N'2025-02-07' AS Date), CAST(4853.11 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (5, 2, 8, CAST(N'2024-09-27' AS Date), CAST(2826.59 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (6, 40, 6, CAST(N'2025-04-08' AS Date), CAST(2674.24 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (7, 11, 10, CAST(N'2024-08-14' AS Date), CAST(4051.34 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (8, 33, 8, CAST(N'2025-04-17' AS Date), CAST(4037.49 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (9, 11, 1, CAST(N'2025-06-26' AS Date), CAST(2561.28 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (10, 15, 7, CAST(N'2025-04-14' AS Date), CAST(4832.55 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (11, 22, 6, CAST(N'2024-11-24' AS Date), CAST(2504.35 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (12, 47, 10, CAST(N'2024-08-19' AS Date), CAST(2160.72 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (13, 38, 8, CAST(N'2025-02-17' AS Date), CAST(2512.21 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (14, 17, 8, CAST(N'2025-03-20' AS Date), CAST(3598.38 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (15, 10, 3, CAST(N'2024-07-20' AS Date), CAST(4425.25 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (16, 41, 1, CAST(N'2024-09-12' AS Date), CAST(2318.90 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (17, 35, 8, CAST(N'2024-10-15' AS Date), CAST(4317.22 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (18, 35, 9, CAST(N'2024-12-15' AS Date), CAST(4830.17 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (19, 14, 9, CAST(N'2024-07-21' AS Date), CAST(2054.65 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (20, 37, 6, CAST(N'2024-09-29' AS Date), CAST(3284.30 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (21, 33, 9, CAST(N'2025-03-16' AS Date), CAST(1773.49 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (22, 39, 6, CAST(N'2024-09-24' AS Date), CAST(2788.61 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (23, 6, 9, CAST(N'2024-10-11' AS Date), CAST(2112.27 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (24, 2, 1, CAST(N'2024-07-24' AS Date), CAST(4678.81 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (25, 15, 3, CAST(N'2025-02-22' AS Date), CAST(2568.77 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (26, 35, 8, CAST(N'2025-02-24' AS Date), CAST(4370.54 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (27, 1, 2, CAST(N'2024-09-23' AS Date), CAST(2645.22 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (28, 34, 3, CAST(N'2024-09-23' AS Date), CAST(1255.02 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (29, 17, 5, CAST(N'2024-12-17' AS Date), CAST(3090.72 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (30, 40, 5, CAST(N'2025-03-17' AS Date), CAST(3115.60 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (31, 32, 3, CAST(N'2024-08-17' AS Date), CAST(1177.85 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (32, 45, 4, CAST(N'2024-11-02' AS Date), CAST(1071.63 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (33, 40, 7, CAST(N'2024-09-04' AS Date), CAST(4266.11 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (34, 23, 3, CAST(N'2025-01-17' AS Date), CAST(2324.55 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (35, 23, 8, CAST(N'2025-05-21' AS Date), CAST(4618.09 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (36, 19, 2, CAST(N'2024-12-05' AS Date), CAST(3721.92 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (37, 17, 3, CAST(N'2024-07-05' AS Date), CAST(4175.46 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (38, 39, 10, CAST(N'2024-09-08' AS Date), CAST(3469.37 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (39, 30, 9, CAST(N'2024-10-31' AS Date), CAST(1866.43 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (40, 40, 8, CAST(N'2025-01-02' AS Date), CAST(3522.18 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (41, 1, 9, CAST(N'2025-05-11' AS Date), CAST(2564.79 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (42, 28, 5, CAST(N'2025-04-15' AS Date), CAST(1074.19 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (43, 22, 5, CAST(N'2025-06-01' AS Date), CAST(3848.79 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (44, 39, 8, CAST(N'2025-01-30' AS Date), CAST(2007.16 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (45, 38, 7, CAST(N'2025-07-03' AS Date), CAST(3328.31 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (46, 35, 1, CAST(N'2024-09-02' AS Date), CAST(3962.79 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (47, 29, 6, CAST(N'2025-03-23' AS Date), CAST(1320.16 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (48, 2, 8, CAST(N'2024-08-23' AS Date), CAST(3160.69 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (49, 18, 6, CAST(N'2025-04-11' AS Date), CAST(1187.32 AS Decimal(18, 2)))
INSERT [dbo].[Transaction] ([TransId], [ModelId], [Quantity], [Date], [Amount]) VALUES (50, 20, 5, CAST(N'2024-08-18' AS Date), CAST(1571.94 AS Decimal(18, 2)))
GO
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user0', N'pass0', N'Lori Ortiz', N'65050 Adam Park Suite 249
South Peter, NE 45678', N'432.686.4178', N'as')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user1', N'pass1', N'Julian Powell', N'791 Adam Mill
Willismouth, IN 27814', N'(446)669-1864x1056', N'plan')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user10', N'pass10', N'Trevor Cooper', N'1265 Ashley Fork
Andersonmouth, NH 93756', N'720.823.8008', N'health')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user11', N'pass11', N'Trevor Hogan', N'860 Brett Club
Timothyport, AZ 22542', N'001-820-421-0510x95705', N'throughout')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user12', N'pass12', N'Karen Petersen', N'0095 Kathryn Ranch Suite 604
South Angelamouth, NY 36550', N'(462)770-8174x1610', N'guess')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user13', N'pass13', N'Matthew Carpenter', N'9212 Tracy Camp Apt. 731
South David, WY 28092', N'(860)903-6313', N'stay')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user14', N'pass14', N'Kristi Martinez', N'54554 Molly Ferry
West Leonard, OR 52871', N'(978)755-3652x19390', N'hard')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user15', N'pass15', N'Jennifer Davis', N'3274 Christina Canyon Suite 114
North Jessicaside, MD 73315', N'614.591.1032x23825', N'house')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user16', N'pass16', N'Nicholas Adams', N'779 Frederick Road
South Lisaside, TX 64064', N'+1-416-687-4182x387', N'not')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user17', N'pass17', N'Shannon Flores', N'95996 Rodgers Gateway
Lake Scott, GA 66734', N'877-011-7003', N'sister')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user18', N'pass18', N'Todd Heath', N'515 Vance Branch
New Vincentview, OK 23814', N'001-134-479-6417', N'course')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user19', N'pass19', N'Ryan Hayes', N'73712 Chan Springs Suite 404
South Brian, DC 72674', N'001-774-779-8536x2504', N'month')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user2', N'pass2', N'Johnathan Velez', N'386 Mitchell Rest
Ewingburgh, TN 42699', N'(153)009-3325x8476', N'improve')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user20', N'pass20', N'Mark Miller', N'PSC 6887, Box 4730
APO AP 38482', N'(269)977-6340', N'her')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user21', N'pass21', N'David Parker', N'5914 Jeremy Parkway Suite 228
Lake Dennisburgh, OK 30798', N'106.059.5641x0911', N'million')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user22', N'pass22', N'William Mcdaniel', N'805 Michael Well
Mitchellmouth, VT 00957', N'+1-221-870-0625x99084', N'need')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user23', N'pass23', N'Nicolas Harvey', N'PSC 4299, Box 9700
APO AP 11317', N'9609270469', N'those')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user24', N'pass24', N'Derrick Sellers', N'467 Brown Summit Apt. 015
Lake Phyllis, PA 26581', N'(173)925-7312', N'he')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user25', N'pass25', N'Colton Serrano', N'3631 Jones Rapid
North Phillipshire, NM 50996', N'765-530-5410', N'fund')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user26', N'pass26', N'Rebecca Smith', N'66441 Richardson Pines
Lisaside, NV 53142', N'8897422938', N'water')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user27', N'pass27', N'Deborah Price', N'948 Perez Fords Suite 131
Christinamouth, AL 43647', N'(664)046-4828', N'cultural')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user28', N'pass28', N'Teresa Ford', N'29350 Peters Terrace
South Christopher, VT 42493', N'948.224.9731', N'bad')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user29', N'pass29', N'Mrs. Deborah Moyer', N'270 Robinson Falls
South Anthonyburgh, DC 37622', N'+1-779-460-3463x0897', N'production')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user3', N'pass3', N'Lisa Knox', N'211 Amber Bypass
West Jillland, MI 95150', N'+1-748-421-6964x7536', N'trouble')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user30', N'pass30', N'Robert Watts', N'8532 Katherine Harbors Apt. 296
East Nicole, HI 68846', N'001-839-824-7635x28978', N'pass')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user31', N'pass31', N'Ian Bradley', N'990 Elizabeth Station Suite 563
Port Jessica, OH 20173', N'590.725.6292', N'woman')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user32', N'pass32', N'Zachary Davis', N'USS Edwards
FPO AE 88800', N'+1-845-545-6562x386', N'pass')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user33', N'pass33', N'Kristina Curry', N'436 Thompson Shores
Port Tylerstad, MS 98621', N'(579)230-1772', N'camera')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user34', N'pass34', N'Andrew Smith', N'3353 Zamora Trail
Port Mistychester, SD 53736', N'(241)800-1875', N'every')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user35', N'pass35', N'James Martinez', N'3549 Ochoa Knoll Suite 873
Smithbury, ID 09407', N'478.352.6191x59304', N'cover')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user36', N'pass36', N'Karl Wagner', N'PSC 5474, Box 9295
APO AA 58227', N'001-878-637-7592x7052', N'finish')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user37', N'pass37', N'Katherine Rivas', N'154 Gardner Square
Lake Anne, MA 47669', N'558-819-6765x0590', N'event')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user38', N'pass38', N'Ryan Horn', N'135 Hansen Vista Suite 312
Lake Adamton, AR 68520', N'001-038-266-0291x87470', N'during')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user39', N'pass39', N'Mark Brown', N'PSC 0372, Box 8673
APO AA 39249', N'001-315-032-9105x8191', N'respond')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user4', N'pass4', N'David Warner', N'USS Ferguson
FPO AE 91268', N'0672084400', N'stay')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user40', N'pass40', N'Amy Lopez', N'44062 Little Station Suite 543
Ericville, CO 58463', N'(067)956-0524', N'stand')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user41', N'pass41', N'Henry Martin', N'454 Angela Village Apt. 515
New Alicia, VA 84389', N'074-106-5983x671', N'seven')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user42', N'pass42', N'Olivia Freeman', N'83682 Steve Club
Port Thomasshire, NJ 43418', N'575-866-1374x6638', N'billion')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user43', N'pass43', N'Lauren Garza', N'376 Patricia Row
North Sharonport, FL 67550', N'596-730-5244x92529', N'like')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user44', N'pass44', N'Cathy Olsen', N'519 Jones Turnpike Suite 127
Gomezstad, CA 35886', N'881-926-1880', N'pressure')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user45', N'pass45', N'Taylor Wilson', N'9743 Wyatt Plaza Apt. 636
Lake Denise, TN 98570', N'0964357649', N'name')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user46', N'pass46', N'Rebecca Spencer', N'00469 Garrison Glen
West Andrew, OH 67632', N'(317)207-0697x7795', N'several')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user47', N'pass47', N'Nicholas Schroeder', N'949 Jessica Orchard
Johnland, CT 66465', N'744-874-0424x730', N'other')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user48', N'pass48', N'Michelle Garcia', N'PSC 3009, Box 9161
APO AA 34011', N'896-387-3623x2383', N'boy')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user49', N'pass49', N'Susan Gibson', N'69470 Rivera Divide Suite 215
Phillipbury, CO 35595', N'903.684.0101x24261', N'let')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user5', N'pass5', N'Kayla Acevedo', N'13256 Bell View
North Timothy, DC 76044', N'+1-065-812-2373', N'measure')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user6', N'pass6', N'Kenneth Jones', N'PSC 1057, Box 7228
APO AP 56640', N'043-975-6159', N'nearly')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user7', N'pass7', N'Carly Johnson', N'80540 Kathryn Meadow Apt. 232
West Maria, NJ 07781', N'001-551-699-8585x59367', N'will')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user8', N'pass8', N'David Liu', N'1658 David Gateway Apt. 732
Wellsburgh, TX 70291', N'183-358-1334x5723', N'character')
INSERT [dbo].[User] ([UserName], [Pwd], [EmployeeName], [Address], [MobileNo], [Hint]) VALUES (N'user9', N'pass9', N'Chris Beasley DDS', N'88791 Branch Overpass
North Kimberly, RI 50201', N'(260)279-6941x313', N'without')
GO
ALTER TABLE [dbo].[Mobile]  WITH CHECK ADD FOREIGN KEY([ModelId])
REFERENCES [dbo].[Model] ([ModelId])
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD FOREIGN KEY([CompId])
REFERENCES [dbo].[Company] ([CompId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([CustId])
REFERENCES [dbo].[Customer] ([CustId])
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD FOREIGN KEY([IMEINo])
REFERENCES [dbo].[Mobile] ([IMEINo])
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD FOREIGN KEY([ModelId])
REFERENCES [dbo].[Model] ([ModelId])
GO
USE [master]
GO
ALTER DATABASE [MobileShopDB] SET  READ_WRITE 
GO
