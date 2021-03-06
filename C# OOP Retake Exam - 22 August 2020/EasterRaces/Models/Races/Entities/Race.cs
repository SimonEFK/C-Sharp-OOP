using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Races.Entities
{
    public class Race : IRace
    {
        private string name;
        private int laps;
        private readonly List<IDriver> drivers;

        public Race(string name,int laps)
        {
            drivers = new List<IDriver>();
            Name = name;
            Laps = laps;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {name} cannot be less than 5 symbols.");
                }
                name = value;
            }
        }

        public int Laps
        {
            get => laps;
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException($"Laps cannot be less than 1.");
                }
                laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers { get => this.drivers; }

        public void AddDriver(IDriver driver)
        {
            if (driver==null)
            {
                throw new ArgumentNullException(nameof(IDriver), "Driver cannot be null.");
            }
            if (driver.CanParticipate==false)
            {
                throw new ArgumentException($"Driver {driver.Name} could not participate in race.");
            }
            if (this.drivers.Contains(driver))
            {
                throw new ArgumentNullException(nameof(IDriver), $"Driver {driver.Name} is already added in {this.Name} race.");
            }
            this.drivers.Add(driver);
        }
    }
}
