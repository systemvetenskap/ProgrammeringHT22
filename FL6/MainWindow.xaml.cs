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

namespace FL6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// här får du aldrig skapa variabler
    public partial class MainWindow : Window
    {
        // här får man gärna skapa variabler. Räckvidd = maximalt
        int numberOfPlayers;
        public MainWindow()  // konstruktor
        {
            // det här är en metod som körs en och endast en gång
            // == när programmet startas
            // det ger oss en möjlighet att sätta vissa startvärden
            InitializeComponent();
            // här?
            numberOfPlayers = 2;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // variabels räckvidd
            // här?
            MessageBox.Show("Det här spelet har " + numberOfPlayers +" spelare");

            if (numberOfPlayers == 2)
            {
                // här?
                int gameLevel=123;
            }

            
        }
    }
}
