using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Snake:Reptile
    {
        protected bool isPoisonous;

        public Snake(string name, int age, bool isApexPredator, int caloriesPerMeal, double tailLength,
            bool isPoisonous) : base(name, age, isApexPredator, caloriesPerMeal, tailLength)
        {
            this.isPoisonous = isPoisonous;
        }

        public override string ToString()
        {
            return "Snake:{" + base.ToString() + $",isPoisonous={this.isPoisonous}}}";
        }

        public bool GetIsPoisonous()
        {
            return this.isPoisonous;
        }

        public void SetIsPoisonous(bool isPoisonous)
        {
            this.isPoisonous = isPoisonous;
        }

        public void Dance()
        {
            Console.WriteLine("Snake is dancing :)");
        }

    }
}
