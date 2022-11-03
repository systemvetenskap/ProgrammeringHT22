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

namespace FL4
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
            // Array

            // En kollektion, samling av en och samma datatyp


            // en simpel variabel kan innehålla ett och endast ett värde
            int sum = 0;

            // en array kan innehålla flera värden
            int[] sums;

            // Begreppet new!
            // Vi MÅSTE ange hur många fack vår array ska ha
            sums = new int[6];

            // Vi kan tilldela värden till vår array
            sums[2]=3;

            // C# är ett objektorienterat språk
            // vi har alltså alltid klasser och objekt
            string[] names = new string[2];

            names[0] = "Erik";
            names[1] = "Johanna";

            // Kan jag utöka en array.
            // alltså lägga till ännu ett fack? NEJ

            string name = "Erik";
            // ['E']['r']['i']['k']
            char letter = 'A';
            char myFirstLetter = name[1];

            string[] fruits = {"banan", "citron", "kiwi", "melon"};
            // jag kan ändra värden med index
          //  fruits[0] = "Äpple";


            // jag kan hämta värden med index
            string firstFruit = fruits[0];

            // En kollektions bästa kompis är loopen!

            // enklaste loopen är en foreach
            foreach (string fruit in fruits)
            {
                //MessageBox.Show(fruit);
            }

            // Den mest grundläggande loopen är en for-loop

            // tre statements
            // 1. ge vår variabel ett startvärde och ett namn
            // 2. ett villkor som måste valideras som sant eller falskt (if-sats)
            // 3. hur vill vi ändra variabeln vid varje varv?

            for (int i = 0; i < fruits.Length; i += 2)
            {
                //MessageBox.Show(fruits[i]);

            }

            // räkna baklänges
            for (int i = fruits.Length -1; i >= 0; i--)
            {
                // ändra
                if (i % 2 ==0)
                {
                    fruits[i]= "jämnt";
                }
                MessageBox.Show(fruits[i]);

            }

        }
    }
}
