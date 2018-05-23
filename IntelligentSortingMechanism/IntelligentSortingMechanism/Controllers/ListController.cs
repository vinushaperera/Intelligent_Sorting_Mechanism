using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentSortingMechanism.Models;
using System.Collections.ObjectModel;

namespace IntelligentSortingMechanism.Controllers
{
    public class ListController
    {
        public void AddNewList(ListModel list, ObservableCollection<TaskModel> tasks)
        {
            ListModel list_model = new ListModel();
            TaskModel task_model = new TaskModel();

            int list_status = list_model.InsertList(list.List_name, list.List_user_id, list.List_fronts, true);

            if(list_status != 0)
            {
                int list_id = list_model.GetListId();
                list_model.UpdateList(list_id, list.List_name, list.List_user_id, list.List_fronts, false);

                foreach (TaskModel item in tasks)
                {
                    string deadline = item.Task_deadline.ToString();
                    task_model.InsertTask(item.Task_desc, deadline, item.Task_priority, item.Task_link_id, list_id, item.Task_sorted_order, item.Task_front);
                }
            }
        }

        public bool DeleteList(int list_id)
        {
            ListModel list = new ListModel();
            int result = list.DeleteList(list_id);

            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<TaskModel> GetTasks(int list_id)
        {
            TaskModel task = new TaskModel();
            List<TaskModel> list = task.GetAllListTasks(list_id);

            return list;
        }

        public void SaveSortedList(ListModel list, List<TaskModel> tasks)
        {
            ListModel list_model = new ListModel();
            TaskModel task_model = new TaskModel();

            if(tasks.Count == 0 || list == null)
            {
                return;
            }
            else
            {
                int status = list_model.UpdateList(list.List_id, list.List_name, list.List_user_id, list.List_fronts, list.New_List);

                foreach (var item in tasks)
                {
                    string deadline = item.Task_deadline.ToString();
                    task_model.UpdateTask(item.Task_id, item.Task_desc, deadline, item.Task_priority, item.Task_link_id, item.Task_list_id, item.Task_sorted_order, item.Task_front);
                }

            }
        }

        
    }
}
