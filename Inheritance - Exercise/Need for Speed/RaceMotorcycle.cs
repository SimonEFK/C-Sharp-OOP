using System;
using System.Collections.Generic;
using System.Text;

namespace Need_for_Speed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 8;
            FuelConsumption = DefaultFuelConsumption;
        }

        public override void Drive(double distance)
        {
            Fuel -= FuelConsumption * distance;
        }




    }
}
