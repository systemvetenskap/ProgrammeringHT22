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

namespace FL5
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool onlyEvenNumbers=false;
            bool onlyOddNumbers;
            int[] myNumbers = {2,4,6,7,88,5544};
            int[] myOtherNumbers = {2,4,10};
            int sum = Sum(myNumbers);
            bool containsNumber = ContainsTwo(myNumbers);
            containsNumber = ContainsNumber(myNumbers, 5);

            int biggestNumber = GetBiggestNumber(myNumbers);
            biggestNumber = GetBiggestNumber(myOtherNumbers);

            string secretMessage = "hej jag är glad idag";

            onlyEvenNumbers = HasEvenNumbers(myNumbers);
            onlyOddNumbers = HasOddNumbers(myNumbers);
            bool mixedNumbers = HasMixedNumbers(myNumbers);

            //DisplayMessage(secretMessage);

            DisplayMessage();
        }
        /// <summary>
        /// Skriver ut valt meddelande på skärmen
        /// </summary>
        /// <param name="message"></param>
        private void DisplayMessage(string message)
        {
            // skriv ut meddelandet i en messagebox
            MessageBox.Show(message);
        }

        private void DisplayMessage()
        {
            // skriv ut meddelandet i en messagebox
            MessageBox.Show("hej");
        }

        /// <summary>
        /// Skriver ut summan på skärmen
        /// </summary>
        /// <param name="value"></param>
        private void DisplayMessage(int value)
        {
            MessageBox.Show($"Totalsumman blev: {value}");
        }

        /// <summary>
        /// Beräknar totalsumman av alla heltal i en array
        /// </summary>
        /// <param name="numbers">integer array</param>
        /// <returns>Totalsumman</returns>
        private int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int value in numbers)
            {
                sum += value;
            }


            return sum;
        }

        private int GetBiggestNumber(int[] numbers)
        {
            int biggest = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > biggest)
                {
                    biggest = number;
                }
            }

            return biggest;
        }
        private bool ContainsTwo(int[] numbers)
        {
            return ContainsNumber(numbers, 2);
        }

        private bool ContainsNumber(int[] numbers, int wantedNumber)
        {
            foreach (int number in numbers)
            {
                if (number == wantedNumber)
                {
                    return true;
                }
            }
            return false;
        }

        private bool HasEvenNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                // Är detta ett jämnt tal?
                // modulus-operatorn %

                // Det kan vi kontrollera genom att testa om det inte är ett heltal
                if (number % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool HasOddNumbers(int[] numbers)
        {
            bool oddNumbers = false;
            return !HasEvenNumbers(numbers);
        }

        private bool HasMixedNumbers(int[] numbers)
        {
            return !HasEvenNumbers(numbers) || !HasOddNumbers(numbers);
        }

    }
}
