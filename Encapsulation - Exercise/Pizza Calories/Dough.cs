using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Dough
    {


        private HashSet<string> allowedDoughType = new HashSet<string>() { "WHITE", "WHOLEGRAIN" };
        private HashSet<string> allowedTechnique = new HashSet<string>() { "CRISPY", "CHEWY", "HOMEMADE" };

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }

        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException($"Dough weight should be in the range [1..200].");
                }
                grams = value;
            }
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                var valueToUpper = value.ToUpper();
                if (allowedDoughType.Contains(valueToUpper) == false)
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;
            private set
            {
                if (allowedTechnique.Contains(value.ToUpper()) == false)
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        internal double DoughGrams()
        {

            double doughModifier = 0.0;
            double bakingModifier = 0.0;
            if (FlourType.ToUpper() == "WHITE")
            {
                doughModifier = 1.5;
            }
            else if (FlourType.ToUpper() == "WHOLEGRAIN")
            {
                doughModifier = 1.0;
            }
            if (BakingTechnique.ToUpper() == "CRISPY")
            {
                bakingModifier = 0.9;
            }
            else if (BakingTechnique.ToUpper() == "CHEWY")
            {
                bakingModifier = 1.1;
            }
            else if (BakingTechnique.ToUpper() == "HOMEMADE")
            {
                bakingModifier = 1.0;
            }

            return Grams * 2 * doughModifier * bakingModifier;

        }


    }
}
