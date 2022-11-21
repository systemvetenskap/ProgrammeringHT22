using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL8
{
    public class Pirate
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int EmploymentYear { get; set; }

        public Parrot Parrot { get; set; }

        public Pirate(string name,  int employmentYear)
        {
            Name = name;
            EmploymentYear = employmentYear;
        }

        public Pirate(string name, int employmentYear, Parrot parrot)
        {
            Name = name;
            EmploymentYear = employmentYear;
            Parrot = parrot;
        }

        public Pirate(string name, int employmentYear, string parrot)
        {
            Name = name;
            EmploymentYear = employmentYear;
            Parrot = new Parrot(parrot);
        }
    }
}
