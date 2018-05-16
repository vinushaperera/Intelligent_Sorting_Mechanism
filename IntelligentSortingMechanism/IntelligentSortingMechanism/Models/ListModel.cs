using IntelligentSortingMechanism.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSortingMechanism.Models
{
    public class ListModel
    {
        private int list_id;
        private string list_name;
        private int list_user_id;
        private int list_fronts;

        public int List_id
        {
            get
            {
                return list_id;
            }
            set
            {
                this.list_id = value;
            }
        }

        public string List_name
        {
            get
            {
                return list_name;
            }
            set
            {
                this.list_name = value;
            }
        }

        public int List_user_id
        {
            get
            {
                return list_user_id;
            }
            set
            {
                this.list_user_id = value;
            }
        }

        public int List_fronts
        {
            get
            {
                return list_fronts;
            }
            set
            {
                this.list_fronts = value;
            }
        }



        public int InsertList(string list_name, int list_user_id, int list_fronts)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO lists(list_name, list_user_id, list_fronts) VALUES(@list_name, @list_user_id, @list_fronts)";
                cmd.Parameters.AddWithValue("@list_name", list_name);
                cmd.Parameters.AddWithValue("@list_user_id", list_user_id);
                cmd.Parameters.AddWithValue("@list_fronts", list_fronts);

                results = cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    db.CloseDB(connection);
                }
            }

            return results;
        }

        public int UpdateList(int list_id, string list_name, int list_user_id, int list_fronts)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE lists SET list_name=@list_name, list_user_id=@list_user_id, list_fronts=@list_fronts WHERE list_id=@list_id";
                cmd.Parameters.AddWithValue("@list_name", list_name);
                cmd.Parameters.AddWithValue("@list_user_id", list_user_id);
                cmd.Parameters.AddWithValue("@list_fronts", list_fronts);
                cmd.Parameters.AddWithValue("@list_id", list_id);

                results = cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    db.CloseDB(connection);
                }
            }

            return results;
        }

        public int DeleteList(int list_id)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM lists WHERE list_id=@list_id";
                cmd.Parameters.AddWithValue("@list_id", list_id);

                results = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException());
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    db.CloseDB(connection);
                }
            }

            return results;
        }
    }
}
