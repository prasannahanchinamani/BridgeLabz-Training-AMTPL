using System;
using System.Data.SqlClient;

namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class EmployeeRepo
    {
        // Connection to empdb
        private string connectionString =
            "Data Source=localhost\\SQLEXPRESS;Database=empdb;Integrated Security=True;";

        // ONLY RUN ONCE → creates table
        public void CreateTable()
        {
            string query = "CREATE TABLE Employee (" +
                           "Id INT PRIMARY KEY, " +
                           "Name VARCHAR(50) NOT NULL, " +
                           "Dept VARCHAR(100) NOT NULL);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created.");
            }
        }

        // INSERT
        public void InsertEmployee(Employee employee)
        {
            string query = "INSERT INTO Employee (Id, Name, Dept) VALUES (@id, @Name, @dept)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", employee.Id);
                cmd.Parameters.AddWithValue("@Name", employee.Name);
                cmd.Parameters.AddWithValue("@dept", employee.Dept);

                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee inserted.");
            }
        }

        // UPDATE
        public void UpdateEmployee(int id, string name, string dept)
        {
            string query = "UPDATE Employee SET Name=@Name, Dept=@dept WHERE Id=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@dept", dept);

                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee updated.");
            }
        }

        // DELETE
        public void DeleteEmployee(int id)
        {
            string query = "DELETE FROM Employee WHERE Id=@id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee deleted.");
            }
        }
    }
}
