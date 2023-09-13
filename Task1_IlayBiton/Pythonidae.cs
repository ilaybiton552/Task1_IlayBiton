using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Pythonidae : Snake
    {
        protected string color;

        public Pythonidae(string name, int age, bool isApexPredator, int caloriesPerMeal,
            double tailLength, bool isPoisonous, string color) : base(name, age, isApexPredator,
                caloriesPerMeal, tailLength, isPoisonous)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "Pythonidae:{" + base.ToString() +$",color='{this.color}'}}";
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

    }
}
