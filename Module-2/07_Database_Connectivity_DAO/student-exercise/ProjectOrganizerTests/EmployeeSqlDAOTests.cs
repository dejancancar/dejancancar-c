using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectOrganizer.DAL;
using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace ProjectOrganizerTests
{
    [TestClass]
    public class EmployeeSqlDAOTests
    {
        private string connectionString = "Server=.\\SQLExpress;Database=ProjectOrganizerDB_Tests;Trusted_Connection=true;";
        EmployeeSqlDAO dao;

        [TestInitialize]
        public void Arrange()
        {
            SetupDB();
            this.dao = new EmployeeSqlDAO(connectionString);
        }
        [TestMethod]
        public void GetAllEmployeesTest()
        {
            IList<Employee> employees;
            int expectedResult;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from employee", conn);
                expectedResult = Convert.ToInt32(cmd.ExecuteScalar());
            }
            employees = dao.GetAllEmployees();
            Assert.AreEqual(expectedResult, employees.Count );
        }

        [TestMethod]
        public void SearchTest()
        {
            IList<Employee> employees;
            employees = dao.Search("Franklin","Trumbauer");

            Assert.IsNotNull(employees);
            Assert.AreEqual(1, employees.Count);

        }
        [TestMethod]
        public void GetEmployeesWithoutProjects()
        {
            IList<Employee> employees;
            employees = dao.GetEmployeesWithoutProjects();

            Assert.IsNotNull(employees);
            Assert.AreEqual(2, employees.Count);
            Assert.AreEqual(employees[0].FirstName, "Delora");

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
