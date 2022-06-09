using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] webSites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            IBrowser smartphone = new Smartphone();
            ICall brickPhone = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Any(x => !char.IsDigit(x)))
                {
                    Console.WriteLine($"Invalid number!");
                }
                else
                {
                    if (numbers[i].Length == 7)
                    {
                        brickPhone.Call(numbers[i]);
                    }
                    else if (numbers[i].Length==10)
                    {
                        smartphone.Call(numbers[i]);
                    }
                }
            }
            for (int i = 0; i < webSites.Length; i++)
            {
                if (webSites[i].Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine($"Invalid URL!");
                }
                else
                {
                    smartphone.Browse(webSites[i]);
                }
            }
        }
    }
}
