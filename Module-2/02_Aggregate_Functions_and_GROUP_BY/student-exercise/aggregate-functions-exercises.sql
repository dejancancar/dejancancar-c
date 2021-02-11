-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)
SELECT Name + ', '+ District as name_and_state, Population
	FROM City
	Where CountryCode = 'USA' and 
	district in ('Pennsylvania', 'West Virginia', 'Kentucky' , 'Indiana', 'Michigan')
	order by name_and_state, CityId

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)
SELECT name + ' (' + Code + ')'as country_and_code,  Region
	FROM Country
	WHERE Continent = 'Africa'



-- 3. The per capita GNP (i.e. GNP multipled by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is express in units of one million US Dollars 
-- (highest per capita GNP in world: 37459.26)
Select (GNP * 1000000) / Population as 'Per Capita GNP'
	FROM Country
	Where Population != 0
	order by [Per Capita GNP] desc

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)
SELECT avg(LifeExpectancy)
	FROM Country
	Where Continent = 'South America'

-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)
SELECT sum(Population)
	FROM City
	Where District = 'California'

-- 6. The sum of the population of all cities in China.
-- (total population of all cities in China: 175953614)
SELECT SUM(Population)
	FROM City
	WHERE CountryCode = 'CHN'

-- 7. The maximum population of all countries in the world.
-- (largest country population in world: 1277558000)
SELECT Max(Population) as 'Largest country population in World'
	FROM Country

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)
SELECT Max(Population) as 'Largest City Population in World'
	FROM City

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)
SELECT Max(Population)
	FROM City
	WHERE CountryCode = 'AUS'

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)
SELECT MIN(Population) as smallest_country_population
	FROM Country
	Where Population != 0

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)
SELECT AVG(Population) as Average_city_population
	FROM City
	Where CountryCode = 'USA'

SELECT CAST(AVG(Population) as numeric(11,4))
	FROM City
	Where CountryCode = 'USA'

SELECT AVG(CAST(Population as decimal(11,4)))
	FROM City
	Where CountryCode = 'USA'

-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)
SELECT AVG(Population) AS Average_city_population
	FROM City
	WHERE CountryCode = 'CHN'

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")
SELECT Continent, SUM(SurfaceArea) AS largest_continental_surface_area
	FROM Country
	GROUP BY Continent
	Order by largest_continental_surface_area DESC

-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)
SELECT Population / SurfaceArea AS highest_population_density
	FROM Country
	--WHERE SurfaceArea != 0
	ORDER BY highest_population_density DESC

-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")
SELECT TOP(10) LifeExpectancy , Population / SurfaceArea AS highest_population_density, Name
	FROM Country
	--WHERE LifeExpectancy is NOT NULL
	ORDER BY LifeExpectancy DESC

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")
SELECT (GNP - GNPOld) AS GNP_difference, ABS(GNP - GNPOld) AS Absolute_GNP_difference , Name
	FROM Country
	WHERE GNP IS NOT NULL AND GNPOld IS NOT NULL
	ORDER BY Absolute_GNP_difference 

-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")
SELECT AVG(Population) AS 'avg population', CountryCode
	FROM City
	GROUP BY City.CountryCode
	ORDER BY [avg population] DESC

-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)
SELECT District, COUNT(*) AS Number_Of_Cities
	FROM City
	WHERE CountryCode = 'USA'
	GROUP BY District
	ORDER BY District

-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")
SELECT COUNT(*) AS Number_of_countries, Continent
	FROM Country
	GROUP BY Continent
	ORDER BY Number_of_countries DESC
	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")
SELECT COUNT(*) AS 'Number of Cities', CountryCode
	FROM City
	GROUP BY CountryCode
	Order by [Number of Cities] DESC
	
-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")
SELECT MAX(Population) AS 'Largest city population', CountryCode
	FROM City
	GROUP BY CountryCode
	ORDER BY [Largest city population] DESC

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")
SELECT AVG(LifeExpectancy) AS 'Average life expectancy',
		MIN(LifeExpectancy) AS 'Minimum life expectancy',
		MAX(LifeExpectancy) As 'Minimum life expectancy', Continent
	FROM Country
	WHERE LifeExpectancy IS NOT NULL
	GROUP BY Continent
	ORDER BY [Average life expectancy]
