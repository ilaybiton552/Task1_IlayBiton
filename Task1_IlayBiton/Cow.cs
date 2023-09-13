using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Cow:Mammal
    {
        protected int numOfWelp;

        public Cow(string name, int age, bool isApexPredator, int caloriesPerMeal, int caloriesInMilk, 
            int monthsForPregnancy, int numOfWelp) : base(name, age, isApexPredator, caloriesPerMeal, 
                caloriesInMilk, monthsForPregnancy)
        {
            this.numOfWelp = numOfWelp;
        }

        public override string ToString()
        {
            return "Cow:{" + base.ToString() + $",numOfWelp={this.numOfWelp}}}";
        }

        public int GetNumOfWelp()
        {
            return this.numOfWelp;
        }

        public void SetNumOfWelp(int numOfWelp)
        {
            this.numOfWelp = numOfWelp;
        }

        public new int Eat()
        {
            return base.Eat() / 4;
        }

    }
}
