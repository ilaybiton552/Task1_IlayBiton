using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Park
    {
        protected Animal[] animals;
        protected int currentAnimals;

        public Park()
        {
            this.animals = new Animal[1000];
            this.currentAnimals = 0;
        }

        public void Add(Animal a)
        {
            if (currentAnimals < 1000)
            {
                for (int i = 0; i < this.animals.Length; i++)
                {
                    if (this.animals[i] == null)
                    {
                        this.animals[i] = a;
                        currentAnimals++;
                        return;
                    }
                }
            }
        }

        public LinkedList<Animal> OldAndPredator()
        {
            LinkedList<Animal> animals = new LinkedList<Animal>();
            foreach (var animal in this.animals)
            {
                if (animal != null)
                {
                    if (animal.GetAge() > 10 && animal.GetIsApexPredator())
                    {
                        animals.AddLast(animal);
                    }
                }
            }
            return animals;
        }

        public int PredatorsBirdsAndReptiles()
        {
            int count = 0;
            foreach (var animal in this.animals)
            {
                if (animal != null)
                {
                    if ((animal is Reptile || animal is Bird) && animal.GetIsApexPredator())
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
