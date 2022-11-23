using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    public abstract class Animal
    {
        public int Legs { get; protected set; } = 4;
        public int Id { get; set; }

        public void RemoveLeg(int count)
        {
            if (count > Legs || count <0)
            {
                return;
            }
            Legs -= count;
        }
    }
}
