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

        public NewListView()
        {            
            InitializeComponent();
            this.DataContext = this;
            list = new ListModel();
            tasks = new ObservableCollection<TaskModel>();
        }

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {
            //Check if there are enough items
            
            if (!string.IsNullOrWhiteSpace(list_name_box.Text))
            {
                list.List_name = list_name_box.Text;
                list.List_user_id = 0;
                list.List_fronts = 0;
            }

            ListController controller = new ListController();
            controller.AddNewList(list, tasks);
            this.Close();
        }

        private void add_task_btn_Click(object sender, RoutedEventArgs e)
        {
            AddTaskView add_task = new AddTaskView();
            add_task.Activate();
            add_task.Show();
        }
    }
}
