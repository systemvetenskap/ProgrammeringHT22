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
    }
}
