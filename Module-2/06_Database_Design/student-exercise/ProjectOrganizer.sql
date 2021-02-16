USE master
GO

DROP DATABASE IF EXISTS ProjectOrganizer
GO

CREATE DATABASE ProjectOrganizer
GO

USE ProjectOrganizer
GO

CREATE TABLE Title(
	TitleId INT IDENTITY(1,1)
	,TitleName NVARCHAR(50) NOT NULL

	,CONSTRAINT pk_jobtitle PRIMARY KEY (TitleId)
)
CREATE TABLE Department(
	DepartmentId INT IDENTITY(1,1)
	,DepartmentName NVARCHAR(50) NOT NULL

	,CONSTRAINT pk_department PRIMARY KEY (DepartmentId)
	
)

CREATE TABLE Project(
	ProjectId INT IDENTITY(1,1)
	,ProjectName NVARCHAR(100) NOT NULL
	,StartDate DATETIME NOT NULL DEFAULT (GETDATE())
	,EndDate DATETIME NOT NULL DEFAULT ('yyyy-mm-dd')

	,CONSTRAINT pk_project PRIMARY KEY (ProjectId)
	
)

CREATE TABLE Employee(
	EmployeeId INT IDENTITY(1,1)
	,DepartmentId INT
	,TitleId INT
	,FirstName NVARCHAR(50) NOT NULL
	,LastName NVARCHAR(50) NOT NULL
	,Gender NVARCHAR(20) NULL
	,DateOfBirth DATETIME NOT NULL DEFAULT ('yyyy-mm-dd')
	,DateOfHire DATETIME NOT NULL DEFAULT (GETDATE())

	,CONSTRAINT pk_employee PRIMARY KEY (EmployeeId)
	,CONSTRAINT fk_employee_department FOREIGN KEY (DepartmentId) REFERENCES Department (DepartmentId)
	,CONSTRAINT fk_employee_title FOREIGN KEY (TitleId) REFERENCES Title (TitleId)
	,CONSTRAINT ck_dateofbirth CHECK (DateOfBirth < ='2003-01-01')
)

CREATE TABLE EmployeeProject(
	EmployeeId INT
	,ProjectId INT

	,CONSTRAINT pk_employeeproject PRIMARY KEY (EmployeeId, ProjectId)
	,CONSTRAINT fk_employeeproject_employee FOREIGN KEY (EmployeeId) REFERENCES Employee (EmployeeId)
	,CONSTRAINT fk_employeeproject_project FOREIGN KEY (ProjectId) REFERENCES Project (ProjectId)
)

INSERT INTO Title (TitleName) VALUES
	('Software Developer')	--1
	,('QA')					--2
	,('Project Manager')		--3

INSERT INTO Department (DepartmentName) VALUES
	('Quality Assurance')	--1
	,('IT')					--2
	,('Management')			--3

INSERT INTO Project (ProjectName, EndDate) VALUES
	('Create Project Organizer Database', '2021-02-20')				--1
INSERT INTO Project (ProjectName, StartDate, EndDate) VALUES
	('Unit Test Assesment', '2021-01-06', '2021-01-10')				--2
	,('Create Vending Machine Software', '2021-06-11', '2022-01-01')	--3
	,('Vending Machine Tests', '2022-01-02', '2022-02-01')				--4

INSERT INTO Employee (FirstName, LastName, Gender, DateOfBirth, DateOfHire, DepartmentId, TitleId) VALUES
	('Dejan', 'Cancar', 'male', '1986-01-06', '', 1, 2)							--1
	,('Michelle', 'Knafler', 'Female', '1991-01-06', '2015-05-19', 3, 3)		--2
	,('Bill', 'Michaels', '',  '1995-04-03', '2018-08-11',2, 1)					--3
	,('Calvin', 'Cancar', '', '2000-12-12', '', 3,3)							--4
	,('Zoran', 'Cancar', 'male', '1984-12-24', '', 2, 1)						--5
	,('Ben', 'Kennedy', '', '1980-03-23', '2005-11-24', 1, 2)					--6
	,('Mike', 'Morel', '', '1965-09-29', '', 3,3)								--7
	,('Thomas', 'Cooper', 'male', '1975-03-15', '2019-01-01', 1, 1)				--8

INSERT INTO EmployeeProject ( EmployeeId, ProjectId) VALUES
	(1,2)
	,(4,2)
	,(3,1)
	,(6,4)
