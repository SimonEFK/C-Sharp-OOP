using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirConditionModifier = 1.4;
        public Bus(double fuelQuantity, double fuenConsumption, double tankCapacity) : base(fuelQuantity, fuenConsumption, tankCapacity)
        {
            this.airConditionModifier = AirConditionModifier;
        }

        public void AirConditionOFF()
        {
            this.airConditionModifier = 0;
        }
        public void AirConditionON()
        {
            this.airConditionModifier = AirConditionModifier;
        }
        

    }
}
