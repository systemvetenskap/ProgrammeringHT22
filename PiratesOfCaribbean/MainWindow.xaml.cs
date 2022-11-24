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

namespace PiratesOfCaribbean
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Tortuga tortuga;
        static readonly Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            tortuga = new Tortuga();



            Parrot parrot = new Parrot();   
            parrot.Name = "Kiko";
            string jibberish = parrot.Talk("Land i sikte");

            Parrot parrot2 = new Parrot();
            parrot.Name = "Moonlight”";
            jibberish = parrot2.Talk("Du har inte mycket kraft");

            Parrot parrot3= new Parrot();
            parrot.Name = "Clark”,”";
            jibberish = parrot3.Talk("Du måste kämpa");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Pirate jack = new Pirate("Jack Sparrow", 1731);
            Pirate nellie = new Pirate("One-Leg Nellie", 1729, "Moonlight");


            List<Pirate> selectedPirates =  tortuga.GetPiratesByLevel(10, 1);
            List<Pirate> crew = tortuga.GetPirateCrew(new int[] { 2, 1, 2, 1, 1 });

        }

        private void btnBonus_Click(object sender, RoutedEventArgs e)
        {
            string[] firstNames = { "Natalia", "Aurora", "Victoria", "Isabela", "Jonathan", "Mateo", "Alejandro" };
            string[] nickNames = { "Rum Lover", "Silver Teeth", "No-Tounge", "Mad Eye", "Blunder", "The Fool", "Tide Turner" };
            string[] lastNames = { "Vázquez", "Castro", "Carrillo", "Rosario", "Ortega", "Rutland", "Bones" };

            string[] names = new string[3];


            for (int i = 0; i < 3; i++)
            {
                string firstname = firstNames[random.Next(firstNames.Length)];
                string nickname = nickNames[random.Next(nickNames.Length)];
                string lastname = lastNames[random.Next(lastNames.Length)];
                string name = $"{firstname} '{nickname}' {lastname}";
                names[i] = name;
            }
            
            lstNames.ItemsSource = names;
        }
    }
}
