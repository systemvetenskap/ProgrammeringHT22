using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    public class Rectangle : Shape
    {

        // Den här konstruktorn kräver att vi har en höjd och en bredd
        // En konstruktor körs en och ENDAST en gång
        // == när objektet skapas NEW
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Snygga till utskriften
        public override string ToString()
        {
            return "Rektangel";
        }

    }
}
