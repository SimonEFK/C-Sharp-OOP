using System;

namespace Telephony
{
    class Smartphone : IBrowser
    {

        public void Browse(string website)
        {
            Console.WriteLine($"Browsing: {website}!");
        }

        public void Call(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
