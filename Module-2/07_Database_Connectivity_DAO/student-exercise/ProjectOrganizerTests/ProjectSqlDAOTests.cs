using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace ProjectOrganizerTests
{
    [TestClass]
    public class ProjectSqlDAOTests
    {
        private string connectionString = "Server=.\\SQLExpress;Database=ProjectOrganizerDB_Tests;Trusted_Connection=true;";
        private ProjectSqlDAO dao;

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

        public void GetAllProjectsTest()
        {
            //Act
            IList<Project> projects = dao.GetAllProjects();

            Assert.IsNotNull(projects);
            Assert.AreEqual(6, projects.Count);
        }

        // int int bool
        [TestMethod]


        public void AssignEmployeeToProjectTest()
        {
            int projectId;
            int employeeId;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT employee_id FROM employee WHERE first_name = 'Delora' and Last_name = 'Coty'", conn);
                employeeId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd = new SqlCommand("SELECT project_id FROM project WHERE name = 'Plan 9'", conn);
                projectId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            bool actualResult = dao.AssignEmployeeToProject(projectId, employeeId);
            //Assert
            Assert.AreEqual(true, actualResult);
        }
        [TestMethod]
        public void RemoveEmployeeFromProjectTest()
        {
            int projectId;
            int employeeId;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT employee_id FROM employee WHERE first_name = 'Jarred' and Last_name = 'Lukach'", conn);
                employeeId = Convert.ToInt32(cmd.ExecuteScalar());
                cmd = new SqlCommand("SELECT project_id FROM project WHERE name = 'Plan 9'", conn);
                projectId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            bool result = dao.RemoveEmployeeFromProject(projectId, employeeId);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CreateProjectTest()
        {
            int projId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO project (name,from_date,to_date) VALUES " +
                    "('Test Project', '01-01-2021', '01-01-2022'); SELECT @@IDENTITY", conn);
                projId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            Assert.IsNotNull(projId);

        }

        private void SetupDB()
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
