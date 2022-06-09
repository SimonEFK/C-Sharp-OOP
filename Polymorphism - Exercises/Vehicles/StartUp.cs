using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var carFuelQuantity = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);

            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);



            Vehicle car = new Car(carFuelQuantity, carConsumption);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumption); ;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = line[0];
                string type = line[1];
                double amount = double.Parse(line[2]);

                if (action.ToUpper() == "DRIVE")
                {
                    if (type==nameof(Car))
                    {
                        try
                        {
                            car.Drive(amount);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine($"{ex.Message}");
                        }
                    }
                    else
                    {
                        try
                        {
                            truck.Drive(amount);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                    }
                }                
                else
                {
                    if (type==nameof(Car))
                    {
                        car.Refill(amount);
                    }
                    else
                    {
                        truck.Refill(amount);
                    }

                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");



        }
    }
}
