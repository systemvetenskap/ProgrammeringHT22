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

namespace FL8
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();

            // Kan vi ge en person ett namn från start, utan att detta går att ändra 
            //person.Name="Johanna";

            //string name = "Joha123nna";



            // vi vill ge vår person flera värden till våra egenskaper
            // Punktnotation
            person.Address="Sågstigen 1";
            person.Age=35;

            person.Age=45;

            Person person2 = new Person()
            {
                Name="Sara",
                Address="Lingonstigen 1",
                Age=31
            };
            
            Person person3 = new Person(name: "Mohamed",address: "Skogsbacken");
           // MessageBox.Show(person.Name);

            bool success = person.ChangeName("Johanna");
            success = person.ChangeName("Johan123na");
            MessageBox.Show(person.Name);

            Car opel = new Car()
            {
                Make="Opel",
                Model="Manta",
                Owner=person3
            };
            }

        private void btnPirate_Click(object sender, RoutedEventArgs e)
        {
            // Ger värde med punktnotation
            Parrot kiko = new Parrot();
            kiko.Name = "Kiko";

            // initalizer
            Parrot clark = new Parrot()
            {
                Name="Clark"
            };

           // via konstruktor 
           Parrot moonlight = new Parrot("Moonlight");

           Pirate jack =  new Pirate("Jack Sparrow", 1728, kiko);

           Pirate nellie =  new Pirate("One-Leg Nellie", 1729, "Moonlight");
        }
    }
}
