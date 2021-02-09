/*************************************************************************************
	Some additional queries from yesterday
*************************************************************************************/

-- The name and region of all countries in North or South America.  HOW MANY ways can we do this?
Select name, region, continent
	FROM Country
	Where Continent = 'North America' OR continent = 'South America'

Select name, region, continent
	FROM Country
	Where Continent in ('North America', 'South America')

Select name, region, continent
	FROM Country
	Where Continent like '%America'
  
-- The name, continent, and head of state of all countries whose form of government is a monarchy
SELECT name, Continent, HeadOfState, GovernmentForm
	FROM Country
	where GovernmentForm like '%monarchy%'

-- The name and region of all countries in North or South America except for countries in the Caribbean

-- The name, population, and GNP of all countries with a GNP greater than $1 trillion dollars and a population of less than 1 billion people

-- The names of all the US States
SELECT distinct district
	FROM city
	WHERE CountryCode = 'USA'

/*************************************************************************************
*************************************************************************************/

-- ORDERING RESULTS

-- Populations of all countries in descending order
SELECT name, Population
	FROM Country
	order by Population desc

--Names of countries and continents in ascending order
SELECT Name, Continent
	FROM Country
	--order by name
	order by Continent, Name

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.

SELECT top 10 name, LifeExpectancy
	FROM Country
	order by LifeExpectancy desc

--ISNULL EXAMPLE
select name, IsNull(cast (IndepYear as varchar(15)), 'Not Independent')
	from Country
	order by IndepYear

-- CONCATENATING OUTPUTS

-- The name & state of all cities in California, Oregon, or Washington.
-- "city, state", sorted by state then city
SELECT Name + ', ' + District
	FROM City
	WHERE District in ('California', 'Oregon', 'Washington')
	order by District, name

-- Can you do it another way?


-- AGGREGATE FUNCTIONS
-- Average Life Expectancy in the World
SELECT avg (LifeExpectancy)
	FROM Country
	--Where Continent = 'Africa'


-- Total population in Ohio
SELECT Sum(population) As 'Ohio Population'
	From City
	Where District = 'ohio' and CountryCode = 'USA'

-- The surface area of the smallest country in the world
select min( SurfaceArea) as 'Smallest Surface Area'
	from Country

Select Top(1) name, SurfaceARea
	From Country
	Order by SurfaceArea ASC


-- The 10 largest countries in the world
Select Top(10) name, SurfaceARea
	From Country
	Order by SurfaceArea desc

-- The number of countries who declared independence in 1991
SELECT COUNT(*) as NumCountries
	FROM Country
	WHERE IndepYear = 1991

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least.     LanguageIds not helpful so switching to below.
--Count the number of languages Spoken in each country, order from most languages to the least.

SELECT CountryCode, Count(*) as 'Languages Spoken'
	FROM CountryLanguage
	Group By CountryCode
	order by [Languages Spoken] desc

-- Average life expectancy of each continent ordered from highest to lowest
SELECT Continent , Avg(LifeExpectancy) as 'Avg Life Expectancy'
	FROM Country
	Group by Continent
	order by [Avg Life Expectancy] DESC
	-- order by 2 desc also works but above is preffered.

-- Show the total populations of all disctricts in the world order by country and district
CAN New Brunswick 9999999999
CAN Ontario 555555555
USA New York 88888888
USA Ohio 35525

SELECT CountryCode, District, SUM(Population) as 'Total Population'
	FROM City
	Group by CountryCode, District
	order by CountryCode, District

-- Exclude Antarctica from consideration for average life expectancy
SELECT Continent , Avg(LifeExpectancy) as 'Avg Life Expectancy'
	FROM Country
	WHERE LifeExpectancy is Not null
	Group by Continent
	order by [Avg Life Expectancy] DESC

-- Sum of the population of cities in each state in the USA ordered by state name
SELECT District as State, SUM(Population) as 'Total Population'
	FROM City
	Where CountryCode = 'USA'
	Group by District
	order by State

-- The average population of cities in each state in the USA ordered by state name
SELECT District as State, avg(Population) as 'Avg Population'
	FROM City
	Where CountryCode = 'USA'
	Group by District
	order by State

-- SUBQUERIES
-- Find the names of cities under a given government leader
-- 'George W. Bush'

-- First find the countries under this leader


-- Now find the cities in these countries
SELECT *
	FROM City
	WHERE CountryCode in ('ASM', 'GUM', 'MNP', 'PRI', 'UMI', 'USA', 'VIR')

	-- USE A SUB-QUERY TO ACCOMPLISH ABOVE
	SELECT *
		FROM City
		WHERE CountryCode in (SELECT Code FROM Country WHERE HeadOfState = 'George W. Bush')

-- Find the names of cities whose country they belong to has not declared independence yet

-- Select those countries with lower than average life expectancy

-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Aggregate functions provide the ability to COUNT, SUM, and AVG, as well as determine MIN and MAX. Only returns a single row of value(s) unless used with GROUP BY.
-- Counts the number of rows in the city table

-- Also counts the number of rows in the city table

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.
