using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class DepartmentSqlDAO : IDepartmentDAO
    {
        private const string SQL_GET_ALL_DEPARTMENTS = "SELECT * FROM department";
        private const string SQL_CREATE_NEW_DEPARTMENT = "INSERT INTO department (name) VALUES (@name)";
        private const string SQL_UPDATE_DEPARTMENT = "UPDATE department set name = @newname WHERE department_id = @deptId";
        private string connectionString;

        // Single Parameter Constructor
        public DepartmentSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns a list of all of the departments.
        /// </summary>
        /// <returns></returns>
        public IList<Department> GetDepartments()
        {
            IList<Department> departments = new List<Department>();
            try
            {

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GET_ALL_DEPARTMENTS, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while(rdr.Read())
                    {
                        Department dept = RowToObject(rdr);
                        departments.Add(dept);
                    }
                }


            }
            catch (SqlException ex)
            {
                throw;
            }
            return departments;
        }

        private static Department RowToObject(SqlDataReader rdr)
        {
            Department dept = new Department();
            dept.Id = Convert.ToInt32(rdr["department_id"]);
            dept.Name = Convert.ToString(rdr["name"]);
            return dept;
        }

        /// <summary>
        /// Creates a new department.
        /// </summary>
        /// <param name="newDepartment">The department object.</param>
        /// <returns>The id of the new department (if successful).</returns>
        public int CreateDepartment(Department newDepartment)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_CREATE_NEW_DEPARTMENT, conn);
                    cmd.Parameters.AddWithValue("@name", newDepartment.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;

                }


            }
            catch (SqlException ex)
            {
                throw;
            }

        }
        
        /// <summary>
        /// Updates an existing department.
        /// </summary>
        /// <param name="updatedDepartment">The department object.</param>
        /// <returns>True, if successful.</returns>
        public bool UpdateDepartment(Department updatedDepartment)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_UPDATE_DEPARTMENT, conn);
                    cmd.Parameters.AddWithValue("@newname", updatedDepartment.Name);
                    cmd.Parameters.AddWithValue("@deptId", updatedDepartment.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }    
                }


            }
            catch (SqlException ex)
            {
                throw;
            }
        }

    }
}
