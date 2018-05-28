using System;
using System.Collections.Generic;
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
    /// Interaction logic for EditTaskView.xaml
    /// </summary>
    public partial class EditTaskView : Window, INotifyPropertyChanged
    {
        #region Variables and Properties

        private string error_txt;

        public string Error_txt
        {
            get
            {
                return error_txt;
            }

            set
            {
                error_txt = value;
                OnPropertyChanged("Error_txt");
            }
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

        #endregion

        #region Constructors

        public EditTaskView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        #endregion

        #region Helper Methods

        private void done_btn_Click(object sender, RoutedEventArgs e)
        {
            if(!(string.IsNullOrWhiteSpace(desc_box.Text) || string.IsNullOrWhiteSpace(priority_box.Text) || string.IsNullOrWhiteSpace(link_box.Text)))
            {
                DialogResult = true;
            }
            else
            {
                Error_txt = "All the fields have to be filled!";
            }            
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
