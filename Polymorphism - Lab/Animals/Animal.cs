using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {


        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        private string name;
        private string favouriteFood;


        public string Name { get => name; protected set => name = value; }
        public string FavouriteFood { get => favouriteFood; protected set => favouriteFood = value; }

        public virtual string ExplainSelf() => $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        
    }

}
