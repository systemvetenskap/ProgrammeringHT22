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

namespace Yahtzee
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

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            int ones, twos, threes, fours=0, fives=0, sixes=0, total=0;
            bool isConvertedCorrect;
            int[] sums = new int[6];

             // todo: Se till att värdena istället kontrollers i varje ruta, inte på knappen
            // return
            // null
            if (string.IsNullOrEmpty(txtThrees.Text))
            {
                MessageBox.Show("Fel värde");

                return;
            }

            ones =int.Parse(txtOnes.Text);
            twos=int.Parse(txtTwos.Text);

            isConvertedCorrect = int.TryParse(txtThrees.Text, out threes);

            if (!isConvertedCorrect)
            {
                MessageBox.Show("Fel värde");
            }


            //  Hur kan vi kontrollera att användaren har matat in rimliga värden????

            // Ett tänkbart sätt kan vara att titta på rimliga summor

            if(twos==2 || twos==4 || twos==6 || twos==8)
            {

            }

            if (twos >=2 && twos<=10)
            {

            }
            // Dela med 2?
            if (twos % 2 != 0)
            {
                // Felaktiga värden
                MessageBox.Show("Nu blev det tokigt");
            }
            else
            {
                //total = ones + twos+ threes + fours + fives + sixes;

                // varför inte använda en array och en loop?

                foreach (int sum in sums)
                {
                    total += sum;
                }

                if (total >= 5)
                {
                    txtBonus.Text="50";
                    total += 50;
                }
            }


            txtTotal.Text = total.ToString();


        }
    }
}
