-- Show all Cities with all their country information
SELECT *
	FROM City 
	JOIN Country ON city.CountryCode = Country.Code

SELECT *
	FROM City AS ci
	JOIN Country AS co ON ci.CountryCode = co.Code


-- List the "city name, country name" and city population, sorted by country and city population descending
SELECT ci.Name 'city name', co.Name 'country name', ci.Population 'city population'
	FROM City ci
	JOIN Country co ON ci.CountryCode = co.Code
	ORDER BY [country name], [city population] DESC

SELECT ci.Name + ', ' + co.Name City, ci.Population 'city population'
	FROM City ci
	JOIN Country co ON ci.CountryCode = co.Code
	ORDER BY co.Name, [city population] desc


-- List the city name, country name and the percentage of the country's population in the city
SELECT ci.Name, co.Name, (ci.Population * 100.0 / co.Population) PercentagePop
	FROM City ci
	JOIN Country co ON ci.CountryCode = co.Code

-- List the country name and its languages
SELECT Name, LanguageName
	FROM CountryLanguage cl
	JOIN Country co ON cl.CountryCode = co.Code
	JOIN Language l ON cl.LanguageId = l.LanguageId
	ORDER BY Name, cl.Percentage DESC

-- List the country name and its official language
SELECT Name, LanguageName
	FROM CountryLanguage cl
	JOIN Country co ON cl.CountryCode = co.Code
	JOIN Language l ON cl.LanguageId = l.LanguageId
	WHERE cl.IsOfficial = 1 -- need to add 1 or 0
	ORDER BY Name


-- Let's display a list of all countries and their capitals.
SELECT co.Name Country, ci.Name Capital
	FROM Country co
	JOIN City ci ON co.Capital = ci.CityId



-- Only 232 rows. Where are the other 7 rows?
-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. If we want to show data FROM the left side table everytime, we can use a different join:

-- ********* LEFT JOIN ***********
-- A Left join selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.
SELECT co.Name Country, ci.Name Capital
	FROM Country co	LEFT OUTER JOIN City ci ON co.Capital = ci.CityId

	--SAME RESULT USING A RIGHT JOIN
SELECT co.Name Country, ci.Name Capital
	FROM City ci right OUTER JOIN Country co ON co.Capital = ci.CityId

	--JUST TO SEE WHAT WOULD HAPPEN, WHAT IF I DID A RIGHT JOIN HERE?
SELECT co.Name Country, ci.Name Capital
	FROM Country co	RIGHT OUTER JOIN City ci ON co.Capital = ci.CityId



-- List the countries and their capital cities, but make sure the country is listed even if it has no capital






-- (go play in the dvd store for a while...)



------------------------- More JOINs and UNION -------------------------------------

-- List the cities which are not capitals


-- Can we do this another way?


-- List the city and the country it's a capital of


-- *********** UNION *************

-- How does the population of the largest cities compare with entire countries?
-- Get the name, population, and whether it is a city or a country, order by population descending



-- ***** What if I want to list every city, alongside the capital city for the country this city is in?
-- List the city, its country, and the capital city for that country.



-- ******** SELF-JOIN ***************
-- An Example of joining a table to itself, AND
-- An Example of joining to columns other than the PK

-- List each US city along with the other cities in that state.

