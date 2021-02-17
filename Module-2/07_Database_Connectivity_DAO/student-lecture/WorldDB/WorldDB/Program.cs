using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using WorldDB.DAL;
using WorldDB.Models;
using WorldDB.Views;

namespace WorldDB
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code reads the connection string from appsettings.json
            // TODO 03: Add the connection string to appsettings.json and un-comment the following lines to read the configuration
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("World");


            // TEMPORARY: DB EXAMPLE (vanilla, no DAO)
            //ReadCities();
            //return;


            /* CREATED JUST TO TEST MENU
            CountrySqlDAO dao = new CountrySqlDAO(connectionString);
            List<Country> list = dao.GetCountries("Asia");

            Country country = dao.GetCountry("ZZZ");

            country = dao.GetCountry("USA");
            */

            // TODO 04a: Create a Model for Country to go with the City model we already have
            // TODO 04b: Create a CountrySqlDAO class (GetCountries, GetCountries(continent), GetCountry(code))
            // TODO 04c: Create an ICountryDAO interface


            // TODO 10: Create a CitySqlDAO class (GetCitiesByCountryCode)
            // TODO 10a: Create an ICityDAO interface

            // TODO 14a: Create a Model for CountryLanguage
            // TODO 14b: Create a CountryLanguageSqlDAO class (GetLanguages(string countryCode))
            // TODO 14c: Create an ICountryLanguageDAO interface
            ICountryDAO countryDAO = new CountrySqlDAO(connectionString);
            ICityDAO cityDAO = new CitySqlDAO(connectionString);

            // TODO 05b: Create a WorldDBMenu, passing in the country dao, and Run it
            WorldDBMenu menu = new WorldDBMenu(countryDAO, cityDAO);
            menu.Show();

            // Say goodbye to the user...
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Goodbye...");
            Thread.Sleep(1500);
        }

        private static void ReadCities()
        {
            // TODO 01: Read cities from the database and list the results on the screen.
            // TODO 02: Add a parameter to the query to get the cities for a given country code.
            string connectionString = "server=.\\SQLEXPRESS; Database=World; Trusted_Connection=true;";
            Console.Write("Country Code: ");
            string countryCode = Console.ReadLine();

            try
            {
                //Create a connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //Open the connection
                    conn.Open();

                    //Now create a command for a sql statement
                    //can use alias of the column, but must use the alias in Visual Studio as well.
                    SqlCommand cmd = new SqlCommand("Select * from City WHERE CountryCode = @cc", conn); //can do individual coloumns instead of * from city table
                    cmd.Parameters.AddWithValue("@cc", countryCode);

                    //Execute the statement and get back "reader"
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //loop through results
                    while(rdr.Read())
                    {
                        string name = Convert.ToString(rdr["Name"]);
                        int population = Convert.ToInt32(rdr["Population"]);
                        //write like automatically calls ToString when writing
                        Console.WriteLine($"Name: {name}, Population: {population}");
                    }    
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine($"There was a database error: {ex.Message}");
            }


            Console.ReadLine();
        }
    }
}
