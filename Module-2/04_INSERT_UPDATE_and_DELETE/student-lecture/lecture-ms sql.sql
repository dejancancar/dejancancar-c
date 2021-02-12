-- INSERT
-- 1. Add a city to the City table, district 'Ohio'
INSERT INTO City (Name, CountryCode, District, Population)
	VALUES ('Dejanville', 'USA', 'Ohio', 1969);

	
-- 1a. What is the @@Identity?
SELECT @@IDENTITY

-- 2. Add 2 more cities to Ohio using one insert statement
INSERT INTO City (Name, CountryCode, District,Population)
	VALUES 
	('Cleveland Heigths', 'USA', 'Ohio', 43000),
	('Lakewood', 'USA', 'Ohio', 50000)
-- 2a. What is the @@Identity?
SELECT @@IDENTITY

-- 0. Add Klingon to the Language table (ADDED 458)
INSERT INTO Language (LanguageName)
	VALUES ('Klingon')
-- 0a. What is the @@Identity?
SELECT @@IDENTITY
-- 1. Add Klingon as a spoken language in the USA
INSERT INTO CountryLanguage (CountryCode, LanguageId, IsOfficial, Percentage)
	VALUES ('USA', 458, 0, 12.0)

		-- Languages of the USA:
			SELECT *
				FROM CountryLanguage cl
				JOIN Language l ON cl.LanguageId = l.LanguageId
				WHERE cl.CountryCode = 'USA'
-- 2. Add Klingon as a spoken language in Great Britain
INSERT INTO CountryLanguage (CountryCode, LanguageId, IsOfficial, Percentage)
	VALUES ( 'GBR', 458, 1, 32.0)

	INSERT INTO CountryLanguage (CountryCode, LanguageId, IsOfficial, Percentage)
	VALUES ( 'GBR', (SELECT LanguageId from Language WHERE  LanguageName = 'Klingon'), 1, 32.0)

select * from Country
	WHERE name like '%brit%'


-- UPDATE

-- 0. Update the population of Cleveland to 2020 values (379,233)
UPDATE City
	SET Population = 379233 WHERE name = 'Cleveland'
	-- check with cityID or primary key incase more than 1 cleveland
	--PUT WHERE in the same line as SET to make sure you grab both
	


-- 1. Update the capital of the USA to Houston
--NEED TO KNOW CITY ID first
SELECT * 
	FROM City
	WHERE name = 'Houston' AND District = 'Texas'

SELECT * 
	FROM Country 
	WHERE Code = 'USA'

UPDATE Country
	SET Capital = (SELECT CityID FROM City WHERE name = 'Houston' AND District = 'Texas')
	WHERE Code = 'USA'

-- 2. Update the capital of the USA to Washington DC and the head of state
UPDATE Country
	SET Capital = (SELECT CityID FROM City WHERE name = 'Washington'), HeadOfState = 'Joe Biden' WHERE Code = 'USA'

-- DELETE

-- 0. Delete the newly added Ohio cities
DELETE FROM City WHERE name = 'Dejanville' AND District = 'Ohio'

DELETE FROM City WHERE name in ('Cleveland Heigths' , 'Lakewood' , 'Dejanville') AND District = 'Ohio'

-- 1. Delete English as a spoken language in the USA
DELETE FROM CountryLanguage WHERE CountryCode = 'USA' AND LanguageId = (SELECT LanguageId FROM Language WHERE LanguageName = 'Klingon')
-- 2. Delete all occurrences of the Klingon language 
DELETE FROM CountryLanguage WHERE LanguageId = (SELECT LanguageId FROM Language WHERE LanguageName = 'Klingon')
DELETE FROM Language WHERE LanguageName ='Klingon'


-- REFERENTIAL INTEGRITY

-- 1. Add a city to the City table in the country 'ZZZ'
INSERT INTO City (Name, CountryCode, District, Population)
	VALUES ('Richfield', 'ZZZ', 'Ohio', 12000) -- error because country does not have country.code of ZZZ

-- 1. Try just adding Elvish to the country language table.

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

-- 3. Try deleting the country USA. What happens?
DELETE Country WHERE Code = 'USA'

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'
UPDATE Country 
	SET Continent = 'Outer Space' -- not in continent so you cannot update USA to outer space.
	WHERE Code = 'USA'


-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS


-- TRANSACTIONS

-- 1. Try deleting all of the rows from the country language table and roll it back.
BEGIN TRANSACTION
	DELETE FROM CountryLanguage
	SELECT * FROM CountryLanguage
ROLLBACK TRANSACTION

-- 2. Try updating all of the cities to be in the USA and roll it back

-- 3. Demonstrate two different SQL connections trying to access the same table where one happens to be inside of a transaction but hasn't committed yet.