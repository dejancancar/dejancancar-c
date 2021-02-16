--****************SUB-QUERIES*************

--List the cities that are in the 5 smallest countries in the world
	--Find the 5 smallest countries
	SELECT TOP(5) *
		FROM Country
		ORDER BY SurfaceArea ASC

	-- above result is VAT, MCO , GIB, TKL, CCK
SELECT *	
	FROM City
	WHERE CountryCode in ('VAT', 'MCO' , 'GIB', 'TKL', 'CCK')

SELECT *	
	FROM City
	WHERE CountryCode in (SELECT TOP(5) Code FROM Country ORDER BY SurfaceArea)

	--Can I do this with a a JOIN?
	SELECT TOP(5) *
		FROM City ci
		JOIN Country co ON co.Code = ci.CountryCode
		ORDER BY SurfaceArea


--*********** TRANSACTION*********
--SWAP CITIES BETWEEN USA AND GBR



-- *********** UNION *************
-- I wonder how the world's largest cities stack up against entire countries?
-- Get the name, population, and whether it is a city or a country, order by population descending

SELECT name, Population, '' AS 'Is City' FROM Country
--ORDER BY Population DESC
UNION
SELECT name, Population, 'Yes' FROM City
ORDER BY Population DESC



-- *********** SELF_REFERENCING Constraints *************
CREATE TABLE Employee (
	emp_id int identity primary key
	,name varchar(30)
	,supervisor_id int null
	,constraint fk_supervisor Foreign Key (supervisor_id) references Employee (emp_id)
	);

INSERT INTO Employee (name, supervisor_id)
	VALUES ('Ben', null)
INSERT INTO Employee (name, supervisor_id)
	VALUES ('Mike', 1)
INSERT INTO Employee (name, supervisor_id)
	VALUES ('Rosa', 1)
INSERT INTO Employee (name, supervisor_id)
	VALUES ('Luci', 1)
INSERT INTO Employee (name, supervisor_id)
	VALUES ('Robin', 4)

SELECT * FROM Employee

--TELL ME the name of Robin's boss
SELECT emp.name AS Employee , sup.name AS Supervisor
	FROM Employee emp
	JOIN Employee sup ON emp.supervisor_id = sup.emp_id
	WHERE emp.name = 'Rosa'

-- *********** SELF-JOINS *************
/***
***** List every city, alongside the capital city for the country this city is in.
e.g.:
Los Angeles		USA		Washington
New York		USA		Washington
Barcelona		ESP		Madrid
Madrid			ESP		Madrid
***/ 
-- List the city, its country, and the capital city for that country.



-- ******** SELF-JOIN ***************
-- An Example of joining a table to itself, AND
-- An Example of joining to columns other than the PK

-- List each US city along with the other cities in that state.
