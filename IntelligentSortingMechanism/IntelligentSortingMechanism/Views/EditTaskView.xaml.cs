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
    /// Interaction logic for EditTaskView.xaml
    /// </summary>
    public partial class EditTaskView : Window
    {
        public EditTaskView()
        {
            InitializeComponent();
        }

        public string DescriptionText
        {
            get { return desc_box.Text; }
            set { desc_box.Text = value; }
        }

        public string PriorityText
        {
            get { return priority_box.Text; }
            set { priority_box.Text = value; }
        }

        public DateTime DeadlineText
        {
            get { return (DateTime)date_box.SelectedDate; }
            set { date_box.SelectedDate = value; }
        }

        public string LinkIDText
        {
            get { return link_box.Text; }
            set { link_box.Text = value; }
        }

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
