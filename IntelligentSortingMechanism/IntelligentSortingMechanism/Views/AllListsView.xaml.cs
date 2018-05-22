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
    /// Interaction logic for AllListsView.xaml
    /// </summary>
    public partial class AllListsView : Window
    {
        public AllListsView()
        {
            InitializeComponent();
        }

        private void new_list_btn_Click(object sender, RoutedEventArgs e)
        {
            NewListView list_view = new NewListView();
            list_view.Activate();
            list_view.Show();
        }
    }
}
