using System;
using System.Collections.Generic;
using System.Text;

namespace Need_for_Speed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 3;
            FuelConsumption = DefaultFuelConsumption;


        }
        public override void Drive(double distance)
        {
            Fuel -= FuelConsumption * distance;
        }
    }
}
