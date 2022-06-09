using System;
using System.Collections.Generic;
using System.Text;

namespace Need_for_Speed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            DefaultFuelConsumption = 1.25;
            FuelConsumption = DefaultFuelConsumption;
        }


        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double distance)
        {
            Fuel -= distance * FuelConsumption;
        }

    }
}
