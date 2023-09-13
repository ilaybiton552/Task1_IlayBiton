using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_IlayBiton
{
    public class Crocodile:Reptile
    {
        protected bool isTeethCare;

        public Crocodile(string name, int age, bool isApexPredator, int caloriesPerMeal, double tailLength, 
            bool isTeethCare) : base(name, age, isApexPredator, caloriesPerMeal, tailLength)
        {
            this.isTeethCare = isTeethCare;
        }

        public override string ToString()
        {
            return "Crocodile:{" + base.ToString() + $",isTeethCare={this.isTeethCare}}}";
        }

        public bool GetIsTeethCare()
        {
            return this.isTeethCare;
        }

        public void SetIsTeethCare(bool isTeethCare)
        {
            this.isTeethCare = isTeethCare;
        }

    }
}
