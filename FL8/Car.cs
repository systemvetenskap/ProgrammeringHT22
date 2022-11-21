using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL8
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Bilens ägare
        /// </summary>
        public Person Owner { get; set; }
    }
}
