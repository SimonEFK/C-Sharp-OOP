using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var carFuelQuantity = double.Parse(carInfo[1]);
            var carConsumption = double.Parse(carInfo[2]);
            var carCapacity = double.Parse(carInfo[3]);

            var truckFuelQuantity = double.Parse(truckInfo[1]);
            var truckConsumption = double.Parse(truckInfo[2]);
            var truckCapacity = double.Parse(truckInfo[3]);

            var busFuelQuantity = double.Parse(busInfo[1]);
            var busConsumption = double.Parse(busInfo[2]);
            var busCapacity = double.Parse(busInfo[3]);


            Vehicle car = new Car(carFuelQuantity, carConsumption, carCapacity);
            Vehicle truck = new Truck(truckFuelQuantity, truckConsumption, truckCapacity);
            Vehicle bus = new Bus(busFuelQuantity, busConsumption, busCapacity);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = line[0];
                string type = line[1];
                double amount = double.Parse(line[2]);
                if (action.ToUpper() == "REFUEL")
                {
                    try
                    {
                        if (type == nameof(Car))
                        {
                            car.Refill(amount);
                        }
                        else if (type == nameof(Bus))
                        {
                            bus.Refill(amount);
                        }
                        else
                        {
                            truck.Refill(amount);
                        }

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}");

                    }


                }
                else if (action.ToUpper() == "DRIVE")
                {
                    try
                    {

                        if (type == nameof(Car))
                        {
                            car.Drive(amount);
                        }
                        else if (type == nameof(Bus))
                        {
                            bus.Drive(amount);
                        }
                        else
                        {
                            truck.Drive(amount);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                        
                    }

                }
                //DriveEmpty
                else
                {
                                        
                    try
                    {
                        
                        ((Bus)bus).AirConditionOFF();
                        bus.Drive(amount);
                        ((Bus)bus).AirConditionON();

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                       
                    }
                }



            }


            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");



        }
    }
}
