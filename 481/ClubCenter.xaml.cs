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

namespace _481
{
    /// <summary>
    /// Interaction logic for ClubCenter.xaml
    /// </summary>
    public partial class ClubCenter : Page
    {
        public ClubCenter()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cpc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CPC());
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new InfoSec());
        }

        private void Boulder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UCBC());
        }

        private void Blood_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CBS());
        }

        private void Game_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GDC());
        }

        private void Indus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new IDSGN());
        }

        private void Smash_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SSBU());
        }

        private void Chess_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UCCC());
        }

        private void Art_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AFH());
        }

        private void Med_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MSA());
        }

        private void Dev_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DSC());
        }

        private void Health_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HWC());
        }

        private void CompKey(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                NavigationService.Navigate(new ComputerSearch());
            }
        }

        private void Recommended_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClubFinder());
        }
    }
}
