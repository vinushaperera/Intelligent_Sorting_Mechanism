using IntelligentSortingMechanism.Controllers;
using IntelligentSortingMechanism.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IntelligentSortingMechanism.Views
{
    /// <summary>
    /// Interaction logic for NewListView.xaml
    /// </summary>
    public partial class NewListView : Window, INotifyPropertyChanged
    {

        #region Variables and Properties

        private UserModel user_logged = new UserModel();
        private ListModel list;
        private static ObservableCollection<TaskModel> tasks;
        private string error_txt;

        public string Error_txt
        {
            get
            {
                return error_txt;
            }

            set
            {
                this.error_txt = value;
                OnPropertyChanged("Error_txt");
            }
        }

        public static ObservableCollection<TaskModel> NewTasks
        {
            get
            {
                return tasks;
            }
            set
            {
                tasks = value;
            }
        }

        #endregion

        public NewListView(UserModel user)
        {            
            InitializeComponent();
            this.DataContext = this;
            user_logged = user;

            list = new ListModel();
            tasks = new ObservableCollection<TaskModel>();
        }

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {

            if(tasks.Count <= 2)
            {
                Error_txt = "There should be at least 3 tasks in order to create a list!";
                return;
            }
                        
            if (!string.IsNullOrWhiteSpace(list_name_box.Text))
            {
                list.List_name = list_name_box.Text;
                list.List_user_id = user_logged.User_id;
                list.List_fronts = 0;

                ListController controller = new ListController();
                controller.AddNewList(list, tasks);

                AllListsView lists_view = new AllListsView(user_logged);
                lists_view.Activate();
                lists_view.Show();
                this.Close();
            }
            else
            {
                Error_txt = "List name cannot be empty!";
                return;
            }            
        }

        private void add_task_btn_Click(object sender, RoutedEventArgs e)
        {
            AddTaskView add_task = new AddTaskView(user_logged);
            add_task.Activate();
            add_task.Show();
        }

        private void edit_task_btn_Click(object sender, RoutedEventArgs e)
        {
            TaskModel task = task_list_grid.SelectedItem as TaskModel;

            if(task != null)
            {
                EditTaskView edit_view = new EditTaskView();

                edit_view.DescriptionText = task.Task_desc;
                edit_view.DeadlineText = task.Task_deadline;
                edit_view.PriorityText = task.Priority_Txt;
                edit_view.LinkIDText = task.Task_link_id;

                if (edit_view.ShowDialog() == true)
                {
                    tasks.Remove(task);

                    task.Task_desc = edit_view.DescriptionText;
                    task.Task_deadline = edit_view.DeadlineText;
                    task.Task_priority = Convert.ToInt32(edit_view.PriorityText);
                    task.Task_link_id = edit_view.LinkIDText;


                    tasks.Add(task);
                }
            }
        }

        private void delete_task_btn_Click(object sender, RoutedEventArgs e)
        {
            TaskModel task = task_list_grid.SelectedItem as TaskModel;

            if (task != null)
            {
                int hash_selected = task.GetHashCode();
                TaskModel selectedTask = new TaskModel();
                bool itemFound = false;

                foreach (var item in tasks)
                {
                    int hash_item = item.GetHashCode();

                    if(hash_item == hash_selected)
                    {
                        selectedTask = item;
                        itemFound = true;
                        break;
                    }
                }

                if (itemFound)
                {
                    tasks.Remove(selectedTask);
                }
            }
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            AllListsView all_view = new AllListsView(user_logged);
            all_view.Activate();
            all_view.Show();
            this.Close();
        }

        private void import_list_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openBrowser = new OpenFileDialog();
            openBrowser.Title = "Select the Excel file";
            openBrowser.DefaultExt = "xlsx";
            openBrowser.CheckFileExists = true;
            openBrowser.CheckPathExists = true;
            openBrowser.Multiselect = false;

            string filename = "";

            if (openBrowser.ShowDialog() == true)
            {
                filename = openBrowser.FileName;
            }

            if (!string.IsNullOrWhiteSpace(filename))
            {
                ListController controller = new ListController();
                List<TaskModel> import_list = controller.ReadExcelFile(filename);

                foreach (var item in import_list)
                {
                    item.Task_front = 0;
                    item.Task_list_id = 0;
                    item.Task_sorted_order = 0;
                    tasks.Add(item);
                }
            }            
        }

        #region NotifyProperty

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
