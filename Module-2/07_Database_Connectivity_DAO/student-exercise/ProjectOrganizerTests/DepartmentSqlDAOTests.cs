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
    public class DepartmentSqlDAOTests
    {
        private string connectionString = "Server=.\\SQLExpress;Database=ProjectOrganizerDB_Tests;Trusted_Connection=true;";
        private DepartmentSqlDAO dao;

        [TestInitialize]
        public void RunBeforeEachTest()
        {
            SetupDB();
            this.dao = new DepartmentSqlDAO(connectionString);

        }
        [TestMethod]
        public void GetDepartmentsTest()
        {
            IList<Department> departments;
            departments = dao.GetDepartments();

            Assert.IsNotNull(departments);
            Assert.AreEqual(4, departments.Count);
            Assert.AreEqual("Store Support", departments[3].Name);

        }
        [TestMethod]
        public void CreateDepartmentTest()
        {
            Department newDepartment = new Department()
            {
                Name = "test department"
            };
            int actualResult = dao.CreateDepartment(newDepartment);

            int expectedResult;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(department_id) FROM department", conn);
                expectedResult = Convert.ToInt32(cmd.ExecuteScalar());

            }
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void UpdateDepartmentTest()
        {

            Department department = new Department()
            {
                Name = "NEW test deparment"
            };
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT department_id FROM department WHERE name = 'Network Administration'", conn);
                department.Id = Convert.ToInt32(cmd.ExecuteScalar());
            }


            bool actualResult = dao.UpdateDepartment(department);

            Assert.IsTrue(actualResult);
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
