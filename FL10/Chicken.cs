using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    public class Chicken : Animal
    {
        public Chicken()
        {
            Legs=2;
        }

        public override string ToString()
        {
            return "Kyckling";
        }
    }
}
