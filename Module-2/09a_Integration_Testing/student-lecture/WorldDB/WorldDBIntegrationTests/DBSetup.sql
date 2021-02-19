--USE World_Test
--GO
--This script will be run before every integration test to establish
-- the database into a known state.

-- First, remove all data from the tables

--BEFORE DELETING COUNTRY, WE HAVE TO MAKE THE CAPITALS NULL OTHERWISE WE HAVE DUAL REFERENCES BETWEEN CITY AND COUNTRY
UPDATE Country SET Capital = NULL
DELETE FROM CountryLanguage
DELETE FROM City
DELETE FROM Country
DELETE FROM Language


--Add to most independent table first
--Insert rows into Language
INSERT INTO Language (LanguageName) VALUES 
	('English')
	,('JavaScript')
	,('Elvish')

--Insert rows into Country
INSERT INTO [dbo].[Country]
		   ([Code]
           ,[Name]
           ,[Continent]
           ,[Region]
           ,[SurfaceArea]
           ,[IndepYear]
           ,[Population]
           ,[LifeExpectancy]
           ,[GNP]
           ,[GNPOld]
           ,[LocalName]
           ,[GovernmentForm]
           ,[HeadOfState]
           ,[Capital]
           ,[Code2])
     VALUES
           ('USA', 'United States', 'North America', '', 100000, 1776, 1000000, 80, null, null, 'United States', 'Democracy', 'Mickey Mouse', null, 'US')
		   ,('CAN', 'Canada', 'North America', '', 200000, null, 2000000, 69, null, null, 'Canada', 'Dictatorship', 'Daffy Duck', null, 'CA')
		   ,('GBR', 'United Kingdom', 'Europe', '', 200000, 1066, 2000000, 71, null, null, 'England', 'Queen RULES', 'Sneaky Pete', null, 'UK')

--Insert Rows into CountryLanguage
INSERT INTO CountryLanguage (CountryCode, LanguageId, IsOfficial, Percentage) VALUES
	('USA', (SELECT LanguageId FROM Language WHERE LanguageName = 'English'), 0, 75.0)
	,('USA',(SELECT LanguageId FROM Language WHERE LanguageName = 'JavaScript'), 1, 55.0)
	,('CAN',(SELECT LanguageId FROM Language WHERE LanguageName = 'Elvish'), 1, 44.0)
	,('GBR',(SELECT LanguageId FROM Language WHERE LanguageName = 'English'), 0, 88.0)
	,('GBR',(SELECT LanguageId FROM Language WHERE LanguageName = 'Elvish'), 1, 56.0)

--Insert rows into City
INSERT INTO City (name, CountryCode, District, Population) VALUES
	('Cleveland', 'USA', 'Ohio', 10000)
	,('Mayberry', 'USA', 'North Carolina', 20000)
	,('Toronto', 'CAN', 'Ontario', 3939)
	,('London', 'GBR', 'Queen Land', 8675309)

--Set the capital cities
UPDATE Country SET Capital = (SELECT CityId FROM City WHERE name = 'Cleveland') WHERE Code = 'USA'
UPDATE Country SET Capital = (SELECT CityId FROM City WHERE name = 'Toronto') WHERE Code = 'CAN'
UPDATE Country SET Capital = (SELECT CityId FROM City WHERE name = 'London') WHERE Code = 'GBR'