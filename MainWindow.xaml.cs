﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.ViewModel;

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskListViewModel tasks = new TaskListViewModel();
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = tasks;
        }

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(inputTb.Text) || String.IsNullOrWhiteSpace(inputTb.Text))
            {
                MessageBox.Show("You have added a blank task!", "Alert", MessageBoxButton.OK,
                                MessageBoxImage.Exclamation);
            }
        }

        private void aboutBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
