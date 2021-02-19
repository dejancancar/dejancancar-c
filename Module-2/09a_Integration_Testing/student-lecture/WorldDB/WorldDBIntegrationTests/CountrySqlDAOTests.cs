using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using WorldDB.DAL;
using WorldDB.Models;

namespace WorldDBIntegrationTests
{
    [TestClass]
    public class CountrySqlDAOTests
    {
        const string connectionString = "Server=.\\SQLExpress;Database=World_Test;Trusted_Connection=True;";
        CountrySqlDAO dao;

        [TestInitialize]
        public void Arrange()
        {
            //arrange
            //Establish the "known state" of the database
            SetupDB(); 
            //Create and instance of CountrySqlDAO
            this.dao = new CountrySqlDAO(connectionString);
        }

        [TestMethod]
        public void GetCountryByIdTest()
        {

            //act
            //Call the GetCountry method
            Country country = dao.GetCountry("USA");

            //assert
            //Make sure we get back the country we expect
            Assert.IsNotNull(country);
            Assert.AreEqual("United States", country.Name);
        }

        [TestMethod]
        public void GetCountriesByContinentTest()
        {
            //arrange
            //Establish the "known state" of the database
            //SetupDB();
            ////Create and instance of CountrySqlDAO
            //CountrySqlDAO dao = new CountrySqlDAO(connectionString);


            //act
            //Call the GetCountries method
            List<Country> countries = dao.GetCountries("North America");

            //assert
            //Make sure we get back the country we expect
            Assert.IsNotNull(countries);
            Assert.AreEqual(2, countries.Count);
        }

        private void SetupDB()
        {

            //Read the DB set up script from the text file
            string filePath = "DBSetup.sql";
            string setupScript = File.ReadAllText(filePath);

            //create a new connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //create a new command from the text file and execute it
                SqlCommand cmd = new SqlCommand(setupScript, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
