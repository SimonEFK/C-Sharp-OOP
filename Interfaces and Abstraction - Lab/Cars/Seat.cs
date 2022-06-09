using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model, string coler)
        {
            Model = model;
            Color = coler;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return $"Breaak!";
        }
        public override string ToString()
        {
            return $"{this.Color} Seat {this.Model}";
        }
    }
}
