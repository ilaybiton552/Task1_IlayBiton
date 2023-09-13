using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected bool isApexPredator;
        protected int caloriesPerMeal;

        public Animal(string name, int age, bool isApexPredator, int caloriesPerMeal)
        {
            this.name = name;
            this.age = age;
            this.isApexPredator = isApexPredator;
            this.caloriesPerMeal = caloriesPerMeal;
        }

        public override string ToString()
        {
            return $"Animal:{{name='{this.name}',age={this.age},isApexPredator={this.isApexPredator},caloriesPerMeal={this.caloriesPerMeal}}}";
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public bool GetIsApexPredator()
        {
            return this.isApexPredator;
        }

        public int GetCaloriesPerMeal()
        {
            return this.caloriesPerMeal;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetIsApexPredator(bool isApexPredator)
        {
            this.isApexPredator = isApexPredator;
        }

        public void SetCaloritesPerMeal(int caloriesPerMeal)
        {
            this.caloriesPerMeal = caloriesPerMeal;
        }

        public int Eat()
        {
            return 3 * caloriesPerMeal;
        }

        public abstract void Breathing();
        public abstract void Growing();
        public abstract void Reproduction();

    }
}
