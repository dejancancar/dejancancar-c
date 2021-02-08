-- SELECT ... FROM
-- Selecting the names for all countries
SELECT Name FROM Country

-- Selecting the name and population of all countries
SELECT Name, Population 
	FROM Country

-- Selecting all columns from the city table
SELECT * FROM City

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
--SELECT * FROM City WHERE District = 'Ohio'
SELECT * 
	FROM City 
	WHERE District = 'Ohio'

-- Selecting countries that gained independence in the year 1776
SELECT * FROM Country
			Where IndepYear = 1776


-- Selecting countries not in Asia
SELECT Name, Continent FROM Country WHERE Continent != 'asia' --<> not equal to


-- Selecting countries that do not have an independence year
SELECT * 
	FROM Country
	WHERE IndepYear  is NULL 


-- Selecting countries that do have an independence year
SELECT * 
	FROM Country
	WHERE IndepYear  is not NULL

-- Selecting countries that have a population greater than 5 million
SELECT Name, Population
	FROM Country
	WHERE Population > 5000000


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000
SELECT *
	FROM City
	WHERE District = 'Ohio' 
		AND Population > 400000

-- Selecting country names on the continent North America or South America
SELECT Name
	FROM Country
	WHERE Continent = 'North America'
		OR Continent = 'South America'

SELECT Name
	FROM Country
	Where Continent in ('North America', 'South America')




-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword

SELECT Name, Population, LifeExpectancy, Population / SurfaceArea as 'Population Density'
	FROM Country

