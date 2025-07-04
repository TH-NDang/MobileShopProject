-- Tạo database
CREATE DATABASE MobileShopDB;
GO

-- Sử dụng database
USE MobileShopDB;
GO

-- Bảng User
CREATE TABLE [User] (
    UserName NVARCHAR(50) PRIMARY KEY NOT NULL,
    Pwd NVARCHAR(50),
    EmployeeName NVARCHAR(100),
    Address NVARCHAR(200),
    MobileNo NVARCHAR(MAX),
    Hint NVARCHAR(100)
);
GO

-- Bảng Company
CREATE TABLE Company (
    CompId INT PRIMARY KEY NOT NULL,
    CompName NVARCHAR(100)
);
GO

-- Bảng Model
CREATE TABLE Model (
    ModelId INT PRIMARY KEY NOT NULL,
    CompId INT FOREIGN KEY REFERENCES Company(CompId),
    ModelNo NVARCHAR(100),
    AvalableQty INT
);
GO

-- Bảng Customer
CREATE TABLE Customer (
    CustId INT PRIMARY KEY NOT NULL,
    CustName NVARCHAR(100),
    MobileNo NVARCHAR(MAX),
    MailId NVARCHAR(100),
    Address NVARCHAR(200)
);
GO

-- Bảng Transaction
CREATE TABLE [Transaction] (
    TransId INT PRIMARY KEY NOT NULL,
    ModelId INT FOREIGN KEY REFERENCES Model(ModelId),
    Quantity INT,
    Date DATE,
    Amount DECIMAL(18, 2)
);
GO

-- Bảng Mobile
CREATE TABLE Mobile (
    IMEINo NVARCHAR(50) PRIMARY KEY NOT NULL,
    ModelId INT FOREIGN KEY REFERENCES Model(ModelId),
    Status NVARCHAR(50),
    Warranty INT,
    Price DECIMAL(18, 2)
);
GO

-- Bảng Sales
CREATE TABLE Sales (
    SalesId INT PRIMARY KEY NOT NULL,
    IMEINo NVARCHAR(50) FOREIGN KEY REFERENCES Mobile(IMEINo),
    SakesDate DATE,
    Price DECIMAL(18, 2),
    CustId INT FOREIGN KEY REFERENCES Customer(CustId)
);
GO
