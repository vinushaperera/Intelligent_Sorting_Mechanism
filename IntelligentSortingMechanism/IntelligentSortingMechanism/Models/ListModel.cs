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
    }
}
