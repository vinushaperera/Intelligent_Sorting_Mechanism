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
    /// Interaction logic for EditListView.xaml
    /// </summary>
    public partial class EditListView : Window
    {
        
        public EditListView()
        {
            InitializeComponent();
        }

        public string ResponseText
        {
            get { return list_name_box.Text; }
            set { list_name_box.Text = value; }
        }

        private void ok_btn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
