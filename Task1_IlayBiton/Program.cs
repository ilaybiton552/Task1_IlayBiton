using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] names = { "Kofico", "Nemo", "Max", "Marsh" };
            Mammal[] arrMammal =
            {
                new Mammal(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, 
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20)),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, 
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(1, 5)),
                new Hipo(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, 
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(20, 80)),
                new Mammal(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, 
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20)),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, 
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(1, 10)),
            };
            Reptile[] arrReptile =
            {
                new Reptile(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000), 
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10)), 
                new Snake(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000), 
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), true), 
                new Pythonidae(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000),
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), true, "blue"), 
                new Pythonidae(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000), 
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), false, "red"), 
                new Reptile(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000), 
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10))
            };
            Animal[] arrAnimal =
            {
                //new Animal(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000)), 
                new Hoopoe(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, rnd.Next(500, 2000), 
                rnd.Next(5, 50), rnd.Next(1, 30) / rnd.Next(2, 5), rnd.Next(1, 20) / rnd.Next(3, 6)),
                new Bird(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, rnd.Next(500, 2000),
                rnd.Next(5, 50), rnd.Next(1, 30) / rnd.Next(2, 5)),
                new Hoopoe(names[rnd.Next(names.Length)], rnd.Next(1, 60), false, rnd.Next(500, 2000),
                rnd.Next(5, 50), rnd.Next(1, 30) / rnd.Next(2, 5), rnd.Next(1, 20) / rnd.Next(3, 6)),
                new Pythonidae(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000),
                rnd.Next(5, 100) * rnd.Next(1, 10) / rnd.Next(1, 10), false, "green"),
                new Cow(names[rnd.Next(names.Length)], rnd.Next(1, 60), false,
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(1, 5)),
                new Hipo(names[rnd.Next(names.Length)], rnd.Next(1, 60), false,
                rnd.Next(500, 2000), rnd.Next(100, 500), rnd.Next(1, 20), rnd.Next(20, 80)),
                new Mammal(names[rnd.Next(names.Length)], rnd.Next(1, 60), true, rnd.Next(500, 2000), 
                rnd.Next(100, 500), rnd.Next(1, 20))
            };
            
            foreach (var animal in arrMammal)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }

            foreach (var animal in arrReptile)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }

            foreach (var animal in arrAnimal)
            {
                Console.WriteLine(animal);
                Console.WriteLine();
            }

        }

        public static int SumOfCalories(Animal[] animals)
        {
            int sum = 0;
            foreach (var animal in animals) 
            {
                sum += animal.Eat();
            }
            return sum;
        }

        public static int NumOfMammal(Animal[] animals)
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if (animal is Mammal)
                {
                    count++;
                }
            }
            return count;
        }

        public static void MakeDance(Animal[] animals)
        {
            foreach(var animal in animals)
            {
                if (animal is Bird)
                {
                    ((Bird)animal).Dance();
                }
                else if (animal is Snake)
                {
                    ((Snake)animal).Dance();
                }
            }
        }

        public static string FattestHipo(Animal[] animals)
        {
            string fatHipo = "";
            double fatPercentage = 0;
            foreach(var animal in animals)
            {
                if (animal is Hipo)
                {
                    Hipo hipo = (Hipo)animal;
                    if (hipo.GetFatPercentage() > fatPercentage)
                    {
                        fatPercentage = hipo.GetFatPercentage();
                        fatHipo = hipo.GetName();
                    }
                }
            }
            return fatHipo;
        }

    }
}
