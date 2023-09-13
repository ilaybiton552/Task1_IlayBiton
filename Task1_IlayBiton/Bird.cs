using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Bird : Animal, IBird
    {
        protected double flightHeight;
        protected double wingsLength;

        public Bird(string name, int age, bool isApexPredator, int caloriesPerMeal, 
            double flightHeight, double wingsLength) : base(name, age, isApexPredator, caloriesPerMeal)
        {
            this.flightHeight = flightHeight;
            this.wingsLength = wingsLength;
        }

        public override string ToString()
        {
            return "Bird:{" + base.ToString() + $",flightHeight={this.flightHeight},wingsLenght={this.wingsLength}}}";
        }

        public double GetFlightHeight()
        {
            return this.flightHeight;
        }

        public double GetWingsLength() 
        {
            return this.wingsLength;
        }

        public void SetFlightHeight(double flightHeight) 
        {
            this.flightHeight = flightHeight;
        }

        public void SetWingsLenght(double wingsLength)
        {
            this.wingsLength = wingsLength;
        }

        public string Sing()
        {
            return "lalalalala";
        }

        public void Dance()
        {
            Console.WriteLine("Bird is dancing :)");
        }

        public void Rising()
        {
            Console.WriteLine("Bird is taking off");
        }

        public void Landing()
        {
            Console.WriteLine("Bird is landing");
        }

        public void Soaring()
        {
            Console.WriteLine("Bird is soaring");
        }

        public override void Breathing()
        {
            Console.WriteLine("Bird is now breathing");
        }

        public override void Growing()
        {
            this.age++;
            Console.WriteLine("Bird is now {0} years old", this.age);
        }

        public override void Reproduction()
        {
            Console.WriteLine("Eggs");
        }

    }
}
