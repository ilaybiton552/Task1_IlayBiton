using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Hoopoe:Bird
    {
        protected double beakLength;
        public Hoopoe(string name, int age, bool isApexPredator, int caloriesPerMeal,
            double flightHeight, double wingsLength, double beakLength) : base(name, age, isApexPredator, caloriesPerMeal, 
                flightHeight, wingsLength)
        {
            this.beakLength = beakLength;
        }

        public override string ToString()
        {
            return "Hoopoe:{" + base.ToString() + $",beakLength={this.beakLength}}}";
        }

        public double GetBeakLength()
        {
            return this.beakLength;
        }

        public void SetBeakLenght(double beakLength)
        {
            this.beakLength = beakLength;
        }

    }
}
