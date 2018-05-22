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
    /// Interaction logic for AllListsView.xaml
    /// </summary>
    public partial class AllListsView : Window
    {

        private static ObservableCollection<ListModel> all_lists;

        public static ObservableCollection<ListModel> AllLists
        {
            get
            {
                return all_lists;
            }
            set
            {
                all_lists = value;
            }
        }

        public AllListsView()
        {
            InitializeComponent();
            this.DataContext = this;
            all_lists = new ObservableCollection<ListModel>();
            AllListsLoad();
        }

        private void AllListsLoad()
        {
            ListModel list = new ListModel();
            List<ListModel> lists = list.GetAllLists(0);

            foreach (ListModel item in lists)
            {
                AllLists.Add(item);
            }
        }

        private void new_list_btn_Click(object sender, RoutedEventArgs e)
        {
            NewListView list_view = new NewListView();
            list_view.Activate();
            list_view.Show();
        }
    }
}
