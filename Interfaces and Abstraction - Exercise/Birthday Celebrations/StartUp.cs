using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthdates> population = new List<IBirthdates>();

            string line = Console.ReadLine();
            while (line != "End")
            {
                string[] data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = data[0];

                IBirthdates citizen = null;

                if (type == nameof(Citizen))
                {
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birthdate = data[4];
                    citizen = new Citizen(name, age, id, birthdate);
                    population.Add(citizen);
                }
                else if (type == nameof(Pet))
                {
                    string name = data[1];
                    string birthdate = data[2];
                    citizen = new Pet(name, birthdate);
                    population.Add(citizen);
                }

                line = Console.ReadLine();
            }

            string invalidDigits = Console.ReadLine();

            foreach (var item in population.Where(x => x.Birthdates.EndsWith(invalidDigits)))
            {
                Console.WriteLine($"{item.Birthdates}");
            }
        }
    }
}

