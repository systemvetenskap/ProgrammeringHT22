using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            // 2500 rader kod
            return (Width * Height) /  2.0;
        }

        // Snygga till utskriften
        public override string ToString()
        {
            return "Triangel";
        }
    }
}
