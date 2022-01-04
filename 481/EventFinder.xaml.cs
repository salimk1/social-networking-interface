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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class EventFinder : Page
    {
        public EventFinder()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/GithubEvent.xaml", UriKind.RelativeOrAbsolute));
        }
      
        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MostPopularEvents());

            //this.NavigationService.Navigate(new Uri("/MostPopularEvents.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
