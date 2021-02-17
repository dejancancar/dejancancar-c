using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldDB.Models;

namespace WorldDB.DAL
{
    public class CountrySqlDAO : ICountryDAO
    {
        private const string SQL_GETALLCOUNTRIES = "SELECT * FROM Country";
        private const string SQL_GETCOUNTIESBYCONTINENT = "SELECT * FROM Country WHERE continent = @continent";
        private const string SQL_GET_COUNTRY_BY_CODE = "SELECT * FROM Country WHERE code = @countryCode";
        private string connectionString;

        public CountrySqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create a command for select
                    SqlCommand cmd = new SqlCommand(SQL_GETALLCOUNTRIES, conn);

                    //Execute the command and get reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Loop through rows, create a country object for each row, add it to the list
                    while (rdr.Read())
                    {
                        Country country = RowToObject(rdr);
                        countries.Add(country);
                    }
                    return countries;

                }
            }
            catch (SqlException ex)
            {
                //log the error here
                throw;
            }
        }

        public List<Country> GetCountries(string continent)
        {
            List<Country> countries = new List<Country>();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create a command for select
                    SqlCommand cmd = new SqlCommand(SQL_GETCOUNTIESBYCONTINENT, conn);
                    cmd.Parameters.AddWithValue("@continent", continent);

                    //Execute the command and get reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Loop through rows, create a country object for each row, add it to the list
                    while (rdr.Read())
                    {
                        Country country = RowToObject(rdr);
                        countries.Add(country);
                    }
                    return countries;

                }
            }
            catch (SqlException ex)
            {
                //log the error here
                throw;
            }
        }

        public Country GetCountry(string code)
        {
            Country country = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    //Open connection
                    conn.Open();
                    //Create a command for select
                    SqlCommand cmd = new SqlCommand(SQL_GET_COUNTRY_BY_CODE, conn);
                    cmd.Parameters.AddWithValue("@countryCode", code);

                    //Execute the command and get reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //See if there is a row returned, and if so create a country object for it
                    if (rdr.Read())
                    {
                        country = RowToObject(rdr);
                        

                    }


                }
            }
            catch (SqlException ex)
            {
                //log the error here
                throw;
            }
            return country;
        }

        private static Country RowToObject(SqlDataReader rdr)
        {
            Country country = new Country();
            country.Code = Convert.ToString(rdr["Code"]);
            country.Name = Convert.ToString(rdr["Name"]);
            country.Continent = Convert.ToString(rdr["Continent"]);
            country.Region = Convert.ToString(rdr["Region"]);
            country.SurfaceArea = Convert.ToDouble(rdr["SurfaceArea"]);
            country.Population = Convert.ToInt32(rdr["Population"]);
            return country;
        }
    }
}
