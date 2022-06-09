using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
            List<Product> productsList = new List<Product>();
            string[] persons = Console.ReadLine().Split(";");
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    string[] data = persons[i].Split('=');
                    string name = data[0];
                    decimal money = decimal.Parse(data[1]);
                    Person person = new Person(name, money);
                    listOfPersons.Add(person);
                }
                for (int i = 0; i < products.Length; i++)
                {
                    string[] data = products[i].Split('=');
                    string name = data[0];
                    decimal cost = decimal.Parse(data[1]);
                    Product product = new Product(name, cost);
                    productsList.Add(product);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return;

            }

            string input;



            while ((input = Console.ReadLine()) != "END")
            {
                string[] elements = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string currentPerson = elements[0];
                string currentProduct = elements[1];

                int index = listOfPersons.FindIndex(x => x.Name == currentPerson);
                int productIndex = productsList.FindIndex(x => x.Name == currentProduct);
                try
                {
                    listOfPersons[index].BuyProduct(productsList[productIndex]);
                }
                catch (Exception exception)
                {

                    Console.WriteLine($"{exception.Message}");

                }
            }



            foreach (var item in listOfPersons)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }

    }
}

