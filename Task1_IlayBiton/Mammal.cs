using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Mammal:Animal
    {
        protected int caloriesInMilk;
        protected int monthsForPregnancy;

        public Mammal(string name, int age, bool isApexPredator, int caloriesPerMeal, 
            int caloriesInMilk, int monthsForPregnancy) : base(name, age, isApexPredator, caloriesPerMeal)
        {
            this.caloriesInMilk = caloriesInMilk;
            this.monthsForPregnancy = monthsForPregnancy;
        }

        public override string ToString()
        {
            return "Mammal:{" + base.ToString() + ",caloriesInMilk=" + this.caloriesInMilk + 
                ",monthsForPregnancy=" + this.monthsForPregnancy + "}";
        }

        public int GetCaloriesInMilk()
        {
            return this.caloriesInMilk;
        }

        public int GetMonthsForPregnancy()
        {
            return this.monthsForPregnancy;
        }

        public void SetCaloriesInMilk(int caloriesInMilk) 
        {
            this.caloriesInMilk = caloriesInMilk;
        }

        public void SetMonthsForPregnancy(int monthsForPregnancy)
        {
            this.monthsForPregnancy = monthsForPregnancy;
        }

        public new int Eat()
        {
            return base.Eat() + caloriesInMilk;
        }

        public override void Breathing()
        {
            Console.WriteLine("Mammal is now breathing");
        }

        public override void Growing()
        {
            this.age++;
            Console.WriteLine("Mammal is now {0} years old", this.age);
        }

        public override void Reproduction()
        {
            Console.WriteLine("Mamml is ..");
        }
    }
}
