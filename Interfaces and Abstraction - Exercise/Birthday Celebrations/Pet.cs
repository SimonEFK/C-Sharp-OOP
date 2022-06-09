using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public class Pet : IBirthdates
    {
        public Pet(string name, string birthdates)
        {
            Name = name;
            Birthdates = birthdates;
        }

        public string Name { get; private set; }
        public string Birthdates { get; private set; }

    }
}
