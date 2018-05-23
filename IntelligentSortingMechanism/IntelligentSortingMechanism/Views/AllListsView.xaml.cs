﻿using IntelligentSortingMechanism.Models;
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
        #region Variables and Properties

        private UserModel user_logged = new UserModel();
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

        #endregion

        public AllListsView(UserModel user)
        {
            InitializeComponent();
            this.DataContext = this;

            user_logged = user;

            all_lists = new ObservableCollection<ListModel>();
            AllListsLoad();
        }

        private void AllListsLoad()
        {
            ListModel list = new ListModel();
            List<ListModel> lists = list.GetAllLists(user_logged.User_id);

            foreach (ListModel item in lists)
            {
                AllLists.Add(item);
            }
        }

        private void new_list_btn_Click(object sender, RoutedEventArgs e)
        {
            NewListView list_view = new NewListView(user_logged);
            list_view.Activate();
            list_view.Show();
            this.Close();
        }

        private void view_list_btn_Click(object sender, RoutedEventArgs e)
        {
            ListModel list = all_lists_grid.SelectedItem as ListModel;

            ListView list_view = new ListView(list);
            list_view.Activate();
            list_view.Show();
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
