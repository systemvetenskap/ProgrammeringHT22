using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL8
{
    // Varför får jag public class Person?
    // Ni får säkert internal class Person?
    // I den här kursen spelar det INGEN som helst roll. Behåll internal!
    // TDD
    
    
    /// <summary>
    /// Beskrivning över vår person
    /// </summary>
    public class Person
    {
        // en klass kan ha egenskaper
        // de beskriver våra klasser

        // en klass kan även ha metoder. Den utför något

        public string? Name { get; set;} = "Erik";

        public int Age { get;set;}

        public string Address { get; set; }
        

        

        // Tom konstruktor
        internal Person()
        {
           
        }

        // konstruktor med parametrar
        internal Person(string name, string address)
        {
            Name=name;
            Address=address;    
        }   

        /// <summary>
        /// Ändrar personens namn
        /// </summary>
        /// <param name="name">Namnet du vill ändra</param>
        /// <returns>true om namnet är korrekt, i annat fall false</returns>
        public bool ChangeName(string name)
        {
            // Kontrollera att namnet inte innhåller andra saker än bokstäver

            foreach (char letter in name)
            {
                if (char.IsDigit(letter))
                {
                    return false;
                }
            }


            Name = name;
            return true;
        }
    }
}
