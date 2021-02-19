using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ProjectOrganizerTests
{
    [TestClass]
    public class ProjectSqlDAOTests
    {
        const string connectionString = "Server=.\\SQLExpress;Database=ProjectOrganizerDB_Tests;Trusted_Connection=true;";
        ProjectSqlDAO dao;

        [TestInitialize]
        public void Arrange()
        {
            //arrange
            //Establish the "known state" of the database
            SetupDB();
            //Create and instance of CountrySqlDAO
            this.dao = new ProjectSqlDAO(connectionString);
        }

        [TestMethod]
        //[DataRow("Project X", "Project X")]
        //[DataRow("Forelorn Cupcake", "Forelorn Cupcake")]
        //[DataRow("The Never-ending Project", "The Never-ending Project")]
        //[DataRow("Absolutely Done By", "Absolutely Done By")]
        //[DataRow("Royal Shakespeare", "Royal Shakespeare")]
        //[DataRow("Plan 9", "Plan 9")]
        public void GetAllProjectsTest()
        {
            //Act
            IList<Project> projects = dao.GetAllProjects();
            foreach(Project project in projects)
            {
                string actualResult = project.Name;
                //Assert.AreEqual(expectedResult, actualResult);
            }
            //Assert
            Assert.IsNotNull(projects);
            Assert.AreEqual(6, projects.Count);
        }
        
        // int int bool
        [DataTestMethod]
        [DataRow(1,1, true)]
        [DataRow(null, 1, false)]
        [DataRow(1, null, false)]
        [DataRow(-1, 1, false)]

        public void AssignEmployeeToProjectTest(int input1, int input2, bool expectedResult)
        {
            bool actualResult = dao.AssignEmployeeToProject(input1, input2);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void SetupDB()
        {
            string path = "ProjectOrganizerDBSetup.sql";
            string setupScript = File.ReadAllText(path);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(setupScript, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
