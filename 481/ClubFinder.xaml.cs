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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ClubFinder : Page
    {
        public ClubFinder()
        {
            InitializeComponent();
        }

        private void GDC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GDC());
        }

        private void ViewAllClubs_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClubCenter());
        }
      
    }
}
