using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using WorldDB.Models;

namespace WorldDB.DAL
{
    public class CitySqlDAO : ICityDAO
    {
        private const string SQL_GET_CITY_WITH_COUNTRYCODE = "SELECT * FROM City WHERE CountryCode =  @countryCode";
        private string connectionString;

        public CitySqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        /// <summary>
        /// Get all the cities for a given country
        /// </summary>
        /// <param name="countryCode">ISO code for the country</param>
        /// <returns>List of city objects for that country</returns>
        public List<City> GetCitiesByCountry(string countryCode)
        {
            List<City> cities = new List<City>();
            try
            {
                //create connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //open connection
                    conn.Open();
                    //create a command for the statement
                    SqlCommand cmd = new SqlCommand(SQL_GET_CITY_WITH_COUNTRYCODE, conn);
                    cmd.Parameters.AddWithValue("@countryCode", countryCode);
                    //execute and get a data reader
                    SqlDataReader rdr = cmd.ExecuteReader();

                    //Loop through results set and create city objects
                    while (rdr.Read())
                    {
                        City city = RowToObject(rdr);
                        cities.Add(city);
                    }

                }

            }
            catch
            {
                //log this error

                //re-throw so it can be caught up the stack
                throw;
            }
            return cities;
        }



        private static City RowToObject(SqlDataReader rdr)
        {
            return new City()
            {
                CityId = Convert.ToInt32(rdr["CityId"]),
                CountryCode = Convert.ToString(rdr["CountryCode"]),
                District = Convert.ToString(rdr["District"]),
                Name = Convert.ToString(rdr["name"]),
                Population = Convert.ToInt32(rdr["population"])
            };
        }
    }
}
