using System;

namespace Class_Box_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double l = double.Parse(Console.ReadLine());
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Box box = new Box(l, w, h);
                Console.Write($"{box.ToString()}");

            }
            catch (Exception exception)
            {
                Console.WriteLine($"{exception.Message}");
            }






        }
    }
}
