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
    /// Interaction logic for Calander.xaml
    /// </summary>
    public partial class Calander : Page
    {
        // variables
        private int state = 0;
        private bool expanded = true;
        private bool reg3 = false;
        private bool CollapseEmptyWeek = false;
        private String eventSelected = "";
        public Calander()
        {
            InitializeComponent();
        }
        // btnExpand Click
        private void btnExpand_Click(object sender, RoutedEventArgs e)
        {
            if (expanded)
            {
                btnExpand.Content = "<";
                EventDetails.Width = 200;
                Grid.Width = 788;
                Thickness marginThickness = Grid.Margin;
                Grid.Margin = new Thickness(5, 20, 5, 0);
                ClubsPanel.Width = 0;
                Thickness marginThickness2 = btnToday.Margin;
                btnToday.Margin = new Thickness(20, 0, 0, 0);
                expanded = false;
                btnJoin.Margin = new Thickness(110, 30, 0, 0);
            }

            else
            {
                btnExpand.Content = ">";
                EventDetails.Width = 130;
                Grid.Width = 718;
                Thickness marginThickness = Grid.Margin;
                Grid.Margin = new Thickness(82, 27, 0, 0);
                ClubsPanel.Width = 82;
                Thickness marginThickness2 = btnToday.Margin;
                btnToday.Margin = new Thickness(0, 0, 0, 0);
                expanded = true;
                btnJoin.Margin = new Thickness(50, 0, 0, 0);
            }
        }

        // Go back 1 week Click
        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            if (state == 0)
            {
                // Done
                tbDateW1D1.Text = "April-04";
                SetTB(ref w1d1_Event1, "", Brushes.Red);
                tbDateW1D2.Text = "05";
                SetTB(ref w1d2_Event1, "", Brushes.Red);
                SetTB(ref w1d2_Event2, "", Brushes.Red);
                tbDateW1D3.Text = "06";
                SetTB(ref w1d3_Event1, "", Brushes.Red);
                SetBRD(ref brdW1D3_1, 1, Brushes.Gray);
                tbDateW1D4.Text = "07";
                tbDateW1D5.Text = "08";
                tbDateW1D6.Text = "09";
                tbDateW1D7.Text = "10";

                tbDateW2D1.Text = "11";
                SetTB(ref w2d1_Event1, "2pm CareerLink - How to Get Hired", Brushes.Red);
                tbDateW2D2.Text = "12";
                SetTB(ref w2d2_Event1, "10am Mental Health Session: What We Offer to Help You", Brushes.Red);
                SetTB(ref w2d2_Event2, "12pm Coffee Chat with Industry Experts", Brushes.Red);
                tbDateW2D3.Text = "13";
                SetTB(ref w2d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
                SetBRD(ref brdW2D3_1, 2, Brushes.Navy);
                tbDateW2D4.Text = "14";
                tbDateW2D5.Text = "15";
                tbDateW2D6.Text = "16";
                tbDateW2D7.Text = "17";

                tbDateW3D1.Text = "18";
                SetTB(ref w3d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW3D2.Text = "19";
                SetTB(ref w3d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                tbDateW3D3.Text = "20";
                tbDateW3D4.Text = "21";
                tbDateW3D5.Text = "22";
                tbDateW3D6.Text = "23";
                tbDateW3D7.Text = "24";

                tbDateW4D1.Text = "25";
                SetTB(ref w4d1_Event1, "", Brushes.Red);
                tbDateW4D2.Text = "26";
                tbDateW4D3.Text = "27";
                SetTB(ref w4d3_Event1, "", Brushes.Red);
                tbDateW4D4.Text = "28";
                tbDateW4D5.Text = "29";
                tbDateW4D6.Text = "30";
                SetTB(ref w4d6_Event1, "", Brushes.Red);
                tbDateW4D7.Text = "May-01";

                state = -1;
            }
            else if (state == 1)
            {
                btnToday_Click(sender, e);
                /*tbDateW1D1.Text = "April-11";
                tbDateW1D2.Text = "12";
                tbDateW1D3.Text = "13";
                // W1D3 Add event and current day
                brdW1D3_1.BorderBrush = Brushes.Navy;
                brdW1D3_1.BorderThickness = new Thickness(2);
                w1d3_Event1.Text = "11am CSUS GItHub Event";
                w1d3_Event1.Foreground = Brushes.Navy;
                tbDateW1D4.Text = "14";
                // W1D4 clear event 
                tbW1D4_Event1.Text = "";
                tbDateW1D5.Text = "15";
                tbDateW1D6.Text = "16";
                tbDateW1D7.Text = "17";

                tbDateW2D1.Text = "18";
                tbDateW2D2.Text = "19";
                tbDateW2D3.Text = "20";
                tbDateW2D4.Text = "21";
                // April21 add event
                tbW2D4_Event1.Text = "";// "12pm Event_2 at the";
                tbW2D4_Event1.Foreground = Brushes.Red;
                tbDateW2D5.Text = "22";
                tbDateW2D6.Text = "23";
                tbDateW2D7.Text = "24";

                tbDateW3D1.Text = "25";
                tbDateW3D2.Text = "26";
                tbDateW3D3.Text = "27";
                tbDateW3D4.Text = "28";
                tbDateW3D5.Text = "29";
                tbDateW3D6.Text = "30";
                tbDateW3D7.Text = "May-01";

                tbDateW4D1.Text = "02";
                tbDateW4D2.Text = "03";
                w4d2_Event1.Visibility = Visibility.Visible;
                w4d2_Event1.Text = "";// "1om Event_3 at the";
                tbDateW4D3.Text = "04";
                tbDateW4D4.Text = "05";
                tbDateW4D5.Text = "06";
                tbDateW4D6.Text = "07";
                tbDateW4D7.Text = "08"; */

                state = 0;
            }
            else if (state == 2)
            {
                tbDateW1D1.Text = "April-18";
                SetTB(ref w1d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW1D2.Text = "19";
                SetTB(ref w1d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                tbDateW1D3.Text = "20";
                tbDateW1D4.Text = "21";
                tbDateW1D5.Text = "22";
                tbDateW1D6.Text = "23";
                tbDateW1D7.Text = "24";

                tbDateW2D1.Text = "25";
                SetTB(ref w2d1_Event1, "", Brushes.Red);
                tbDateW2D2.Text = "26";
                tbDateW2D3.Text = "27";
                SetTB(ref w2d3_Event1, "", Brushes.Red);
                tbDateW2D4.Text = "28";
                tbDateW2D5.Text = "29";
                tbDateW2D6.Text = "30";
                SetTB(ref w2d6_Event1, "", Brushes.Red);
                tbDateW2D7.Text = "May-01";

                tbDateW3D1.Text = "02";
                SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                tbDateW3D2.Text = "03";
                tbDateW3D3.Text = "04";
                SetTB(ref w3d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                tbDateW3D4.Text = "05";
                SetTB(ref w3d4_Event1, "", Brushes.Red);
                tbDateW3D5.Text = "06";
                tbDateW3D6.Text = "07";
                SetTB(ref w3d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                tbDateW3D7.Text = "08";

                tbDateW4D1.Text = "09";
                tbDateW4D2.Text = "10";
                tbDateW4D3.Text = "11";
                tbDateW4D4.Text = "12";
                SetTB(ref w4d4_Event1, "12pm CareerLink: The Perfect Resume", Brushes.Red);
                tbDateW4D5.Text = "13";
                tbDateW4D6.Text = "14";
                tbDateW4D7.Text = "15";

                state = 1;
            }
            else if (state == -1)
            {
                // DONE
                tbDateW1D1.Text = "March-28";
                tbDateW1D2.Text = "29";
                tbDateW1D3.Text = "30";
                tbDateW1D4.Text = "31";
                tbDateW1D5.Text = "April-01";
                tbDateW1D6.Text = "02";
                tbDateW1D7.Text = "03";

                tbDateW2D1.Text = "04";
                SetTB(ref w2d1_Event1, "", Brushes.Red);
                tbDateW2D2.Text = "05";
                SetTB(ref w2d2_Event1, "", Brushes.Red);
                SetTB(ref w2d2_Event2, "", Brushes.Red);
                tbDateW2D3.Text = "06";
                SetTB(ref w2d3_Event1, "", Brushes.Navy);
                SetBRD(ref brdW2D3_1, 1, Brushes.Gray);
                tbDateW2D4.Text = "07";
                tbDateW2D5.Text = "08";
                tbDateW2D6.Text = "09";
                tbDateW2D7.Text = "10";

                tbDateW3D1.Text = "11";
                SetTB(ref w3d1_Event1, "2pm CareerLink - How to Get Hired", Brushes.Red);
                tbDateW3D2.Text = "12";
                SetTB(ref w3d2_Event1, "10am Mental Health Session: What We Offer to Help You", Brushes.Red);
                SetTB(ref w3d2_Event2, "12pm Coffee Chat with Industry Experts", Brushes.Red);
                tbDateW3D3.Text = "13";
                SetTB(ref w3d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
                SetBRD(ref brdW3D3_1, 2, Brushes.Navy);
                tbDateW3D4.Text = "14";
                tbDateW3D5.Text = "15";
                tbDateW3D6.Text = "16";
                tbDateW3D7.Text = "17";

                tbDateW4D1.Text = "18";
                SetTB(ref w4d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW4D2.Text = "19";
                SetTB(ref w4d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                tbDateW4D3.Text = "20";
                tbDateW4D4.Text = "21";
                tbDateW4D5.Text = "22";
                tbDateW4D6.Text = "23";
                tbDateW4D7.Text = "24";

                state = -2;
            }

            switch (state)
            {
                case 0:
                    tbMonth.Text = "April 2021";
                    break;
                case 1:
                    tbMonth.Text = "April 2021";
                    break;
                case 2:
                    tbMonth.Text = "May 2021";
                    break;
                case -1:
                    tbMonth.Text = "April 2021";
                    break;
                case -2:
                    tbMonth.Text = "April 2021";
                    break;
                default:
                    // do nothing
                    break;
            }

        }

        // Go forwards 1 week Click
        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            if (state == 0)
            {
                tbDateW1D1.Text = "April-18";
                SetTB(ref w1d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW1D2.Text = "19";
                SetTB(ref w1d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                SetTB(ref w1d2_Event2, "", Brushes.Red);
                tbDateW1D3.Text = "20";
                SetTB(ref w1d3_Event1, "", Brushes.Navy);
                SetBRD(ref brdW1D3_1, 1, Brushes.Gray);
                tbDateW1D4.Text = "21";
                tbDateW1D5.Text = "22";
                tbDateW1D6.Text = "23";
                tbDateW1D7.Text = "24";

                tbDateW2D1.Text = "25";
                SetTB(ref w2d1_Event1, "", Brushes.Navy);
                tbDateW2D2.Text = "26";
                SetTB(ref w2d2_Event1, "", Brushes.Navy);
                tbDateW2D3.Text = "27";
                tbDateW2D4.Text = "28";
                tbDateW2D5.Text = "29";
                tbDateW2D6.Text = "30";
                tbDateW2D7.Text = "May-01";

                tbDateW3D1.Text = "02";
                SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                tbDateW3D2.Text = "03";
                tbDateW3D3.Text = "04";
                SetTB(ref w3d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                tbDateW3D4.Text = "05";
                tbDateW3D5.Text = "06";
                tbDateW3D6.Text = "07";
                SetTB(ref w3d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                tbDateW3D7.Text = "08";

                tbDateW4D1.Text = "09";
                SetTB(ref w4d1_Event1, "", Brushes.Red);
                tbDateW4D2.Text = "10";
                tbDateW4D3.Text = "11";
                SetTB(ref w4d3_Event1, "", Brushes.Red);
                tbDateW4D4.Text = "12";
                SetTB(ref w4d4_Event1, "12pm CareerLink: The Perfect Resume", Brushes.Red);
                tbDateW4D5.Text = "13";
                tbDateW4D6.Text = "14";
                SetTB(ref w4d6_Event1, "", Brushes.Red);
                tbDateW4D7.Text = "15";

                state = 1;
            }
            else if (state == 1)
            {
                tbDateW1D1.Text = "April-25";
                SetTB(ref w1d1_Event1, "", Brushes.Red);
                tbDateW1D2.Text = "26";
                SetTB(ref w1d2_Event1, "", Brushes.Red);
                tbDateW1D3.Text = "27";
                tbDateW1D4.Text = "28";
                tbDateW1D5.Text = "29";
                tbDateW1D6.Text = "30";
                tbDateW1D7.Text = "May-01";

                tbDateW2D1.Text = "02";
                SetTB(ref w2d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                tbDateW2D2.Text = "03";
                tbDateW2D3.Text = "04";
                SetTB(ref w2d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                tbDateW2D4.Text = "05";
                tbDateW2D5.Text = "06";
                tbDateW2D6.Text = "07";
                SetTB(ref w2d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                tbDateW2D7.Text = "08";

                tbDateW3D1.Text = "09";
                SetTB(ref w3d1_Event1, "", Brushes.Red);
                tbDateW3D2.Text = "10";
                tbDateW3D3.Text = "11";
                SetTB(ref w3d3_Event1, "", Brushes.Red);
                tbDateW3D4.Text = "12";
                SetTB(ref w3d4_Event1, "12pm CareerLink: The Perfect Resume", Brushes.Red);
                tbDateW3D5.Text = "13";
                tbDateW3D6.Text = "14";
                SetTB(ref w3d6_Event1, "", Brushes.Red);
                tbDateW3D7.Text = "15";

                tbDateW4D1.Text = "16";
                tbDateW4D2.Text = "17";
                tbDateW4D3.Text = "18";
                tbDateW4D4.Text = "19";
                SetTB(ref w4d4_Event1, "", Brushes.Red);
                tbDateW4D5.Text = "20";
                tbDateW4D6.Text = "21";
                tbDateW4D7.Text = "22";

                state = 2;

            }
            else if (state == 2)
            {
                // do nothing
            }
            else if (state == -1)
            {
                // Done
                tbDateW1D1.Text = "April-11";
                SetTB(ref w1d1_Event1, "2pm CareerLink - How to Get Hired", Brushes.Red);
                tbDateW1D2.Text = "12";
                SetTB(ref w1d2_Event1, "10am Mental Health Session: What We Offer to Help You", Brushes.Red);
                SetTB(ref w1d2_Event2, "12pm Coffee Chat with Industry Experts", Brushes.Red);
                tbDateW1D3.Text = "13";
                SetTB(ref w1d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
                SetBRD(ref brdW1D3_1, 2, Brushes.Navy);
                tbDateW1D4.Text = "14";
                tbDateW1D5.Text = "15";
                tbDateW1D6.Text = "16";
                tbDateW1D7.Text = "17";

                tbDateW2D1.Text = "18";
                SetTB(ref w2d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW2D2.Text = "19";
                SetTB(ref w2d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                SetTB(ref w2d2_Event2, "", Brushes.Red);
                tbDateW2D3.Text = "20";
                SetTB(ref w2d3_Event1, "", Brushes.Navy);
                SetBRD(ref brdW2D3_1, 1, Brushes.Gray);
                tbDateW2D4.Text = "21";
                tbDateW2D5.Text = "22";
                tbDateW2D6.Text = "23";
                tbDateW2D7.Text = "24";

                tbDateW3D1.Text = "25";
                SetTB(ref w3d1_Event1, "", Brushes.Navy);
                tbDateW3D2.Text = "26";
                SetTB(ref w3d2_Event1, "", Brushes.Navy);
                tbDateW3D3.Text = "27";
                tbDateW3D4.Text = "28";
                tbDateW3D5.Text = "29";
                tbDateW3D6.Text = "30";
                tbDateW3D7.Text = "May-01";

                tbDateW4D1.Text = "02";
                SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                tbDateW4D2.Text = "03";
                tbDateW4D3.Text = "04";
                SetTB(ref w4d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                tbDateW4D4.Text = "05";
                tbDateW4D5.Text = "06";
                tbDateW4D6.Text = "07";
                SetTB(ref w4d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                tbDateW4D7.Text = "08";

                state = 0;
            }
            else if (state == -2)
            {
                // Done
                tbDateW1D1.Text = "April-04";
                tbDateW1D2.Text = "05";
                tbDateW1D3.Text = "06";
                tbDateW1D4.Text = "07";
                tbDateW1D5.Text = "08";
                tbDateW1D6.Text = "09";
                tbDateW1D7.Text = "10";

                tbDateW2D1.Text = "11";
                SetTB(ref w2d1_Event1, "2pm CareerLink - How to Get Hired", Brushes.Red);
                tbDateW2D2.Text = "12";
                SetTB(ref w2d2_Event1, "10am Mental Health Session: What We Offer to Help You", Brushes.Red);
                SetTB(ref w2d2_Event2, "12pm Coffee Chat with Industry Experts", Brushes.Red);
                tbDateW2D3.Text = "13";
                SetTB(ref w2d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
                SetBRD(ref brdW2D3_1, 2, Brushes.Navy);
                tbDateW2D4.Text = "14";
                tbDateW2D5.Text = "15";
                tbDateW2D6.Text = "16";
                tbDateW2D7.Text = "17";

                tbDateW3D1.Text = "18";
                SetTB(ref w3d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                tbDateW3D2.Text = "19";
                SetTB(ref w3d2_Event1, "11am Information Session: Data Science", Brushes.Red);
                SetTB(ref w3d2_Event2, "", Brushes.Red);
                tbDateW3D3.Text = "20";
                SetTB(ref w3d3_Event1, "", Brushes.Navy);
                SetBRD(ref brdW3D3_1, 1, Brushes.Gray);
                tbDateW3D4.Text = "21";
                tbDateW3D5.Text = "22";
                tbDateW3D6.Text = "23";
                tbDateW3D7.Text = "24";

                tbDateW4D1.Text = "25";
                SetTB(ref w4d1_Event1, "", Brushes.Red);
                tbDateW4D2.Text = "26";
                SetTB(ref w4d2_Event1, "", Brushes.Red);
                tbDateW4D3.Text = "27";
                tbDateW4D4.Text = "28";
                tbDateW4D5.Text = "29";
                tbDateW4D6.Text = "30";
                tbDateW4D7.Text = "May-01";

                state = -1;
            }

            switch (state)
            {
                case 0:
                    tbMonth.Text = "April 2021";
                    break;
                case 1:
                    tbMonth.Text = "April 2021";
                    break;
                case 2:
                    tbMonth.Text = "May 2021";
                    break;
                case -1:
                    tbMonth.Text = "April 2021";
                    break;
                case -2:
                    tbMonth.Text = "April 2021";
                    break;
                default:
                    // do nothing
                    break;
            }

        }

        // btnToday Click (DONE)
        private void btnToday_Click(object sender, RoutedEventArgs e)
        {
            tbDateW1D1.Text = "April-11";
            SetTB(ref w1d1_Event1, "2pm CareerLink -How to Get Hired", Brushes.Red);
            tbDateW1D2.Text = "12";
            SetTB(ref w1d2_Event1, "10am Mental Health Session: What We Offer to Help You", Brushes.Red);
            SetTB(ref w1d2_Event2, "12pm Coffee Chat with Industry Experts", Brushes.Red);
            tbDateW1D3.Text = "13";
            SetTB(ref w1d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
            SetBRD(ref brdW1D3_1, 2, Brushes.Navy);
            tbDateW1D4.Text = "14";
            tbDateW1D5.Text = "15";
            tbDateW1D6.Text = "16";
            tbDateW1D7.Text = "17";

            tbDateW2D1.Text = "18";
            SetTB(ref w2d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
            tbDateW2D2.Text = "19";
            SetTB(ref w2d2_Event1, "11am Information Session: Data Science", Brushes.Red);
            SetTB(ref w2d2_Event2, "", Brushes.Red);
            tbDateW2D3.Text = "20";
            SetTB(ref w2d3_Event1, "", Brushes.Red);
            SetBRD(ref brdW2D3_1, 1, Brushes.Gray);
            tbDateW2D4.Text = "21";
            tbDateW2D5.Text = "22";
            tbDateW2D6.Text = "23";
            SetTB(ref w2d6_Event1, "", Brushes.Red);
            tbDateW2D7.Text = "24";

            tbDateW3D1.Text = "25";
            SetTB(ref w3d1_Event1, "", Brushes.Red);
            tbDateW3D2.Text = "26";
            SetTB(ref w3d2_Event1, "", Brushes.Red);
            SetTB(ref w3d2_Event2, "", Brushes.Red);
            tbDateW3D3.Text = "27";
            SetTB(ref w3d3_Event1, "", Brushes.Red);
            SetBRD(ref brdW3D3_1, 1, Brushes.Gray);
            tbDateW3D4.Text = "28";
            SetTB(ref w3d4_Event1, "", Brushes.Red);
            tbDateW3D5.Text = "29";
            tbDateW3D6.Text = "30";
            SetTB(ref w3d6_Event1, "", Brushes.Red);
            tbDateW3D7.Text = "May-01";

            tbDateW4D1.Text = "02";
            SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
            tbDateW4D2.Text = "03";
            SetTB(ref w4d2_Event1, "", Brushes.Red);
            tbDateW4D3.Text = "04";
            SetTB(ref w4d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
            tbDateW4D4.Text = "05";
            SetTB(ref w4d4_Event1, "", Brushes.Red);
            tbDateW4D5.Text = "06";
            tbDateW4D6.Text = "07";
            SetTB(ref w4d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
            tbDateW4D7.Text = "08";

            state = 0;
            tbMonth.Text = "April 2021";
        }

        // Shade Months
        private void ShadeMonths_Click(object sender, RoutedEventArgs e)
        {
            Filters.Text = "View Options"; //TODO: fix
            if (ShadeMonths.IsChecked == true)
            {
                if (CollapseEmpty.IsChecked == false)
                {
                    
                    stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));

                    stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                }

                else
                {
                    stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));

                    stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                }
            }
            else
            {
                stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));

                stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
            }
        }

        // View Reg Events
        private void ViewRegEvents_Click(object sender, RoutedEventArgs e)
        {
            Filters.Text = "View Options";
            if (ViewRegEvents.IsChecked == true)
            {
                SetTB(ref w1d3_Event1, "", Brushes.Navy);
                SetTB(ref w2d1_Event1, "", Brushes.Navy);
                if (CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w3d1_Event1, "", Brushes.Navy);
                } else if (!CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w4d1_Event1, "", Brushes.Navy);
                }
            }

            else
            {
                SetTB(ref w1d3_Event1, "11am CSUS GitHub Event", Brushes.Navy);
                SetTB(ref w2d1_Event1, "3pm UCalgaryTogether: Exercise Together", Brushes.Navy);
                if (CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                }
                else if (!CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                }
            }
        }

        // View Non-Reg Events
        private void ViewNonRegEvents_Click(object sender, RoutedEventArgs e)
        {
            Filters.Text = "View Options";

            if (ViewNonRegEvents.IsChecked == true)
            {
                w1d1_Event1.Visibility = Visibility.Hidden;
                w1d2_Event1.Visibility = Visibility.Hidden;
                w1d2_Event2.Visibility = Visibility.Hidden;

                w2d2_Event1.Visibility = Visibility.Hidden;

                w3d3_Event1.Visibility = Visibility.Hidden;
                w3d6_Event1.Visibility = Visibility.Hidden;

                if (!CollapseEmptyWeek && !reg3)
                {
                    w4d1_Event1.Visibility = Visibility.Hidden;
                    w4d3_Event1.Visibility = Visibility.Hidden;
                    w4d4_Event1.Visibility = Visibility.Hidden;
                    w4d6_Event1.Visibility = Visibility.Hidden;
                } else if (CollapseEmptyWeek && !reg3)
                {
                    w3d1_Event1.Visibility = Visibility.Hidden;
                    w3d3_Event1.Visibility = Visibility.Hidden;
                    w3d4_Event1.Visibility = Visibility.Hidden;
                    w3d6_Event1.Visibility = Visibility.Hidden;
                    w4d4_Event1.Visibility = Visibility.Hidden;
                } else if (!CollapseEmptyWeek && reg3)
                {
                    w4d3_Event1.Visibility = Visibility.Hidden;
                    w4d4_Event1.Visibility = Visibility.Hidden;
                    w4d6_Event1.Visibility = Visibility.Hidden;
                }
                else if (CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w3d3_Event1, "", Brushes.Red); //may4
                    SetTB(ref w3d6_Event1, "", Brushes.Red); //may7
                    SetTB(ref w4d4_Event1, "", Brushes.Red);
                }
            }

            else
            {
                w1d1_Event1.Visibility = Visibility.Visible;
                w1d2_Event1.Visibility = Visibility.Visible;
                w1d2_Event2.Visibility = Visibility.Visible;

                w2d2_Event1.Visibility = Visibility.Visible;

                if (!CollapseEmptyWeek && !reg3)
                {
                    w4d1_Event1.Visibility = Visibility.Visible;
                    w4d3_Event1.Visibility = Visibility.Visible;
                    w4d4_Event1.Visibility = Visibility.Hidden;
                    w4d6_Event1.Visibility = Visibility.Visible;
                }
                else if (CollapseEmptyWeek && !reg3)
                {
                    w3d1_Event1.Visibility = Visibility.Visible;
                    w3d3_Event1.Visibility = Visibility.Visible;
                    //w3d4_Event1.Visibility = Visibility.Hidden;
                    w3d6_Event1.Visibility = Visibility.Visible;
                    w4d4_Event1.Visibility = Visibility.Visible;
                }
                else if (!CollapseEmptyWeek && reg3)
                {
                    w4d3_Event1.Visibility = Visibility.Visible;
                    w4d4_Event1.Visibility = Visibility.Hidden;
                    w4d6_Event1.Visibility = Visibility.Visible;
                }
                else if (CollapseEmptyWeek && reg3)
                {
                    SetTB(ref w3d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                    w3d3_Event1.Visibility = Visibility.Visible;
                    SetTB(ref w3d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                    w3d6_Event1.Visibility = Visibility.Visible;
                    SetTB(ref w4d4_Event1, "12pm CareerLink: The Perfect Resume", Brushes.Red);
                    w4d4_Event1.Visibility = Visibility.Visible;
                }
            }

        }

        // Collapse Empty Weeks
        private void CollapseEmpty_Click(object sender, RoutedEventArgs e)
        {
            Filters.Text = "View Options";

            if (CollapseEmpty.IsChecked == true)
            {
                CollapseEmptyWeek = true;

                tbDateW3D1.Text = "May-02";
                brdW3D1.Visibility = Visibility.Visible;
                if (reg3)
                {
                    SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                }
                else
                {
                    SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                }
                w3d1_Event1.Visibility = Visibility.Visible;
                tbDateW3D2.Text = "03";
                brdW3D2.Visibility = Visibility.Visible;
                tbDateW3D3.Text = "04";
                brdW3D3.Visibility = Visibility.Visible;
                SetTB(ref w3d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                w3d3_Event1.Visibility = Visibility.Visible;
                tbDateW3D4.Text = "05";
                brdW3D4.Visibility = Visibility.Visible;
                tbDateW3D5.Text = "06";
                brdW3D5.Visibility = Visibility.Visible;
                tbDateW3D6.Text = "07";
                brdW3D6.Visibility = Visibility.Visible;
                SetTB(ref w3d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                w3d6_Event1.Visibility = Visibility.Visible;
                tbDateW3D7.Text = "08";
                brdW3D7.Visibility = Visibility.Visible;

                tbDateW4D1.Text = "09";
                SetTB(ref w4d1_Event1, "", Brushes.Red);
                tbDateW4D2.Text = "10";
                tbDateW4D3.Text = "11";
                SetTB(ref w4d3_Event1, "", Brushes.Red);
                tbDateW4D4.Text = "12";
                SetTB(ref w4d4_Event1, "12pm CareerLink: The Perfect Resume", Brushes.Red);
                w4d4_Event1.Visibility = Visibility.Visible;
                tbDateW4D5.Text = "13";
                tbDateW4D6.Text = "14";
                SetTB(ref w4d6_Event1, "", Brushes.Red);
                tbDateW4D7.Text = "15";


                if (ShadeMonths.IsChecked == true)
                {
                    stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));

                    stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                }

            }
            else
            {
                CollapseEmptyWeek = false;

                tbDateW3D1.Text = "25";
                brdW3D1.Visibility = Visibility.Hidden;
                SetTB(ref w3d1_Event1, "", Brushes.Red);
                tbDateW3D2.Text = "26";
                brdW3D2.Visibility = Visibility.Hidden;
                tbDateW3D3.Text = "27";
                brdW3D3.Visibility = Visibility.Hidden;
                SetTB(ref w3d3_Event1, "", Brushes.Red);
                tbDateW3D4.Text = "28";
                brdW3D4.Visibility = Visibility.Hidden;
                tbDateW3D5.Text = "29";
                brdW3D5.Visibility = Visibility.Hidden;
                tbDateW3D6.Text = "30";
                brdW3D6.Visibility = Visibility.Hidden;
                SetTB(ref w3d6_Event1, "", Brushes.Red);
                tbDateW3D7.Text = "May-01";
                brdW3D7.Visibility = Visibility.Hidden;


                tbDateW4D1.Text = "02";
                if (reg3) {
                    SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                } else
                {
                    SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Red);
                }
                
                w4d1_Event1.Visibility = Visibility.Visible;
                tbDateW4D2.Text = "03";
                tbDateW4D3.Text = "04";
                SetTB(ref w4d3_Event1, "11am Launchpad Liftoff!", Brushes.Red);
                w4d3_Event1.Visibility = Visibility.Visible;
                tbDateW4D4.Text = "05";
                SetTB(ref w4d4_Event1, "", Brushes.Red);
                tbDateW4D5.Text = "06";
                tbDateW4D6.Text = "07";
                SetTB(ref w4d6_Event1, "2pm Virtual RealiTEA", Brushes.Red);
                w4d6_Event1.Visibility = Visibility.Visible;
                tbDateW4D7.Text = "08";

                if (ShadeMonths.IsChecked == true)
                {
                    stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));

                    stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                    stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#2D2D2D"));
                }
                else
                {
                    stpW3D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW3D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));

                    stpW4D1.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D2.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D3.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D4.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D5.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D6.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                    stpW4D7.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#4D4D4D"));
                }

            }

        }

        // set TextBlock
        private void SetTB(ref TextBlock tb, String text, SolidColorBrush txtColor)
        {
            tb.Text = text;
            tb.Foreground = txtColor;
        }

        // Set Border
        private void SetBRD(ref Border brd, int brdThickness, SolidColorBrush brdColor)
        {
            brd.BorderBrush = brdColor;
            brd.BorderThickness = new Thickness(brdThickness);
        }

        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            if (eventSelected.Equals("apr13_11am_CSUS"))
            {
                // do nothing
            }
            else if (eventSelected.Equals("may02_1pm_Virt") && !reg3)
            {
                btnJoin.Content = "Joined!";
                tbEvent1.Visibility = Visibility.Collapsed;
                tbEvent2.Visibility = Visibility.Collapsed;
                tbEvent3.Visibility = Visibility.Visible;
                reg3 = true;

                if (CollapseEmptyWeek)
                {
                    SetTB(ref w3d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                    SetTB(ref w4d1_Event1, "", Brushes.Navy);
                } else
                {
                    SetTB(ref w4d1_Event1, "1pm Virtual Board Game Cafe", Brushes.Navy);
                    SetTB(ref w3d1_Event1, "", Brushes.Navy);
                }
            }
            else
            {
                //do nothing
            }
        }

        private void w1d3_Event1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //tbEvent1
            tbEvent1.Visibility = Visibility.Visible;
            tbEvent2.Visibility = Visibility.Collapsed;
            tbEvent3.Visibility = Visibility.Collapsed;
            btnJoin.Content = "Joined!";
            if (!expanded)
            {
                btnJoin.Margin = new Thickness(110, 30, 0, 0);
            }
            eventSelected = "apr13_11am_CSUS";
        }

        private void w4d1_Event1_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            //tbEvent2
            tbEvent1.Visibility = Visibility.Collapsed;
            eventSelected = "may02_1pm_Virt";

            if (reg3)
            {
                tbEvent2.Visibility = Visibility.Collapsed;
                tbEvent3.Visibility = Visibility.Visible;
                btnJoin.Content = "Joined!";
            }
            else
            {
                tbEvent2.Visibility = Visibility.Visible;
                tbEvent3.Visibility = Visibility.Collapsed;
                btnJoin.Content = "Join";
            }
            if (!expanded)
            {
                btnJoin.Margin = new Thickness(110, 40, 0, 0);
            }
        }

        private void Club_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClubCenter());
        }

        private void Cal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Calander());
        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EventFinder());
        }

        private void Setting_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }

        private void InfoSec_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CSUS());
        }
    }
}
