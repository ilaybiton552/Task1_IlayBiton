using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Hipo:Mammal
    {
        protected double fatPercentage;

        public Hipo(string name, int age, bool isApexPredator, int caloriesPerMeal, int caloriesInMilk,
            int monthsForPregnancy, double fatPercentage) : base(name, age, isApexPredator, caloriesPerMeal,
                caloriesInMilk, monthsForPregnancy)
        {
            this.fatPercentage = fatPercentage;
        }

        public override string ToString()
        {
            return "Hipo:{" + base.ToString() + $",fatPercentage={this.fatPercentage}}}";
        }

        public double GetFatPercentage()
        {
            return this.fatPercentage;
        }

        public void SetFatPercentage(double fatPercentage)
        {
            this.fatPercentage = fatPercentage;
        }

    }
}
