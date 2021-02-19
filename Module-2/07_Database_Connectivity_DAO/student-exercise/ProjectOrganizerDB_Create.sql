-- Switch to the system (aka master) database
USE master;
GO

-- Delete the EmployeeDB Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='ProjectOrganizerDB_Tests')
DROP DATABASE ProjectOrganizerDB_Tests;
GO

-- Create a new EmployeeDB Database
CREATE DATABASE ProjectOrganizerDB_Tests;
GO

-- Switch to the EmployeeDB Database
USE ProjectOrganizerDB_Tests 
GO

CREATE TABLE employee (
	employee_id integer identity NOT NULL,
	department_id integer NOT NULL,
	first_name varchar(20) NOT NULL,
	last_name varchar(30) NOT NULL,
	job_title varchar(50) NOT NULL,
	birth_date date NOT NULL,
	gender char(1) NOT NULL,
	hire_date date NOT NULL,
	CONSTRAINT pk_employee_employee_id PRIMARY KEY (employee_id),
	CONSTRAINT ck_gender CHECK (gender IN ('M', 'F'))
);

CREATE TABLE department (
	department_id integer identity  NOT NULL,
	name varchar(40) UNIQUE NOT NULL,
	CONSTRAINT pk_department_department_id PRIMARY KEY (department_id)
);

CREATE TABLE project (
	project_id integer identity  NOT NULL,
	name varchar(40) UNIQUE NOT NULL,
	from_date date not null,
	to_date date not null,
	CONSTRAINT pk_project_project_id PRIMARY KEY (project_id)
);

CREATE TABLE project_employee (	
	project_id integer NOT NULL,
	employee_id integer NOT NULL,
	CONSTRAINT pk_project_employee PRIMARY KEY (project_id, employee_id)
);

ALTER TABLE employee ADD CONSTRAINT fk_employee_department FOREIGN KEY (department_id) REFERENCES department(department_id);

ALTER TABLE project_employee ADD FOREIGN KEY (project_id) REFERENCES project(project_id);
ALTER TABLE project_employee ADD FOREIGN KEY (employee_id) REFERENCES employee(employee_id);

