﻿using IntelligentSortingMechanism.Controllers;
using IntelligentSortingMechanism.Models;
using Microsoft.Win32;
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
using WinForms = System.Windows.Forms;

namespace IntelligentSortingMechanism.Views
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {

        UserModel user_logged = new UserModel();
        ListModel viewed_list = new ListModel();
        ObservableCollection<TaskModel> tasks_list = new ObservableCollection<TaskModel>();

        public ObservableCollection<TaskModel> Tasks_List
        {
            get
            {
                return tasks_list;
            }
            set
            {
                this.tasks_list = value;
            }
        }

        public ListView(UserModel user, ListModel list)
        {
            InitializeComponent();
            this.DataContext = this;

            user_logged = user;
            viewed_list = list;

            ListController cont = new ListController();

            List<TaskModel> temp_list = new List<TaskModel>();
            temp_list = cont.GetTasks(list.List_id);

            List<TaskModel> sorted_list = temp_list.OrderBy(o=>o.Task_sorted_order).ToList();

            tasks_list = new ObservableCollection<TaskModel>(sorted_list);
            list_name_txt.Text = viewed_list.List_name;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            AllListsView all_list_view = new AllListsView(user_logged);
            all_list_view.Activate();
            all_list_view.Show();
            this.Close();
        }

        private void sort_btn_Click(object sender, RoutedEventArgs e)
        {
            List<TaskModel> list = new List<TaskModel>(tasks_list);

            SortingController controller = new SortingController();
            Dictionary<int, List<TaskModel>> sorted_dictionary = controller.SortingHandler(list);
            tasks_list.Clear();
            int order = 1;
            int fronts = 0;

            foreach (var item in sorted_dictionary)
            {
                foreach (var list_item in item.Value)
                {
                    list_item.Task_front = item.Key + 1;
                    list_item.Task_sorted_order = order;
                    tasks_list.Add(list_item);
                    order++;
                }

                fronts++;
            }

            viewed_list.List_fronts = fronts;

            ListController list_controller = new ListController();
            list_controller.SaveSortedList(viewed_list, new List<TaskModel>(tasks_list));

        }

        private void export_list_Click(object sender, RoutedEventArgs e)
        {
            WinForms.FolderBrowserDialog folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = false;
            WinForms.DialogResult result = folderBrowser.ShowDialog();
            string path = "";

            if(result == WinForms.DialogResult.OK)
            {
                path = folderBrowser.SelectedPath;
                ListController controller = new ListController();
                controller.WriteExcel(new List<TaskModel>(tasks_list), path, viewed_list.List_name);
            }

            
        }
    }
}
