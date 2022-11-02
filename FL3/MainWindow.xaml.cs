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

namespace FL3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ny kommentar
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Styrande satser

            // Måste alltid vara på formen ja eller nej

            // villkor

            //if(villkor) // mitt villkor måste kunna valideras som sant eller falskt

            //string personOne = "Erik Öberg", personTwo="Sara";
            //if (personOne.Length < 8)
            //{
            //    if (personOne.Length > personTwo.Length)
            //    {
            //        // Den här koden körs om och endast om
            //        // villkoret är sant
            //        MessageBox.Show("Ditt namn är längst");
            //    }
            //    else if (personOne.Length == personTwo.Length)
            //    {
            //        MessageBox.Show("Era namn är lika långa");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ditt namn är kortast");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ditt namn är för långt");
            //}

            /*    Har föraren hållit rätt hastighet?
             *    Är föraren nykter?
             *    --> om promillehalten < x
             *      -- rattonykter
             *      annars rattfull
             * 
             */
            int currentSpeed = 95, speedLimit=90;
            double toxicLevel = 0.5;

            bool hasCorrectSpeed = currentSpeed <= speedLimit;
            bool isSober = toxicLevel<0.1;

            if (!hasCorrectSpeed)
            {
                // Du har kört olagligt
            }

            if (toxicLevel >= 0.1)
            {
                // rattfylleri
                if (toxicLevel >= 0.5)
                {
                    // grovt rattfull
                }
            }
            
            if(hasCorrectSpeed && isSober) // OCH
            {
                // Bra precis som det ska vara
            }
            else
            {
                // ajajaj
            }


            if (!hasCorrectSpeed || !isSober) // ELLEr
            {
                // Ajajajaj
            }
            else
            {
                // Bra
            }
        }
    }
}
