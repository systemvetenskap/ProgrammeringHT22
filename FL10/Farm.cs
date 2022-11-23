using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL10
{
    public class Farm 
    {
        // varför _ framför variabelnamnet?
        private static readonly Random _random = new Random();
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public Farm()
        {
            CreateAnimals(500);
        }
       
        public int GetAnimalLegCount(int chickens, int cows, int pigs)
        {
            int legsChicken = 2, legsCows = 4, legsPigs=4;

            return chickens*legsChicken + cows * legsCows + pigs*legsPigs;
        }

        public int GetAnimalLegCount()
        {
            int legs=0;
            foreach (Animal animal in Animals)
            {
                  legs += animal.Legs;
            }
            return legs;
        }

        public List<Animal> GetAnimalsByLegCount(int legCount)
        {
            
            List<Animal> animals = new List<Animal>();
            foreach (Animal animal in Animals)
            {
                if (animal.Legs == legCount)
                {
                    animals.Add(animal);
                }
            }
            return animals;
        }

        private void CreateAnimals(int count)
        {
            Animal animal = null;
            for (int i = 0; i < count; i++)
            {
                int magicNumber = _random.Next(0, 3);
                switch (magicNumber)
                {
                    case 0:
                        animal = new Cow();
                        break;
                    case 1:
                        animal = new Pig();
                        break;
                    case 2:
                        animal = new Chicken();
                        break;
                }
                animal.Id=i+1;
                Animals.Add(animal);
            }
        }

        public Animal GetAnimalById(int id)
        {
            foreach (Animal animal in Animals)
            {
                if (animal.Id == id)
                {
                   return animal;
                }
            }
            // hittar inget djur
            return null;
        }
    }
}
