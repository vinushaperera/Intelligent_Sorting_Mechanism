using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSortingMechanism.Models
{
    public class FrontModel
    {
        private int front_id;
        private List<TaskModel> front_tasks;

        public int Front_Id
        {
            get
            {
                return front_id;
            }
            set
            {
                this.front_id = value;
            }
        }

        public List<TaskModel> Front_Tasks
        {
            get
            {
                return front_tasks;
            }
            set
            {
                this.front_tasks = value;
            }
        }
    }
}
