using IntelligentSortingMechanism.Controllers;
using IntelligentSortingMechanism.Models;
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
            }

            ListController controller = new ListController();
            controller.AddNewList(list, tasks);

            AllListsView lists_view = new AllListsView(user_logged);
            lists_view.Activate();
            lists_view.Show();
            this.Close();
        }

        private void add_task_btn_Click(object sender, RoutedEventArgs e)
        {
            AddTaskView add_task = new AddTaskView(user_logged);
            add_task.Activate();
            add_task.Show();
        }
    }
}
