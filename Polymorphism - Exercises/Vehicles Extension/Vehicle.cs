using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected double airConditionModifier;
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;

        }

        public double FuelQuantity
        {
            get => fuelQuantity; set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {

                    fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }




        public void Drive(double distance)
        {
            double fuelRequaried = (FuelConsumption + airConditionModifier) * distance;
            if (this.FuelQuantity < fuelRequaried)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            this.FuelQuantity -= fuelRequaried;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refill(double amount)
        {
            
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (amount + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
            }
            this.FuelQuantity += amount;
        }


    }
}
