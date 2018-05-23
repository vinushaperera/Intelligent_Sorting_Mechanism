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
    }
}
