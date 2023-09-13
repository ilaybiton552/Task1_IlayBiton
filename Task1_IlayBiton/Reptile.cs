using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Reptile : Animal, IReptile
    {
        protected double tailLength;

        public Reptile(string name, int age, bool isApexPredator, int caloriesPerMeal, 
            double tailLength) : base(name, age, isApexPredator, caloriesPerMeal)
        {
            this.tailLength = tailLength;
        }

        public override string ToString()
        {
            return "Reptile:{" + base.ToString() + $",tailLength={this.tailLength}}}";
        }

        public double GetTailLenght()
        {
            return this.tailLength;
        }

        public void SetTailLength(double tailLength)
        {
            this.tailLength = tailLength;
        }

        public void Crawl()
        {
            Console.WriteLine("Reptile is crawling");
        }

        public void SelfDefence()
        {
            Console.WriteLine("Reptile is now self defence");
        }

        public void CheckBodyTemp()
        {
            Console.Write("Enter current body temp: ");
            int bodyTemp = int.Parse(Console.ReadLine());
            if (bodyTemp < 40 && bodyTemp > 10)
            {
                Console.WriteLine("Body temp is good");
            }
            else
            {
                Console.WriteLine("Body temp is bad");
            }
        }

        public override void Breathing()
        {
            Console.WriteLine("Reptile is now breathing");
        }

        public override void Growing()
        {
            this.age++;
            Console.WriteLine("Reptile is now {0} years old", this.age);
        }

        public override void Reproduction()
        {
            Console.WriteLine("Reptile is .. ");
        }

    }
}
