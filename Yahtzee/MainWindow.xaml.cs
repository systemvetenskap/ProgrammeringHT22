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


        private void DisplayDice()
        {
            dieOne.Content = dice[0];
            dieTwo.Content = dice[1];
            dieThree.Content = dice[2];
            dieFour.Content = dice[3];
            dieFive.Content = dice[4];
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            bool[] savedDice = { (bool)chkOne.IsChecked, (bool)chkTwo.IsChecked, (bool)chkThree.IsChecked, (bool)chkFour.IsChecked, (bool)chkFive.IsChecked };
            RollDice(savedDice);
            txtTotal.Text = GetTotalSum(3).ToString();
        }
        #region Summerar tärningar
        private int GetBonusPoints(int score)
        {
            // ternary
            // condition ? consequent : alternative
            int bonusPoint;
            if (score >= 72)
            {
                bonusPoint = 50;
            }
            else
            {
                bonusPoint = 0;
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

        private int GetTotalSum(int eye)
        {
            int total = 0;
            foreach (int sum in dice)
            {
                if (sum == eye)
                {
                    total += sum;
                }
            }
            return total;
        }

        private int[] GetDieSums()
        {
            int eyes = 6;
            int[] dieSum = new int[eyes];
            for (int eye = 1; eye <= eyes; eye++)
            {
                dieSum[eye - 1] = GetTotalSum(eye);
            }
            return dieSum;
        }
        #endregion

        #region Kasta tärningar
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

            DisplayDice();

        }
        #endregion


        private void txtOnes_TextChanged(object sender, TextChangedEventArgs e)
        {
            //int value = int.Parse(txtOnes.Text);
            txtTotal.Text = GetTotalSum(1).ToString();
        }
    }
}
