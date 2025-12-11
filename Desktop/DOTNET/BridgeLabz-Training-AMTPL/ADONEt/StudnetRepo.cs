using Azure.Core;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class StudnetRepo
    {
        //private static string connectionString = "Server=.;Database=STUDENTS;Integrated Security=True;";
        private static string connectionString ="Server=localhost\\SQLEXPRESS;Database=STUDENTS;Integrated Security=True;";

        public static void CreateTable()
        {
            string createQuery = @"
                CREATE TABLE STUDENT(
                    Id INT PRIMARY KEY,
                    Name VARCHAR(30) NOT NULL,
                    Email VARCHAR(30) NOT NULL
                );";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(createQuery,conn)){
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table is Created");
            }
        }
        public static void InsertValues(Student student)
        {
            string insertQuery = "Insert into STUDENT (id,name,email) values(@Id,@name,@Email)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@name",student.Name);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                conn.Open ();
                cmd.ExecuteReader();
                Console.WriteLine("Inserted Values");
            }
        }
        public static void UpdateValues(int id, string name, string email)
        {
            string updateQuery = @"UPDATE STUDENT
                           SET Name = @Name,
                               Email = @Email
                           WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name",name);
                cmd.Parameters.AddWithValue("@Email",email);
                conn.Open();
                int rows = cmd.ExecuteNonQuery(); 
                Console.WriteLine($"{rows} row(s) updated.");
            }
        }
        public static void DeleteValues(int id)
        {
            string deleteQuery = "Delete from Student where id=@id";
           
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine($"{rows} row(s) updated.");
            }
        }
        public static void DisplayStudents()
        {
            string query = "SELECT * FROM STUDENT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(
                        dr["Id"] + "  " +
                        dr["Name"] + "  " +
                        dr["Email"]);
                }
            }
        }

    }
}
