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

namespace Challenges
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddSubract_Click(object sender, RoutedEventArgs e)
        {
            // https://edabit.com/challenge/s9tefkuARCqzT3vpo
            int expected = 24, x, y;
            string result="";
            x = 6;
            y=4;
            bool isAdded= x + y == expected, isSubracted = x - y == expected, isDivided= x / y == expected;

            if (isAdded)
            {
                result = "added";
            }
            else if(isSubracted)
            {
                result = "subracted";
            }
            else if (isDivided)
            {
                result = "divided";
            }
            else
            {
                result="none";
            }



            MessageBox.Show(result);
        }

        private void btnConvertMonth_Click(object sender, RoutedEventArgs e)
        {
            string month = GetMonthName(2);
        }

        private string GetMonthName(int monthNumber)
        {
            //if (monthNumber == 1)
            //{
            //    return "Januari";
            //}

            //if(monthNumber == 2)
            //{
            //    return "Februari";
            //}
            //return "Hittade ingen månad.";

            // case switch!

            // eftersom varje månad alltid har ett fast värde på månadens nummer
            // konstanta värden
            string month;
            switch (monthNumber)
            {
                case 1:
                    month =  "Januari";
                    // många rader kod
                    //

                    //
                    break;
                case 2:
                    month =  "Februari";
                    break;
                default:
                    month =  "Hittade ingen månad.";
                    break;
            }
            return month;
        }
    }
}
