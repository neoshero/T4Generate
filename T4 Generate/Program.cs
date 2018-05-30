using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            var datatable = new DataTable();
            var conn = ConfigurationManager.AppSettings["NeoConnection"];
            var connection = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select * from member", connection);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datatable);
            connection.Close();

            Console.ReadKey();
        }
    }
}
