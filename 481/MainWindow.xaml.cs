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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageFrame.Navigate(new ClubCenter());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Club_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new ClubCenter());
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new EventFinder());
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new Settings());
        }

        private void Luc_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new DMLuc());
        }

        private void InfoSec_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new CSUS());
        }
        private void toCal(object sender, RoutedEventArgs e)
        {
            PageFrame.Navigate(new Calander());
        }
    }
}
