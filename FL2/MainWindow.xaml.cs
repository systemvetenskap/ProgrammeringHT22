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

namespace FL2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int myLuckyNumber = 4;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // deklarerar variabeln lastname
            string lastName;
            // deklarerar och tilldelar
            string firstName = "Nils";

            lastName=txtName.Text;

            // tilldelar värde <---- görs från höger till vänster
            firstName += " Erik"; // utöka redan befintliga data i variabeln

           lblResult.Content =  $"{firstName} {lastName}";
            firstName = "Johanna";
           txtName.Text =  $"{firstName} {lastName}";

            // Scope
            // räckvidd
            // variablers räckvidd
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            // Variabler som kan innehålla siffror
            // heltal
            // flyttal, decimaltal

            // datatyp   variabelnamn   och eventuellt startvärde
            string firstName = "Pelle";
            // heltal         // sträng omvandlat till ett heltal
            myLuckyNumber = int.Parse(txtName.Text);

            myLuckyNumber++;


            lblResult.Content = myLuckyNumber;
            // Konvertera heltalet till en sträng
            // Metoder har ALLTID en parentes!
            txtName.Text = myLuckyNumber.ToString();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // hämta ålder och lägg i en variabel
            int ageInYears, daysPerYear=365, totalDaysLived;
            double totalWeeksLived, daysInWeek;


            // tilldela värde
            //ageInYears = int.Parse(txtName.Text);
            //totalDaysLived = ageInYears * daysPerYear;

            daysInWeek = double.Parse(txtName.Text);

            // hur många veckor har jag levt?
            // Utför en heltalsdivision
            totalWeeksLived = daysPerYear / 7;

            // vill utföra en flyttalsdivision
            // cast
            //totalWeeksLived = daysPerYear / (double)ageInYears;

           

            //totalWeeksLived = 52.2;
            // Clean Code
            // refaktorering

            //lblResult.Content=$"Du har totalt levt i {totalDaysLived} antal dagar";
            lblResult.Content=$"Antal veckor: {daysInWeek}";


            
        }
    }
}
