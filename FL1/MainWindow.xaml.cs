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

namespace FL1
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


        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            // ANVÄND DEBUGGER!!!!
            // Gör att vi kan stega oss igenom koden
            // 1. Sätt en breakpoint

            // Vi vill hämta text från vår textruta
           // txtName.Text = "Erik Öberg";

            // Vi vill ofta spara värden till längre fram i koden
            // gör en variabel
            // Alla variabler i C# MÅSTE ha en datatyp

            //datatyp + variabelnamn. Namnet ska ALLTID börja med liten bokstav (camelCase)
            // vi deklarerar variabler
            string firstName, lastName;
            // Tilldela värden till våra variabler
            firstName = txtName.Text;
            lastName = txtLastname.Text;
            // Man kan slå ihop strängar i C#
            // konkatenera
            // string interpolation
            MessageBox.Show("Hej" + " " + txtName.Text+ " " + txtLastname.Text);
            //MessageBox.Show($"Hej {firstName} {lastName}");
        }


    }
}
