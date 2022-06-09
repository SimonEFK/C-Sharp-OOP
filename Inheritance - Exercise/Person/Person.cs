using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {

        string name;
        int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => this.name; set { this.name = value; } }
        public int Age { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            return sb.ToString().Trim();
        }
    }
}
