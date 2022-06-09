using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping_Spree
{
    public class Person
    {

        private string name;
        private decimal money;
        private List<Product> bagWithProducts;


        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagWithProducts = new List<Product>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;

            }
        }
        public decimal Money
        {
            get { return money; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                money = value;
            }
        }






        public void BuyProduct(Product product)
        {

            if (Money < product.Cost)
            {
                throw new ArgumentException($"{Name} can't afford {product.Name}");

            }


            Money -= product.Cost;
            bagWithProducts.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");



        }
        public override string ToString()
        {
            if (bagWithProducts.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }

            var products = bagWithProducts.Select(p => p.Name);

            return $"{Name} - {string.Join(", ", products)}";
        }
    }
}
