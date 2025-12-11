using System;
using System.Data;
using System.Data.SqlClient;


namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class StudnetRepo
    {
        private string connectionString =
            "Data Source=localhost\\SQLEXPRESS;Database=STUDENTS;Integrated Security=True;";

        public void InsertData(Student student)
        {
            string query = "INSERT INTO Students (Roll_Number, Name, Age, Email) " +
                           "VALUES (@Roll_Number, @Name, @Age, @Email);";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Roll_Number", student.Roll_Number);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Email", student.Email);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateStudent(int rollNumber, string name, int age, string email)
        {
            string query = "UPDATE Students SET Name=@Name, Age=@Age, Email=@Email WHERE Roll_Number=@Roll_Number;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Roll_Number", rollNumber);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
            }
        }
        public void DeleteStudent(int rollNumber)
        {
            string query = "DELETE FROM Students WHERE Roll_Number = @Roll_Number;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Roll_Number", rollNumber);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Student deleted successfully.");
                else
                    Console.WriteLine("No student found with that Roll_Number.");
            }
        }

        public void DisplayStudents()
        {
            string query = "SELECT Roll_Number, Name, Age, Email FROM Students;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"Roll_Number: {reader["Roll_Number"]}, " +
                            $"Name: {reader["Name"]}, " +
                            $"Age: {reader["Age"]}, " +
                            $"Email: {reader["Email"]}"
                        );
                    }
                }
            }
        }
    }
}
