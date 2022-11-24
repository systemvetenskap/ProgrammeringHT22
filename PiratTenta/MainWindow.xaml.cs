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

namespace PiratTenta
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

        private void btnRank_Click(object sender, RoutedEventArgs e)
        {
            string rank = "";
            int years = int.Parse(txtYears.Text);
            if (years < 2)
            {
                rank = "Deckhand";
            }
            else if (years < 3)
            {
                rank = "Boatswain";
            }
            else
            {
                rank = "Captain";
            }

            MessageBox.Show($"Du rankas som: {rank}");
        }
    }
}
