using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratesOfCaribbean
{
    public class Pirate
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public int EmploymentYear { get; set; }
        public Parrot Parrot { get; set; }
        public Pirate()
        {

        }


        public override string ToString()
        {
            return $"{Name} ({Level})";
        }
        public Pirate(string name, int employmentYear)
        {
            Name = name;
            EmploymentYear = employmentYear;
            Level = GetRankLevel(employmentYear);
        }

        public Pirate(string name, int employmentYear, string parrot)
        {
            Name = name;
            EmploymentYear = employmentYear;
            Parrot = new Parrot();
            Parrot.Name = parrot;
            Level = GetRankLevel(employmentYear);

        }

        private int GetRankLevel(int employmentYear)
        {
            // Uppgiften är korrekt, men exemplet var tokigt.
            // Jämför med listan i uppgiftsbeskrivningen

            int years = 1735 - employmentYear;
            int rankLevel = 1;

            for (int i = 2; i < years; i++)
            {
                if (IsPrime(i))
                {
                    rankLevel++;
                }
            }
            if (rankLevel > 5)
            {
                rankLevel=5; // maxvärde
            }
            return rankLevel;
        }

        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }

    }
}
