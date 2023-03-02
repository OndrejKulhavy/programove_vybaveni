using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Conection
{
    class Database
    {
        SqlConnectionStringBuilder consStringBuilder;

        public Database()
        {
            consStringBuilder = new SqlConnectionStringBuilder();
            consStringBuilder.DataSource = "localhost";
            consStringBuilder.IntegratedSecurity = true;
            consStringBuilder.InitialCatalog = "test";
            consStringBuilder.ConnectTimeout = 30;
            consStringBuilder.MultipleActiveResultSets = true;
            consStringBuilder.Encrypt = false;
            consStringBuilder.TrustServerCertificate = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Pripojeno");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //vlozeni dat do tabulky
        public void InsertData(string text)
        {
            using (SqlConnection connection = new SqlConnection(consStringBuilder.ConnectionString))
            {
                connection.Open();
                string query = "insert into Table (text) values (@text)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@text", text);
                    command.ExecuteNonQuery();
                }
            }
        }

        //nacteni dat z tabulky
        public void ReadData()
        {

            string query = "select * from Table";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
                }
            }

        }
    }
}
