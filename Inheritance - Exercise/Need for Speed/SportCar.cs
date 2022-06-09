using System;
using System.Collections.Generic;
using System.Text;

namespace Need_for_Speed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
            FuelConsumption = DefaultFuelConsumption;
        }
        public override void Drive(double distance)
        {
            Fuel -= FuelConsumption * distance;
        }
    }
}
