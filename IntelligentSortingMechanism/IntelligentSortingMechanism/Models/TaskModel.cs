using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSortingMechanism.Models
{
    public class TaskModel
    {
        private int task_id;
        private string task_desc;
        private DateTime task_deadline;
        private int task_priority;
        private string task_link_id;
        private int task_list_id;
        private int task_sorted_order;
        private int task_front;


        public int Task_id
        {
            get
            {
                return task_id;
            }
            set
            {
                this.task_id = value;
            }
        }

        public string Task_desc
        {
            get
            {
                return task_desc;
            }
            set
            {
                this.task_desc = value;
            }
        }

        public DateTime Task_deadline
        {
            get
            {
                return task_deadline;
            }
            set
            {
                this.task_deadline = value;
            }
        }

        public int Task_priority
        {
            get
            {
                return task_priority;
            }
            set
            {
                this.task_priority = value;
            }
        }

        public string Task_link_id
        {
            get
            {
                return task_link_id;
            }
            set
            {
                this.task_link_id = value;
            }
        }

        public int Task_list_id
        {
            get
            {
                return task_list_id;
            }
            set
            {
                this.task_list_id = value;
            }
        }

        public int Task_sorted_order
        {
            get
            {
                return task_sorted_order;
            }
            set
            {
                this.task_sorted_order = value;
            }
        }

        public int Task_front
        {
            get
            {
                return task_front;
            }
            set
            {
                this.task_front = value;
            }
        }

    }
}
