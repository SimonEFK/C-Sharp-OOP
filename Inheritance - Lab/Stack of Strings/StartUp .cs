using System;
using System.Collections.Generic;

namespace Stack_of_Strings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            Console.WriteLine($"{stack.IsEmpty()}");
            stack.AddRange(new List<string>() { "1", "2", "3", "4" });
            Console.WriteLine($"{string.Join(" ", stack)}");
            stack.IsEmpty();
        }

    }
}
