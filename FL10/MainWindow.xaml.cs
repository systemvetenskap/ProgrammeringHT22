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

namespace FL10
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
        // vi vill skapa en metod
        // Var placerar vi den???
        // Best practice. Lägg den i en egen klass
        // 2 3 5 = 36
        //int totalLegsCount=farm.GetAnimalLegCount(chickens: 2, cows: 3, pigs: 5);
        // totalLegsCount=farm.GetAnimalLegCount(1,2,3);


        //Cow cow = new Cow();
        //farm.Animals.Add(cow);
        //cow.RemoveLeg(1);
        //Chicken chicken = new Chicken();
        //farm.Animals.Add(chicken);
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Farm farm = new Farm();
            lstAnimals.ItemsSource = farm.Animals;
            

            List<Animal> animals = farm.GetAnimalsByLegCount(2);

            if (animals.Count==0)
            {

            }
            int totalLegsCount =farm.GetAnimalLegCount();
            int id=134;
            Animal animal = farm.GetAnimalById(id);

            if (animal == null)
            {
                MessageBox.Show($"Hittade inget djur med id: {id}");
            }
            else
            {
                MessageBox.Show($"Hittade {animal}");

            }

        }

    }
}
