using ProjectOrganizer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganizer.DAL
{
    public class ProjectSqlDAO : IProjectDAO
    {
        private const string SQL_GET_ALL_EMPLOYEES = "SELECT * FROM project";
        private const string SQL_ADD_EMPLOYEE_TO_PROJECT = "INSERT INTO project_employee (project_id, employee_id) VALUES (@projId, @empId)";
        private const string SQL_REMOVE_EMPLOYEE_FROM_PROJECT = "DELETE FROM project_employee WHERE project_id = @projId AND employee_id = @empId";
        private const string SQL_ADD_NEW_PROJECT = "INSERT INTO project (name,from_date,to_date) VALUES (@name, @from_date, @to_date); SELECT @@IDENTITY";
        private string connectionString;

        // Single Parameter Constructor
        public ProjectSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        /// <summary>
        /// Returns all projects.
        /// </summary>
        /// <returns></returns>
        public IList<Project> GetAllProjects()
        {
            IList<Project> projects = new List<Project>();
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_GET_ALL_EMPLOYEES, conn);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while(rdr.Read())
                    {
                        Project project = RowToObject(rdr);
                        projects.Add(project);

                    }    
                }
                return projects;
            }
            catch (SqlException)
            {
                throw;
            }

        }

        /// <summary>
        /// Assigns an employee to a project using their IDs.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool AssignEmployeeToProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_ADD_EMPLOYEE_TO_PROJECT, conn);
                    cmd.Parameters.AddWithValue("@projId", projectId);
                    cmd.Parameters.AddWithValue("@empId" , employeeId);

                    int newId = cmd.ExecuteNonQuery();
                    if (newId > 0)
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
                //log
                throw;
            }
        }

        /// <summary>
        /// Removes an employee from a project.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_REMOVE_EMPLOYEE_FROM_PROJECT, conn);
                    cmd.Parameters.AddWithValue("@projId", projectId);
                    cmd.Parameters.AddWithValue("@empId", employeeId);

                    int newId = cmd.ExecuteNonQuery();
                    if (newId > 0)
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
                //log
                throw;
            }
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="newProject">The new project object.</param>
        /// <returns>The new id of the project.</returns>
        public int CreateProject(Project newProject)
        {
            try
            {
                
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_ADD_NEW_PROJECT, conn);
                    cmd.Parameters.AddWithValue("@name", newProject.Name);
                    cmd.Parameters.AddWithValue("@from_date", newProject.StartDate);
                    cmd.Parameters.AddWithValue("@to_date", newProject.EndDate);

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    return newId;

                }
            }
            catch (SqlException ex)
            {
                //LOG
                throw;
            }
        }

        private static Project RowToObject(SqlDataReader reader)
        {
            Project projects = new Project();
            projects.ProjectId = Convert.ToInt32(reader["project_id"]);
            projects.Name = Convert.ToString(reader["name"]);
            projects.StartDate = Convert.ToDateTime(reader["from_date"]);
            projects.EndDate = Convert.ToDateTime(reader["to_date"]);
            return projects;


        }

    }
}
