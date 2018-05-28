using IntelligentSortingMechanism.Models;
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
    /// Interaction logic for FrontsView.xaml
    /// </summary>
    public partial class FrontsView : Window, INotifyPropertyChanged
    {

        #region Variables and Properties

        UserModel user_logged = new UserModel();
        ListModel viewed_list = new ListModel();
        List<TaskModel> tasks_list = new List<TaskModel>();
        ObservableCollection<TaskModel> grid_tasks = new ObservableCollection<TaskModel>();
        private string selected_front;


        public ObservableCollection<TaskModel> Grid_Tasks
        {
            get
            {
                return grid_tasks;
            }

            set
            {
                this.grid_tasks = value;
            }
        }

        public string Selected_Front
        {
            get
            {
                return selected_front;
            }

            set
            {
                selected_front = value;
                OnPropertyChanged("Selected_Front");
            }
        }

        #endregion

        #region Helper Methods

        public FrontsView(UserModel user, ListModel list, List<TaskModel> tasks)
        {
            InitializeComponent();
            this.DataContext = this;

            user_logged = user;
            viewed_list = list;
            tasks_list = tasks;

            for (int i = 0; i <= viewed_list.List_fronts; i++)
            {
                front_combo.Items.Add(i);
            }

            list_name_header.Text = list.List_name;

            if(viewed_list.List_fronts == 0)
            {
                front_combo.SelectedIndex = 0;
            }
            else if(viewed_list.List_fronts > 0)
            {
                front_combo.SelectedIndex = 1;
            }
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void front_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if((sender as ComboBox).SelectedItem != null)
            {
                int selected_front = Convert.ToInt16(front_combo.SelectedItem.ToString());

                if (selected_front == 0)
                {
                    Selected_Front = "Unallocated Tasks Front";
                }
                else
                {
                    Selected_Front = "Front : " + selected_front;
                }

                grid_tasks.Clear();

                foreach (var item in tasks_list)
                {
                    if (item.Task_front == selected_front)
                    {
                        grid_tasks.Add(item);
                    }
                }
            }
            
        }

        #endregion

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
