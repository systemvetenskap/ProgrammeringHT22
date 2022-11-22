﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    public class Challenge
    {
        // Nu vill vi ha godtyckligt antal figurer
        public List<Shape> Shapes { get; set; }
        public string Name { get;  }
        public Challenge(string name)
        {
            Name = name;
            Shapes = new List<Shape>();
        }

        public double Area()
        {
            double area = 0;    
            foreach (Shape shape in Shapes)
            {
                area += shape.Area();
            }
            
            
            return area;
        }
    }
}
