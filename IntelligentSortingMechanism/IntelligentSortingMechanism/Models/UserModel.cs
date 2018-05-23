using IntelligentSortingMechanism.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSortingMechanism.Models
{
    public class UserModel
    {
        private int user_id;
        private string user_f_name;
        private string user_l_name;
        private string user_email;
        private string user_password;
        private bool user_logged_in;
        
        public UserModel()
        {

        }

        public UserModel(int user_id, string user_f_name, string user_l_name, string user_email, string user_password, bool user_logged_in)
        {
            this.user_id = user_id;
            this.user_f_name = user_f_name;
            this.user_l_name = user_l_name;
            this.user_email = user_email;
            this.user_password = user_password;
            this.user_logged_in = user_logged_in;
        }

        public int User_id
        {
            get
            {
                return user_id;
            }
            set
            {
                this.user_id = value;
            }
        }

        public string User_f_name
        {
            get
            {
                return user_f_name;
            }
            set
            {
                this.user_f_name = value;
            }
        }

        public string User_l_name
        {
            get
            {
                return user_l_name;
            }
            set
            {
                this.user_l_name = value;
            }
        }

        public string User_email
        {
            get
            {
                return user_email;
            }
            set
            {
                this.user_email = value;
            }
        }

        public string User_password
        {
            get
            {
                return user_password;
            }
            set
            {
                this.user_password = value;
            }
        }

        public bool User_Logged_In
        {
            get
            {
                return this.user_logged_in;
            }
            set
            {
                this.user_logged_in = value;
            }
        }

        public UserModel GetLoginUser(string email, string password)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            MySqlCommand cmd;

            UserModel user = new UserModel();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM user WHERE email=@email AND password=@password";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    user.user_logged_in = false;
                }

                while (reader.Read())
                {
                    int user_id = (int)reader["user_id"];
                    string f_name = (string)reader["f_name"];
                    string l_name = (string)reader["l_name"];
                    string email_user = (string)reader["email"];
                    string password_user = (string)reader["password"];

                    user = new UserModel(user_id, f_name, l_name, email_user, password_user, true);             
                }

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

            return user;
            
        }

    }
}
