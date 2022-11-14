using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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

        private void btnShuffleName_Click(object sender, RoutedEventArgs e)
        {
            // https://edabit.com/challenge/c4W4BNymgCC5WkfHp
           // string name = txtInput.Text;
           // string shuffledName = NameShuffle(name);
            MessageBox.Show(NameShuffle(txtInput.Text));

        }

        private string NameShuffle(string name)
        {
            // Erik [E][r][i][k]
            string[] names = name.Split(" "); // Kan vi bygga en egen text splitter?
            names = TextSplitter(name);
            return $"{names[1]} {names[0]}";
        }

        private string[] TextSplitter(string text)
        {
            string firstPart="", secondPart="";
            bool foundSpace=false;
            foreach (char letter in text)
            {
                if (char.IsWhiteSpace(letter))
                {
                    foundSpace=true;
                    continue; // Den här gör att loopen redan har gjort klart sitt varv
                    // break; stoppar loopen
                    // return; får koden att hoppa ur hela metoden
                }
                if (foundSpace)
                {
                    secondPart += letter;
                }
                else
                {
                    firstPart += letter;
                }
            }

            return new string[] {firstPart,secondPart};
        }

        private void btnArr_Click(object sender, RoutedEventArgs e)
        {
            // https://edabit.com/challenge/FvXHdrhjLaof47Qt3
            // arrBetween(3, 8, [1, 5, 95, 0, 4, 7]) ➞ [5, 4, 7]
            List<int> myArray = ArrBetween(3, 8, new int[] {1, 5, 95, 0, 4, 7});
        }

        private List<int> ArrBetween(int num1, int num2, int[] arr)
        {
            //int[] result = new int[arr.Length];
            // en array måste ha antalet fack bestämda på förhand
            // vi måste skapa en ny typ av lista
            // En List är en collection av värden av samma sort, men som kan växa
            List<int> result = new List<int>();
            foreach (int number in arr)
            {
                if (number > num1 && number <num2)
                {
                    result.Add(number);
                }
            }

            int[] myListAsArray = result.ToArray();



            return result;
        }
    }
}
