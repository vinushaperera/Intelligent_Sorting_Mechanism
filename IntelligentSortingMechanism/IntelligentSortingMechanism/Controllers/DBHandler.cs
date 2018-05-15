using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace IntelligentSortingMechanism.Controllers
{
    public class DBHandler
    {
        private string connString = "Server=localhost;Database=sorting;Uid=root;Pwd=;SslMode=none;";       
        

        public MySqlConnection ConnectDB()
        {           
            MySqlConnection dbConnection = new MySqlConnection(connString);
            dbConnection.Open();

            return dbConnection;
        }

        public void CloseDB(MySqlConnection dbConnection)
        {
            if (dbConnection.State == System.Data.ConnectionState.Open)
            {
                dbConnection.Close();
            }
        }



        public void ConnectDB1()
        {
            MySqlConnection dbConnection = new MySqlConnection(connString);
            dbConnection.Open();

            MySqlCommand cmd;

            try
            {
                cmd = dbConnection.CreateCommand();
                cmd.CommandText = "INSERT INTO user(f_name, l_name, email, password) VALUES(@f_name, @l_name, @email, @password)";
                cmd.Parameters.AddWithValue("@f_name", "Vinusha");
                cmd.Parameters.AddWithValue("@l_name", "Perera");
                cmd.Parameters.AddWithValue("@email", "test@gmail.com");
                cmd.Parameters.AddWithValue("@password", "123");

                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                if(dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }

            //return dbConnection;
        }

        


    }
}
