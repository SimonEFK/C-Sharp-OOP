using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();


            string type = Console.ReadLine();
            while (type != "Beast!")
            {
                string[] animalData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = animalData[0];
                int age = int.Parse(animalData[1]);

                Animal animal = null;
                if (age > 0)
                {
                    string gender = animalData[2];
                    if (type == "Dog")
                    {
                        animal = new Dog(name, age, gender);
                    }
                    else if (type == "Cat")
                    {

                        animal = new Cat(name, age, gender);
                    }
                    else if (type == "Frog")
                    {
                        animal = new Frog(name, age, gender);
                    }
                    else if (type == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else
                    {
                        animal = new Tomcat(name, age);
                    }

                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    type = Console.ReadLine();
                    continue;
                }
                animalList.Add(animal);
                type = Console.ReadLine();
            }
            foreach (var item in animalList)
            {
                Console.WriteLine($"{item.GetType().Name}{Environment.NewLine}{item.Name} {item.Age} {item.Gender}{Environment.NewLine}{item.ProduceSound()}");
            }
        }
    }
}
