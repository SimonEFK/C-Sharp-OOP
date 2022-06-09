using System;

namespace Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person child;
            if (age < 0)
            {
                return;
            }
            if (age <= 15)
            {
                child = new Child(name, age);
            }
            else
            {
                child = new Person(name, age);
            }

            Console.WriteLine(child);



        }
    }
}
