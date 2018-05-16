using IntelligentSortingMechanism.Controllers;
using MySql.Data.MySqlClient;
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


        public int InsertTask(string task_desc, string task_deadline, int task_priority, string task_link_id, int task_list_id, int task_sorted_order, int task_front)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO tasks(task_desc, task_deadline, task_priority, task_link_id, task_list_id, task_sorted_order, task_front) VALUES(@task_desc, @task_deadline, @task_priority, @task_link_id, @task_list_id, @task_sorted_order, @task_front)";
                cmd.Parameters.AddWithValue("@task_desc", task_desc);
                cmd.Parameters.AddWithValue("@task_deadline", task_deadline);
                cmd.Parameters.AddWithValue("@task_priority", task_priority);
                cmd.Parameters.AddWithValue("@task_link_id", task_link_id);
                cmd.Parameters.AddWithValue("@task_list_id", task_list_id);
                cmd.Parameters.AddWithValue("@task_sorted_order", task_sorted_order);
                cmd.Parameters.AddWithValue("@task_front", task_front);

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

        public int UpdateTask(int task_id, string task_desc, string task_deadline, int task_priority, string task_link_id, int task_list_id, int task_sorted_order, int task_front)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE tasks SET task_desc=@task_desc, task_deadline=@task_deadline, task_priority=@task_priority, task_link_id=@task_link_id, task_list_id=@task_list_id, task_sorted_order=@task_sorted_order, task_front=@task_front WHERE task_id=@task_id";
                cmd.Parameters.AddWithValue("@task_desc", task_desc);
                cmd.Parameters.AddWithValue("@task_deadline", task_deadline);
                cmd.Parameters.AddWithValue("@task_priority", task_priority);
                cmd.Parameters.AddWithValue("@task_link_id", task_link_id);
                cmd.Parameters.AddWithValue("@task_list_id", task_list_id);
                cmd.Parameters.AddWithValue("@task_sorted_order", task_sorted_order);
                cmd.Parameters.AddWithValue("@task_front", task_front);
                cmd.Parameters.AddWithValue("@task_id", task_id);

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

        public int DeleteTask(int task_id)
        {
            DBHandler db = new DBHandler();
            MySqlConnection connection = db.ConnectDB();
            int results = 0;
            MySqlCommand cmd;

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM tasks WHERE task_id=@task_id";
                cmd.Parameters.AddWithValue("@task_id", task_id);

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
