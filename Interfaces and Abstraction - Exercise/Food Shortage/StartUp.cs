using BorderControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> people = new Dictionary<string, IBuyer>();


            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 4)
                {
                    string name = input[0];
                    var age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdat = input[3];
                    people[name] = new Citizen(name, age, id, birthdat);


                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string groupName = input[2];
                    people[name] = new Rebel(name, age, groupName);
                }
            }

            string buyer = Console.ReadLine();
            while (buyer != "End")
            {
                if (people.ContainsKey(buyer))
                {
                    people[buyer].BuyFood();

                }
                buyer = Console.ReadLine();
            }
            Console.WriteLine($"{people.Values.Sum(x => x.Food)}");
        }
    }
}

