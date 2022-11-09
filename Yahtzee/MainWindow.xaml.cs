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
        private readonly static Random random = new Random(); // en slumpgenerator
        int numberOfDice;
        int[] dice;
        // den här koden begriper jag dåligt, men använder den ändå :)
        public MainWindow()
        {
            InitializeComponent();
            numberOfDice = 5;
            dice = new int[numberOfDice];
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {


            bool[] savedDice = new bool[numberOfDice];
            
            RollDice(savedDice);

            savedDice[0] = true;
            savedDice[1] = true;

            RollDice(savedDice);



            lstValues.ItemsSource = dice;

            int ones, twos, threes, fours=0, fives=0, sixes=0, total=0;
            bool isConvertedCorrect;
            int[] sums = new int[6];

             // todo: Se till att värdena istället kontrollers i varje ruta, inte på knappen
            // return
            // null
            //if (string.IsNullOrEmpty(txtThrees.Text))
            //{
            //    MessageBox.Show("Fel värde");

            //    return;
            //}

            ones =int.Parse(txtOnes.Text);
            twos=int.Parse(txtTwos.Text);

            isConvertedCorrect = int.TryParse(txtThrees.Text, out threes);

            int[] dieSum = GetDieSums(dice);


            
            

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
                total = GetTotalSum(sums);
                total += GetBonusPoints(total);
                

                
            }


            txtTotal.Text = total.ToString();


        }

        private int GetBonusPoints(int score)
        {
            // ternary
            // condition ? consequent : alternative
            int bonusPoint;
            if (score >= 72 )
            {
                bonusPoint=50;
            }
            else
            {
                bonusPoint=0;
            }


            return score >= 72 ? 50 : 0;

        }

        private int GetTotalSum(int[] sums)
        {
            int total = 0;  
            foreach (int sum in sums)
            {
                total += sum;
            }
            return total;
        }

        private int GetTotalSum(int[] sums, int eye)
        {
            int total = 0;
            foreach (int sum in sums)
            {
                if (sum == eye)
                {
                    total += sum;
                }
            }
            return total;
        }

        private int[] GetDieSums(int[] dice)
        {
            int eyes = 6;
            int[] dieSum = new int[eyes];
            for (int eye = 1; eye <= eyes; eye++)
            {
                dieSum[eye - 1] = GetTotalSum(dice, eye);
            }
            return dieSum;
        }

        private int RollDie()
        {
            return random.Next(1, 7); // Ger ett värde mellan 1 och 6 (exlusive upper bound)
        }

        private void RollDice(bool[] savedDice)
        {
            //  0     1       2       3      4
            // [1]   [2]     [2]     [1]    [6]
            // [true][true][false][false][false]
            
            for (int i = 0; i < dice.Length; i++)
            {
                if (!savedDice[i])
                {
                    dice[i] = RollDie();
                }
            }
        }

        private void txtOnes_TextChanged(object sender, TextChangedEventArgs e)
        {
            int value = int.Parse( txtOnes.Text);
        }
    }
}
