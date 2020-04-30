using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace connectToDb
{
    class Program
    {
        static void PrintNames()
        {
            string connectionString = "server=127.0.0.1;port=3306;user id=root;password=katya50648;database=testConnectionSharp";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            DataSet res = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("select * from Test", connection);
            adapter.Fill(res, "Test");
            connection.Close();

            foreach (DataRow row in res.Tables["Test"].Rows)
            {
                Console.WriteLine(Convert.ToString(row["id"]) + Convert.ToString(row["_name"]));
            }
        }
        static void Main(string[] args)
        {
            PrintNames();
            Console.ReadLine();
        }
    }
}
