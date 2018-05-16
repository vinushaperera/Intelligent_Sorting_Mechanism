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
             
    }
}
