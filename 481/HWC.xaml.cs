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

namespace _481
{
    /// <summary>
    /// Interaction logic for HWC.xaml
    /// </summary>
    public partial class HWC : Page
    {
        public HWC()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Art_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AFH());
        }
    }
}
