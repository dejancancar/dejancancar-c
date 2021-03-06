-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in millions of US Dollars
--   The value immediately after the problem statement is the expected number of rows that should be returned by the query.

-- 1. The name and population of all cities in Ontario, Canada (27 rows)
SELECT Name, Population
	FROM City
	Where District = 'Ontario'

-- 2. The name and population of all cities in Montana (1 row)
SELECT Name, Population
	From City
	WHERE District = 'MONTANA'

-- 3. The name, form of government, and head of state of all countries in Europe (46 rows)
SELECT Name, GovernmentForm, HeadOfState
	From Country
	Where Continent = 'Europe'

-- 4. The name, population, surface area, and average life expectancy of all countries in Asia (51 rows)
SELECT name, Population, SurfaceArea, LifeExpectancy
	From Country
	Where Continent = 'asia'

-- 5. The name, country code, and population of all cities with a population greater than 8 million people (10 rows)
SELECT Name, CountryCode, Population
	From City
	Where Population > 8000000

-- 6. The name, country code, and population of all cities with a population less than one thousand people (11 rows)
SELECT Name, CountryCode, Population
	From City
	Where Population < 1000

-- 7. The name, continent, and GNP of all countries with a GNP greater than one trillion dollars (6 rows)
SELECT Name, Continent, GNP
	FROM Country
	WHERE GNP > 1000000

-- 8. The name, continent, population, GNP, and average life expectancy of all countries with an average life expectancy greater than 80 years (5 rows)
SELECT Name, Continent, Population, GNP, LifeExpectancy
	From Country
	Where LifeExpectancy > 80

-- 9. The name and population of all cities in the USA with a population of greater than 1 million people (9 rows)
SELECT Name, Population
	From City
	Where Population > 1000000 
	And CountryCode = 'USA'

-- 10. The name and population of all cities in China with a population of greater than 1 million people (35 rows)
SELECT Name, Population
	FROM City
	Where CountryCode = 'CHN' AND
	Population > 1000000

-- 11. The name and region of all countries in North or South America (51 rows)
SELECT Name, Region
	FROM Country
	Where Continent = 'North America' OR Continent = 'South America'
-- 12. The name, continent, and head of state of all countries whose form of government is a monarchy (43 rows)
SELECT Name, Continent, HeadOfState
	FROM Country
	WHERE GovernmentForm like '%monarchy%'
-- 13. The name of all cities in the USA with a population between 1 million and 2 million people (6 rows) 
SELECT Name
	FROM City
	WHERE CountryCode = 'USA'
	AND Population Between 1000000 and 2000000

-- 14. The name and region of all countries in North or South America except for countries in the Caribbean (27 rows)
SELECT Name, Region
	FROM Country
	WHERE Region <> 'Caribbean' and
	Continent in ('North America') or Continent = 'South America'

-- 15. The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 100 million people (4 rows)
SELECT Name, Population, GNP
	FROM Country
	WHERE GNP > 1000000 and Population < 100000000


-- 16. The name and population of all cities in Texas that have a population of greater than 1 million people (3 rows)
SELECT Name, Population
	FROM City
	WHERE District = 'Texas'
	AND Population > 1000000

-- 17. The name and average life expectancy of all countries on the continent of Oceania (28 rows)
SELECT Name, LifeExpectancy
	FROM Country
	WHERE Continent = 'Oceania'

-- 18. The name and average life expectancy of all countries on the continent of Oceania for which an average life expectancy has been provided (i.e. not equal to null) (20 rows)
SELECT Name, LifeExpectancy
	FROM Country
	WHERE Continent = 'Oceania' AND LifeExpectancy is not null

-- 19. The name of all countries on the continent of Oceania for which an average life expectancy has not been provided (i.e. equal to null) (8 rows)
SELECT Name, LifeExpectancy
	FROM Country
	WHERE Continent = 'Oceania' AND LifeExpectancy is null

-- 20. The name, continent, GNP, and average life expectancy of all countries that have an average life expectancy of at least 70 years and a GNP between $1 million and $100 million dollars (3 rows)
SELECT Name, Continent, GNP, LifeExpectancy
	FROM Country
	Where LifeExpectancy >70 and GNP between 1 and 100

-- 21. The per capita GNP (i.e. GNP divided by population) in US Dollars of all countries in Europe (46 rows)
SELECT GNP / Population as 'GNP Per Capita'
	FROM Country
	WHERE Continent = 'Europe'

-- 22. The number of years since independence for all countries that have a year of independence (192 rows)
SELECT  2021 - IndepYear as 'Years since independence'
	FROM Country
	Where IndepYear is not null