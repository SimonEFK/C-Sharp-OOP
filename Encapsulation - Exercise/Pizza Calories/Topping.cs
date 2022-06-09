using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Topping
    {
        private HashSet<string> allowedToppings = new HashSet<string>() { "MEAT", "VEGGIES", "CHEESE", "SAUCE" };

        private string typeTopping;
        private double toppingGrams;

        public Topping(string typeTopping, double toppingGrams)
        {
            TypeTopping = typeTopping;
            ToppingGrams = toppingGrams;
        }

        public string TypeTopping
        {
            get { return typeTopping; }
            private set
            {
                var toppingToUpper = value.ToUpper();
                if (allowedToppings.Contains(toppingToUpper) == false)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                typeTopping = value;
            }
        }

        public double ToppingGrams
        {
            get => toppingGrams; set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{TypeTopping} weight should be in the range [1..50].");
                }
                toppingGrams = value;
            }
        }
        internal double GetToppingGrams()
        {
            double toppingModifier = 0.0;
            if (TypeTopping.ToUpper() == "MEAT")
            {
                toppingModifier = 1.2;
            }
            else if (TypeTopping.ToUpper() == "VEGGIES")
            {
                toppingModifier = 0.8;
            }
            else if (TypeTopping.ToUpper() == "CHEESE")
            {
                toppingModifier = 1.1;
            }
            else if (TypeTopping.ToUpper() == "SAUCE")
            {
                toppingModifier = 0.9;
            }
            return ToppingGrams * 2 * toppingModifier;
        }
    }
}
