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

namespace TravelTime
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
            double travelTime;
            travelTime = EstimateTravelTime(50.2); // 8
            travelTime= EstimateTravelTime(1); // 1
        }

        private double EstimateTravelTime(double distance)
        {
            double speed = 3.5; // Medelhastigheten
            int nauticalMile = 1852;
            double distanceInMeters = distance * 1000;
            
            double hours = (distance * 1000) / (nauticalMile * speed);
            return Math.Ceiling(hours);
        }
    }
}
