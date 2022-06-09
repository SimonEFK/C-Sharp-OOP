using System;
using System.Collections.Generic;
using System.Text;

namespace Salary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public Person(string firstName, string lastName, int age, decimal salary) : this(firstName, lastName, age)
        {

            Salary = salary;
        }

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int Age { get => age; private set => age = value; }
        public decimal Salary { get => salary; private set => salary = value; }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary += Salary * (percentage / 2) / 100;

            }
            else
            {
                Salary += Salary * percentage / 100;
            }
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }

    }
}
