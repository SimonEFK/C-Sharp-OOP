using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionModifier = 0.9;
        public Car(double fuelQuantity, double fuenConsumption) : base(fuelQuantity, fuenConsumption)
        {
            this.airConditionModifier = AirConditionModifier;
        }
        
    }
}
