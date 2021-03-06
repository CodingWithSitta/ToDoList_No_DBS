﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary.Services;

namespace ToDoList_No_DBS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaskServices ts;
        public MainWindow()
        {
            ts = new TaskServices();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                lstToDo.ItemsSource = ts.GetTasks();
        }

        private void btnCreateTask_Click(object sender, RoutedEventArgs e)
        {
            winCat winCat = new winCat();
            winCat.ShowDialog();
        }
    }
}
