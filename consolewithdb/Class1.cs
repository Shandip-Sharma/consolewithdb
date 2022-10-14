using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace consolewithdb
{
    internal class Class1
    {
        static string sqlconstrng = "Data Source=DESKTOP-OGJDEFM\\SQLEXPRESS;Initial Catalog=db_sandip;Integrated Security=True";
        internal void checkconnection()
        {
            using (SqlConnection conn = new SqlConnection(sqlconstrng))
            {
                conn.Open();
                Console.WriteLine("connection has been established");
                conn.Close();
            }
        }
        internal void createtable()
        {
            SqlConnection conn = new SqlConnection(sqlconstrng);
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                create table tbl_good(
                Product_id int not null primary key identity(1,1),
                    Product_name varchar(50) not null,
                    manufactured_date date not null
                );";
            cmd.ExecuteNonQuery();
            Console.WriteLine($"table [tbl_book] is created");
            conn.Close();
        }
        internal void insert_data()
        {
            SqlConnection conn = new SqlConnection(sqlconstrng);
            conn.Open();
            Console.WriteLine("enter the product name");
            string Product_name = Console.ReadLine();
            Console.WriteLine("enter the manufactured_date");
            string date = Console.ReadLine();
            DateTime manufactured_date = DateTime.Parse(date);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "insert into tbl_good (Product_name,manufactured_date)values (@Product_name,@manufactured_date)";
            cmd.Parameters.AddWithValue("@Product_name", Product_name);
            cmd.Parameters.AddWithValue("@manufactured_date", manufactured_date);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        internal void select_data()
        {
            SqlConnection conn = new SqlConnection(sqlconstrng);
            conn.Open();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tbl_good";
            using var datareader = cmd.ExecuteReader();
            if(datareader.HasRows)
            {
                Console.WriteLine("showing data from table tbl_good");
                while (datareader.Read())
                {
                    Console.WriteLine($"{datareader.GetValue(0)}-{datareader.GetValue(1)}-{datareader.GetValue(2)}");
                }
            }
            else
            {
                Console.WriteLine("/n there is no rows to show");
            }
               
        }
     internal void update()
        {
            SqlConnection conn = new SqlConnection(sqlconstrng);
            conn.Open(); 
            Console.WriteLine("enter the product ID");
            var Product_id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the product name");
            string Product_name = Console.ReadLine();
            Console.WriteLine("enter the manufactured_date");
            string date = Console.ReadLine();
            DateTime manufactured_date = DateTime.Parse(date);
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "update tbl_good set Product_name='" + Product_name + "',manufactured_date='"+ manufactured_date + "' where Product_id='"+ Product_id + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
        }




    }
}
