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

namespace WpfDesignPatternPrac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void MVCBtn_Click(object sender, RoutedEventArgs e)
        {
            var mainView = new DesignPattern.MVC.Views.MainView();
            _ = new DesignPattern.MVC.Controllers.MainController(mainView);

            mainView.Show();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
