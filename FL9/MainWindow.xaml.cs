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

namespace FL9
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
            Shape rectangle = new Rectangle(6, 2.5);// vi har fått ett objekt av typen rectangle
            Shape triangle = new Triangle(6, 3);// vi har fått ett objekt av typen rectangle
            Shape triangle2 = new Triangle(62, 33);
            Shape square = new Square(23);
            //Shape shape = new Shape();

           // double totalArea = rectangle.Area() + triangle.Area();
            //string message = $"Den totala arean är {totalArea} kvadratmeter";
           

            Challenge challenge = new Challenge("22 b");
            challenge.Shapes.Add(rectangle);
            challenge.Shapes.Add(triangle);
            challenge.Shapes.Add(triangle2);
            challenge.Shapes.Add(square);

            double totalArea = challenge.Area();
            // Gör oftast inte på detta sättet!
            //lstShapes.Items.Add(rectangle);

            // Vad vi istället vill göra är att knyta den till en datakälla
            lstShapes.ItemsSource = challenge.Shapes;
        }

    }
}
