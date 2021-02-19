using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.IO;

namespace ProjectOrganizerTests
{
    [TestClass]
    public class DepartmentSqlDAOTests
    {
        const string connectionString = "Server=.\\SQLExpress;Database=ProjectOrganizerDB_Tests;Trusted_Connection=true;";

        [TestMethod]
        public void TestMethod1()
        {

        }

        public void SetupDB()
        {
            string path = "ProjectOrganizerDBSetup.sql";
            string setupScript = File.ReadAllText(path);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.ExecuteNonQuery();
            }
        }
    }


}
