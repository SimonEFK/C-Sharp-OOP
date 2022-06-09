using System;
using System.Collections.Generic;

namespace Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            try
            {
                string pizzaName = Console.ReadLine().Split(' ')[1];
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string flourType = input[1];
                string bakingTechnique = input[2];
                double doughGrams = double.Parse(input[3]);

                List<Pizza> pizzas = new List<Pizza>();

                Dough dought = new Dough(flourType, bakingTechnique, doughGrams);
                Pizza pizza = new Pizza(pizzaName, dought);

                pizzas.Add(pizza);
                string toppings = Console.ReadLine();
                while (toppings != "END")
                {
                    string[] parts = toppings.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string type = parts[1];
                    double weight = double.Parse(parts[2]);
                    Topping topping = new Topping(type, weight);
                    pizza.AddTopping(topping);
                    toppings = Console.ReadLine();
                }
                foreach (var item in pizzas)
                {
                    Console.WriteLine($"{item.Name} - {item.TotalCalories():f2} Calories.");

                }


            }
            catch (Exception exp)
            {

                Console.WriteLine($"{exp.Message}");
            }
        }
    }
}
