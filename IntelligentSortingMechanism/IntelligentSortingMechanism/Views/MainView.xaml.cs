using IntelligentSortingMechanism.Controllers;
using IntelligentSortingMechanism.Models;
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
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window, INotifyPropertyChanged
    {

        private string error_message;
                

        public string Error_Message
        {
            get
            {
                return error_message;
            }
            set
            {
                this.error_message = value;
                OnPropertyChanged("Error_Message");
            }
        }

        public MainView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            string email = email_txt_box.Text;
            string password = password_txt_box.Text;

            if(!string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(password))
            {
                UserModel user = new UserModel();
                user = user.GetLoginUser(email, password);

                if (user.User_Logged_In)
                {
                    AllListsView all_lists = new AllListsView(user);
                    all_lists.Activate();
                    all_lists.Show();
                    this.Close();
                }
                else
                {
                    Error_Message = "Username or Password is not correct! Try again!";
                }
            }
            else
            {
                Error_Message = "Username or Password cannot be empty!";
            }

            

        }

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
