CREATE DATABASE TradesOperations;
GO

USE TradesOperations;
GO

CREATE TABLE Companies (
    CompanyId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    LegalAddress NVARCHAR(255) NOT NULL,
    ContactPhone NVARCHAR(20) NOT NULL
);

CREATE TABLE Managers (
    ManagerId INT PRIMARY KEY IDENTITY,
    Surname NVARCHAR(50) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    Patronymic NVARCHAR(50) NOT NULL,
    CompanyId INT NOT NULL,
    FOREIGN KEY (CompanyId) REFERENCES Companies(CompanyId)
);

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    UnitOfMeasurement NVARCHAR(50) NOT NULL
);

CREATE TABLE Sales ( SaleId INT PRIMARY KEY IDENTITY, DateOfSale DATETIME NOT NULL, Quantity DECIMAL NOT NULL, Price DECIMAL NOT NULL, Discount DECIMAL NOT NULL, ProductId INT NOT NULL, CompanyId INT NOT NULL, FOREIGN KEY (ProductId) REFERENCES Products(ProductId), FOREIGN KEY (CompanyId) REFERENCES Companies(CompanyId));

INSERT INTO Companies (Name, LegalAddress, ContactPhone) VALUES ('Company1', 'Address1', '1234567890'), ('Company2', 'Address2', '1234567891');

INSERT INTO Managers (Surname, FirstName, Patronymic, CompanyId) VALUES ('Smith', 'John', 'A.', 1);

INSERT INTO Products (Name, Description, UnitOfMeasurement) VALUES ('Product1', 'Description1', 'Unit1');

INSERT INTO Sales (DateOfSale, Quantity, Price, Discount, ProductId, CompanyId) VALUES ('2023-01-01', 10, 100, 0, 1, 1);

