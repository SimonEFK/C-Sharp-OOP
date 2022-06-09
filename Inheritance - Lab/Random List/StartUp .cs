using System;

namespace Random_List
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("1");
            list.RandomRemove();
            list.Add("2");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{list.RandomString()}");
            }

        }
    }
}
