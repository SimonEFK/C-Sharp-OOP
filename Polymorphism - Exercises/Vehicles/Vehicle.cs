using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected double airConditionModifier;
        protected Vehicle(double fuelQuantity, double fuenConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuenConsumption;

        }

        public double FuelQuantity { get;  set; }
        public double FuelConsumption { get; private set; }





        public virtual void Drive(double distance)
        {
            double fuelRequaried = (FuelConsumption + airConditionModifier) * distance;
            if (this.FuelQuantity < fuelRequaried)
            {
                throw new InvalidOperationException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= fuelRequaried;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refill(double amount)
        {
            this.FuelQuantity += amount;
        }


    }
}
