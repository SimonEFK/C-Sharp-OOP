using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Truck : Vehicle
    {
        private const double AirConditionModifier = 1.6;
        public Truck(double fuelQuantity, double FuelConsumption,double tankCapacity) : base(fuelQuantity, FuelConsumption,tankCapacity)
        {

            this.airConditionModifier = AirConditionModifier;

        }

        
        public override void Refill(double amount)
        {
            if (amount>this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            base.Refill(amount*0.95);
        }
    }
}
