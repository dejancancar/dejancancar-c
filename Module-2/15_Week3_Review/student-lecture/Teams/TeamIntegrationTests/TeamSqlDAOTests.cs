using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.IO;
using Teams.DAL;
using Teams.Models;

namespace TeamIntegrationTests
{
    [TestClass]
    public class TeamSqlDAOTests
    {
        private string connectionString = @"Server=.\SQLExpress;Database=NFLDB;Trusted_Connection=True;";
        private TeamSqlDAO teamDAO;
        int BrownsTeamId = 0;
        [TestInitialize]
        public void SetupBeforeEachTest()
        {
            //Read the testsetup script into a string
            string setupScript = File.ReadAllText("SetupTestData.sql");
            //Create a connection
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(setupScript, conn);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    BrownsTeamId = Convert.ToInt32(rdr["BrownsId"]);
                }

            }
            //execute the test setup script

            //Create a DAO to be used in all the tests
            this.teamDAO = new TeamSqlDAO(connectionString);
        }


        [TestMethod]
        public void GetByIdWithBadId_ShouldReturnNULL()
        {
            //Arrange - Create an instance of the DAO
            //TODO 1 :LATER - run the testSetup Script

            //Act - Execute the GetById method with a known bad id
            Team actualTeam = teamDAO.GetTeamsById(-1);

            //Assert
            Assert.IsNull(actualTeam);
        }
        [TestMethod]
        public void GetByIdWithGoodId_ShouldReturnTeam()
        {
            //Arrange - Create an instance of the DAO
            //TODO 1 :LATER - run the testSetup Script

            //Act - Execute the GetById method with a known bad id
            Team actualTeam = teamDAO.GetTeamsById(BrownsTeamId);

            //Assert
            Assert.IsNotNull(actualTeam);
            Assert.AreEqual("Cleveland", actualTeam.Location);
            Assert.AreEqual("Browns", actualTeam.TeamName);
        }
    }
}
