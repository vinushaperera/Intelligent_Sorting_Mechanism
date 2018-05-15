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
    }
}
