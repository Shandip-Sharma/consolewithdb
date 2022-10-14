using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace consolewithdb
{
    internal class day4
    {
       
        private static string _connStr = "Data Source=DESKTOP-OGJDEFM\\SQLEXPRESS;Initial Catalog=sand_db;Integrated Security=True";
   
        internal void CheckConnection()
        {
            using (SqlConnection conn=new SqlConnection(_connStr))
            {
                conn.Open();

                Console.WriteLine("Connection has been established !!");

                conn.Close();
            }

        }
        internal void CreateTable()
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();
          
            
            SqlCommand cmd = new SqlCommand(_connStr,conn);
            cmd.CommandText =
                @"
                    CREATE TABLE tbl_Per (
                        id INTEGER NOT NULL PRIMARY KEY identity(1,1),
                        name varchar(30) NOT NULL
                    );
                    INSERT INTO tbl_Per
                    VALUES ( 'sandip'),
                           ( 'bibek'),
                           ( 'sanam');               
                       
                 ";

            cmd.ExecuteNonQuery();

            conn.Close();

            Console.WriteLine($"\nTable [tbl_Per] created with 3 records");
        }
        internal void InsertData(string username)
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();

            SqlCommand cmd = new SqlCommand(_connStr, conn);
            cmd.CommandText =
                @"
                    INSERT INTO tbl_Person (name)
                    VALUES (@name)
                ";
            cmd.Parameters.AddWithValue("@name", username);
            cmd.ExecuteNonQuery();

            conn.Close();

            Console.WriteLine($"\n Added {username} to the tbl_Person.");
        }
        internal void GetData()
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, name FROM tbl_Person";

            using var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("\nShowing records from the tbl_Person.");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetInt32(0)}. {reader.GetString(1)}");
                }
            }
            else Console.WriteLine("\nNo row(s) returned.");

            conn.Close();
        }
        internal void updateDate()
        {

            using var conn = new SqlConnection(_connStr);
            conn.Open();
            int person_id;
            string person_Name;
            Console.WriteLine(  "enter the person id that you would like to update");
            person_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the person Name");
            person_Name = Console.ReadLine();
      
            string updatequery = "update tbl_Person SET name='"+person_Name+ "' WHERE id='"+person_id+"'";
            SqlCommand cmd = new SqlCommand(updatequery,conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("data has been updated");
            conn.Close();
        }
      
    }
}
