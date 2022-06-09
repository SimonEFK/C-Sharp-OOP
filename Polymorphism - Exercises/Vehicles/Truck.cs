using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        private const double AirConditionModifier = 1.6;
        public Truck(double fuelQuantity, double FuelConsumption) : base(fuelQuantity, FuelConsumption)
        {

            this.airConditionModifier = AirConditionModifier;

        }

        
        public override void Refill(double amount)
        {
            base.Refill(amount*0.95);
        }
    }
}
