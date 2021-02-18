using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class EmployeeSqlDAO : IEmployeeDAO
    {
        private const string SQL_GET_ALL_EMPLOYEES = "SELECT * FROM Employee";
        private const string SQL_GET_EMPLOYEE_BY_FIRST_AND_LAST_NAME = "SELECT * FROM employee WHERE first_name LIKE '%' + @fname + '%' AND last_name LIKE '%' + @lname + '%'";
        private const string SQL_GET_EMPLOYEE_WITHOUT_PROJECT = "SELECT * FROM employee WHERE employee_id NOT IN (SELECT distinct employee_id FROM project_employee)";
        private string connectionString;

        // Single Parameter Constructor
        public EmployeeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the employees.
        /// </summary>
        /// <returns>A list of all employees.</returns>
        public IList<Employee> GetAllEmployees()
        {
            try
            {
                IList<Employee> emp = new List<Employee>();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_GET_ALL_EMPLOYEES, conn);

                    
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = RowToObject(rdr);
                        emp.Add(employee);
                    }
                }
                return emp;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        private static Employee RowToObject(SqlDataReader rdr)
        {
            Employee employee = new Employee();
            employee.EmployeeId = Convert.ToInt32(rdr["employee_id"]);
            employee.DepartmentId = Convert.ToInt32(rdr["department_id"]);
            employee.FirstName = Convert.ToString(rdr["first_name"]);
            employee.LastName = Convert.ToString(rdr["last_name"]);
            employee.JobTitle = Convert.ToString(rdr["job_title"]);
            employee.BirthDate = Convert.ToDateTime(rdr["birth_date"]);
            employee.Gender = Convert.ToString(rdr["gender"]);
            employee.HireDate = Convert.ToDateTime(rdr["hire_date"]);
            return employee;
        }

        /// <summary>
        /// Find all employees whose names contain the search strings.
        /// Returned employees names must contain *both* first and last names.
        /// </summary>
        /// <remarks>Be sure to use LIKE for proper search matching.</remarks>
        /// <param name="firstname">The string to search for in the first_name field</param>
        /// <param name="lastname">The string to search for in the last_name field</param>
        /// <returns>A list of employees that matches the search.</returns>
        public IList<Employee> Search(string firstname, string lastname)
        {
            try
            {
                IList<Employee> emp = new List<Employee>();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GET_EMPLOYEE_BY_FIRST_AND_LAST_NAME, conn);
                    cmd.Parameters.AddWithValue("@fname", firstname);
                    cmd.Parameters.AddWithValue("@lname", lastname);


                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = RowToObject(rdr);
                        emp.Add(employee);
                    }
                }
                return emp;
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Gets a list of employees who are not assigned to any active projects.
        /// </summary>
        /// <returns></returns>
        public IList<Employee> GetEmployeesWithoutProjects()
        {
            try
            {
                IList<Employee> emp = new List<Employee>();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GET_EMPLOYEE_WITHOUT_PROJECT, conn);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = RowToObject(rdr);
                        emp.Add(employee);
                    }
                }
                return emp;
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}
