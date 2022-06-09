using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Pizza
    {

        private string name;
        private List<Topping> toppings = new List<Topping>();
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }


        public Dough Dough { get => dough; private set => dough = value; }
        //public IReadOnlyCollection<Topping> Toppings { get => toppings;}

        public void AddTopping(Topping topping)
        {

            if (toppings.Count > 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);

        }

        public double TotalCalories()
        {
            double totalCalories = 0.0;
            totalCalories += dough.DoughGrams();
            foreach (var item in toppings)
            {
                totalCalories += item.GetToppingGrams();
            }
            return totalCalories;
        }
    }
}
