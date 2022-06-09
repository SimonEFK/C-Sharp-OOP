using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Celebrations
{
    public class Citizen : IIdentifiable, IBirthdates
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdates = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdates { get; private set; }
    }
}
