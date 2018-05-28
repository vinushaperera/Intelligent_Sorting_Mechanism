using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentSortingMechanism.Models;
using System.Collections.ObjectModel;
using Excel = Microsoft.Office.Interop.Excel;

namespace IntelligentSortingMechanism.Controllers
{
    public class ListController
    {

        #region Variables and Properties

        private Excel.Application excel_app = null;
        private Excel.Workbook excel_workbook = null;
        private Excel.Worksheet excel_woksheet = null;

        #endregion

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

        public bool EditList(ListModel list)
        {
            ListModel db_list = new ListModel();
            int status = db_list.UpdateList(list.List_id, list.List_name, list.List_user_id, list.List_fronts, list.New_List);

            if(status != 0)
            {
                return true;
            }
            else
            {
                return false;
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

        public bool EditTask(TaskModel task)
        {
            TaskModel db_task = new TaskModel();
            string deadline = task.Task_deadline.ToString();

            int status = db_task.UpdateTask(task.Task_id, task.Task_desc, deadline, task.Task_priority, task.Task_link_id, task.Task_list_id, task.Task_sorted_order, task.Task_front);

            if (status != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTask(int task_id)
        {
            TaskModel task = new TaskModel();
            int result = task.DeleteTask(task_id);

            if (result > 0)
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

        public List<TaskModel> ReadExcelFile(string filepath)
        {
            excel_app = new Excel.Application();
            excel_app.Visible = false;
            excel_workbook = excel_app.Workbooks.Open(filepath);
            excel_woksheet = (Excel.Worksheet)excel_workbook.Sheets[1];

            List<string> priority_txt_list = new List<string>();
            List<TaskModel> tasks_list = new List<TaskModel>();         

            int last_row = excel_woksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

            if(last_row != 1)
            {
                Array arr = excel_woksheet.get_Range("A1", "D1").Cells.Value;

                string column1 = arr.GetValue(1, 1).ToString();
                string column2 = arr.GetValue(1, 2).ToString();
                string column3 = arr.GetValue(1, 3).ToString();
                string column4 = arr.GetValue(1, 4).ToString();

                if (column1.ToUpper().Equals("LINK ID") && column2.ToUpper().Equals("DESCRIPTION") && column3.ToUpper().Equals("PRIORITY") && column4.ToUpper().Equals("DEADLINE"))
                {
                    for (int count = 2; count <= last_row; count++)
                    {
                        Array row_values = excel_woksheet.get_Range("A" + count.ToString(), "D" + count.ToString()).Cells.Value;

                        TaskModel task = new TaskModel();
                        task.Task_link_id = row_values.GetValue(1, 1).ToString();
                        task.Task_desc = row_values.GetValue(1, 2).ToString();                        

                        int priority = 0;
                        bool isNumberPriority = int.TryParse(row_values.GetValue(1, 3).ToString(), out priority);

                        if (isNumberPriority)
                        {
                            task.Task_priority = priority;
                        }
                        else
                        {
                            task.Priority_Txt = row_values.GetValue(1, 3).ToString();

                            if(priority_txt_list.Count != 0)
                            {
                                string import_priority = row_values.GetValue(1, 3).ToString().ToUpper();

                                bool notAvailable = priority_txt_list.Contains(import_priority);
                                
                                if (!notAvailable)
                                {
                                    priority_txt_list.Add(import_priority);
                                }
                            }
                            else
                            {
                                priority_txt_list.Add(row_values.GetValue(1, 3).ToString().ToUpper());
                            }

                            switch(row_values.GetValue(1, 3).ToString().ToUpper())
                            {
                                case "LOW":
                                    task.Task_priority = 4;
                                    break;
                                case "MEDIUM":
                                    task.Task_priority = 3;
                                    break;
                                case "HIGH":
                                    task.Task_priority = 2;
                                    break;
                                case "EXTREME":
                                    task.Task_priority = 1;
                                    break;
                            }
                            
                        }

                        DateTime date = new DateTime();
                        bool correctDateFormat = DateTime.TryParse(row_values.GetValue(1, 4).ToString(), out date);

                        if (correctDateFormat)
                        {
                            task.Task_deadline = date;
                        }
                        else
                        {
                            //Throw an error
                        }

                        tasks_list.Add(task);
                    }
                }                
            }
            excel_workbook.Close();
            return tasks_list;


        }

        public void WriteExcel(List<TaskModel> task_list, string path, string list_name)
        {
            excel_app = new Excel.Application();
            excel_app.Visible = false;
            excel_workbook = excel_app.Workbooks.Add();
            excel_woksheet = (Excel.Worksheet)excel_workbook.Sheets[1];

            excel_woksheet.Cells[1, 1] = "Link ID";
            excel_woksheet.Cells[1, 2] = "Description";
            excel_woksheet.Cells[1, 3] = "Priority";
            excel_woksheet.Cells[1, 4] = "Deadline";

            int current_row = 2;

            foreach (var item in task_list)
            {
                excel_woksheet.Cells[current_row, 1] = item.Task_link_id;
                excel_woksheet.Cells[current_row, 2] = item.Task_desc;

                switch (item.Task_priority)
                {
                    case 1:
                        excel_woksheet.Cells[current_row, 3] = "Extreme";
                        break;
                    case 2:
                        excel_woksheet.Cells[current_row, 3] = "High";
                        break;
                    case 3:
                        excel_woksheet.Cells[current_row, 3] = "Medium";
                        break;
                    case 4:
                        excel_woksheet.Cells[current_row, 3] = "Low";
                        break;
                }

                excel_woksheet.Cells[current_row, 4] = item.Task_deadline.ToString();

                current_row++;
                
            }
            
            excel_workbook.SaveAs(path + "/" + list_name + ".xlsx");
            excel_workbook.Close();
        }
    }
}
