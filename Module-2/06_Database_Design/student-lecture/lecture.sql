--Use master so that we are not "sitting" in the Art database
Use master
GO

-- Drop the database to start from scratch
DROP DATABASE IF EXISTS ArtGallery
GO

--Create a new empty database
CREATE DATABASE ArtGallery
GO

Use ArtGallery
GO

--START A TRANSACTION SO THE CREATE PROCESS IS ALL OR NOTHING
BEGIN TRANSACTION
/***********************************Create Tables **********************************/

--FIRST CREATE ANY TABLES WITH NO FOREIGN KEY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
--Address
CREATE TABLE Address(
	AddressId INT IDENTITY(1,1)
	,Street nvarchar (100)
	,City nvarchar (50)
	,State nvarchar(50)
	,PostalCode nvarchar(10)

	Constraint pk_address Primary Key (AddressId)
)

--Customer
CREATE TABLE Customer(
	CustomerId INT IDENTITY(1,1)
	,CustomerName NVARCHAR(100) NOT NULL
	,Phone VARCHAR(20) NULL

	,CONSTRAINT pk_customer PRIMARY KEY (CustomerId)
)

--Artist
Create Table Artist (
	ArtistId INT IDENTITY(1,1) -- (1000,10) 1000 would be starting number and 10 would be increment by. Usually (1,1)
	,ArtistName NVARCHAR(50) NOT NULL
	,AddressId INT NULL
	,Phone VARCHAR(20)

	,Constraint pk_artist Primary Key (ArtistId) --pk for primary key and name of table and what type of restraint
	,Constraint fk_artist_address Foreign Key (AddressId) References Address (AddressId)
)

CREATE TABLE Painting (
	PaintingId INT IDENTITY(1,1)
	,ArtistId INT NOT NULL
	,Title nvarchar(100) NOT NULL
	,AskingPrice MONEY NULL

	,CONSTRAINT pk_painting PRIMARY KEY (PaintingId)
	,CONSTRAINT fk_painting_artist FOREIGN KEY (ArtistId) REFERENCES Artist (ArtistId)
)

--Transaction
CREATE TABLE ArtTransaction (
	ArtTransactionId INT IDENTITY(1,1)
	,TransactionType varchar(8) NOT NULL
	,CustomerId INT NOT NULL
	,PaintingId INT NOT NULL
	,TransactionDate DATETIME NOT NULL DEFAULT (GETDATE())
	,Price MONEY NOT NULL

	,CONSTRAINT pk_ArtTransaction PRIMARY KEY (ArtTransactionId)
	,CONSTRAINT fk_ArtTransaction_Customer FOREIGN KEY (CustomerId) REFERENCES Customer (CustomerId)
	,CONSTRAINT fk_ArtTransaction_Painting FOREIGN KEY (PaintingId) REFERENCES Painting (PaintingId)
	,CONSTRAINT ck_ArtTransaction_TransactionType CHECK (TransactionType IN('sale', 'purchase'))
)

--Customer Address
CREATE TABLE CustomerAddress(
	CustomerId INT 
	,AddressId INT
	
	CONSTRAINT pk_CustomerAddress PRIMARY KEY (CustomerId, AddressId)
	,CONSTRAINT fk_CustomerAddress_Customer FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId)
	,CONSTRAINT fk_CustomerAddress_Address FOREIGN KEY (AddressId) REFERENCES Address(AddressId)
)

/********************************INSERT SOME TEST DATA*********************************/
--Same order as creating tables so keys can be referenced properly

--Address
INSERT INTO Address(Street, City, State,PostalCode)
	VALUES ('123 4th Avenue', 'Fonthill', 'ON', 'L3J 4S4')

--Customer
INSERT INTO Customer (CustomerName, Phone)
	VALUES ('Elizabeth Jackson', '206-284-6783')

--CustomerAddress
INSERT INTO CustomerAddress (CustomerId, AddressId)
	VALUES (1,1)

--Artist
INSERT INTO Artist (ArtistName)
	VALUES ('Carol Channing') --1
	,('Dennis Frings') --2

--Painting
INSERT INTO Painting (ArtistId, Title, AskingPrice)
	VALUES(1, 'Laugh with Teeth', 10000)		--1
	,(2, 'South toward Emerald Sea', 3000)		--2
	,(1, 'At the Movies', 7000)					--3

--TRANSACTION
INSERT INTO ArtTransaction (TransactionType, CustomerId, PaintingId, TransactionDate, Price) VALUES
	('SALE', 1, 1, '2020-09-17', 7000)
	,('sale', 1, 2, '2020-05-11', 1800)
	,('SaLe', 1, 3, '2020-02-14', 5550)
	,('sale', 1, 2, '2020-07-15', 2200)




--COMPLETE TRANSACTION
COMMIT TRANSACTION