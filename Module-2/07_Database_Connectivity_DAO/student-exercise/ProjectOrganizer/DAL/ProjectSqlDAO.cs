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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an employee from a project.
        /// </summary>
        /// <param name="projectId">The project's id.</param>
        /// <param name="employeeId">The employee's id.</param>
        /// <returns>If it was successful.</returns>
        public bool RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new project.
        /// </summary>
        /// <param name="newProject">The new project object.</param>
        /// <returns>The new id of the project.</returns>
        public int CreateProject(Project newProject)
        {
            throw new NotImplementedException();
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
