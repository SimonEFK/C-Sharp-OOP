using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditionModifier = 0.9;
        public Car(double fuelQuantity, double fuenConsumption,double tankCapacity) : base(fuelQuantity, fuenConsumption,tankCapacity)
        {
            this.airConditionModifier = AirConditionModifier;
        }
        
    }
}
