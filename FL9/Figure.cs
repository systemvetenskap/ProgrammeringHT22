using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL9
{
    public abstract class Shape
    {
        public double Width { get; protected set; } // protected betyder att barnen får ärva
        public double Height { get; protected set; } // men, kan inte ändras utifrån

        // Vi vill räkna ut vår area

        // Här har vi en metod som ärvs ner till ALLA barn

        // Kan vi istället göra en metod som erbjuder en grundfunktion,
        // men som vi kan ändra vid behov?

        // polymorfism!
        // magin ligger i ordet virtual
        public virtual double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Figur";
        }


    }
}
