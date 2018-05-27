using IntelligentSortingMechanism.Controllers;
using IntelligentSortingMechanism.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class NewListView : Window
    {

        #region Variables and Properties

        private UserModel user_logged = new UserModel();
        private ListModel list;
        private static ObservableCollection<TaskModel> tasks;

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
            //Check if there are enough items
            
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
}
