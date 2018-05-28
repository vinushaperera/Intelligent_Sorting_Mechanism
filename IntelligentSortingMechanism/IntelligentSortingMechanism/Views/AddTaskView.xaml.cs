using IntelligentSortingMechanism.Models;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AddTaskView.xaml
    /// </summary>
    public partial class AddTaskView : Window
    {

        #region Variables and Properties

        private UserModel user_logged = new UserModel();
                
        #endregion

        public AddTaskView(UserModel user)
        {
            InitializeComponent();
            user = user_logged;
        }

        private void add_task_btn_Click(object sender, RoutedEventArgs e)
        {
            TaskModel task = new TaskModel();

            task.Task_desc = task_desc_box.Text;
            task.Task_priority = Convert.ToInt32(task_priority_combo.Text);
            task.Task_deadline = (DateTime)task_deadline_date.SelectedDate;
            task.Task_link_id = link_id_box.Text;

            task.Task_front = 0;            
            task.Task_list_id = 0;
            task.Task_sorted_order = 0;

            NewListView.NewTasks.Add(task);
            this.Close();
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
