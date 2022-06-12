using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<ICar> carRepository;
        private readonly IRepository<IDriver> driverRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            carRepository = new CarRepository();
            driverRepository = new DriverRepository();
            raceRepository = new RaceRepository();

        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = driverRepository.GetByName(driverName);
            ICar car = carRepository.GetByName(carModel);
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }
            driver.AddCar(car);
            carRepository.Remove(car);
            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            IRace race = raceRepository.GetByName(raceName);
            IDriver driver = driverRepository.GetByName(driverName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {raceName} could not be found.");
            }
            race.AddDriver(driver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {

            ICar car = carRepository.GetByName(model);
            if (car != null)
            {
                throw new ArgumentException($"Car {model} is already created.");
            }
            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }
            carRepository.Add(car);
            return $"{car.GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            IDriver driver = driverRepository.GetByName(driverName);

            if (driver != null)
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }
            driverRepository.Add(new Driver(driverName));
            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            IRace race = raceRepository.GetByName(name);
            if (race != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }
            this.raceRepository.Add(new Race(name, laps));
            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            IRace race = raceRepository.GetByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }
            var result = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Driver {result[0].Name} wins {raceName}");
            result[0].WinRace();
            sb.AppendLine($"Driver {result[1].Name} is second in {raceName}");
            sb.AppendLine($"Driver {result[2].Name} is third in {raceName}");
            raceRepository.Remove(race);
            return sb.ToString().TrimEnd();



        }
    }
}
