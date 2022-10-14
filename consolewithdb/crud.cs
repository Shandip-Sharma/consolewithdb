using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Net;

namespace consolewithdb
{
    internal class crud
    {
        public static string _connStr = "Data Source=DESKTOP-OGJDEFM\\SQLEXPRESS;Initial Catalog=db_sandip;Integrated Security=True";

        SqlConnection conn = new SqlConnection(_connStr);
        internal void create_table()
        {
            conn = new SqlConnection(_connStr);
            conn.Open();

            var cmd = conn.CreateCommand();
         cmd.CommandText = @"create table tbl_work(
               emp_Id int  not null primary key identity(1,1),
             emp_Name varchar(30) not null,
             emp_Address varchar(30) not null );
            ";
     
            cmd.ExecuteNonQuery();
            Console.WriteLine($"table [tbl_work ] has been create sucessfully !!");
                
            conn.Close();
      

        }
        /*  internal void insert_data(string emp_Name,string address)
          {
              conn = new SqlConnection(_connStr);
              conn.Open();
              var cmd = conn.CreateCommand();
              cmd.CommandText = "insert into tbl_work (emp_ID,emp_Name,emp_Address) values (@emp_ID,@emp_Name,@emp_Address)";
              cmd.Parameters.AddWithValue("@emp_Name", emp_Name);
             cmd.Parameters.AddWithValue("@emp_Address", address);
              cmd.ExecuteNonQuery();
              Console.WriteLine("data is inserted");
              conn.Close();
          } 
        */
        internal void insertdata()
        {
            conn = new SqlConnection(_connStr);
            conn.Open();
           
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("enter the Address");
            string Address = Console.ReadLine();
 string insertquery = "insert into tbl_work (emp_Name,emp_Address) values ('"+name+"','"+Address+"')";
            SqlCommand cmd = new SqlCommand(insertquery,conn);
            cmd.ExecuteNonQuery();
            conn.Close();

           
        }
        internal void showdata()
        {
            conn = new SqlConnection(_connStr);
            conn.Open();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tbl_work";

           using var dataReader= cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                Console.WriteLine("\nShowing records from the  table tbl_worker.");
                while (dataReader.Read())
                {
                    Console.WriteLine($"{dataReader.GetInt32(0)}. {dataReader.GetString(1)}.{dataReader.GetString(2)}");
                }
            }
            else Console.WriteLine("\nNo row(s) returned.");

            conn.Close();
        }
        internal void updateDate()
        {

            using var conn = new SqlConnection(_connStr);
            conn.Open();
           
            Console.WriteLine("enter the  id that you would like to update");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the  Name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter the Address");
            string Address = Console.ReadLine();

            string updatequery = "update tbl_work SET emp_Name='" + Name + "', emp_Address='"+ Address + "' WHERE emp_Id='" + id +"'";
            SqlCommand cmd = new SqlCommand(updatequery, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("data has been updated");
            conn.Close();
        }
        internal void deletedata()
        {
            conn = new SqlConnection(_connStr);
            conn.Open();
            Console.WriteLine("enter the  id whose data is to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            string deletequery = "delete from tbl_work where emp_Id='"+ id + "'";
            SqlCommand cmd = new SqlCommand(deletequery, conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine($"Data with Id={id} has been deleted");
            conn.Close();

        }
    }

}

