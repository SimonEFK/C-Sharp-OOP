using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Models.Gyms
{
    public abstract class Gym : IGym
    {
        private string name;
        private double equipmentWeight;
        private readonly List<IEquipment> equipment;
        private readonly List<IAthlete> athletes;

        protected Gym(string name,int capacity)
        {
            Capacity = capacity;
            equipment = new List<IEquipment>();
            athletes = new List<IAthlete>();
            Name = name;

        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Gym name cannot be null or empty.");
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public double EquipmentWeight
        {
            get => this.equipment.Sum(x => x.Weight); 
            
        }

        public ICollection<IEquipment> Equipment => this.equipment;

        public ICollection<IAthlete> Athletes => this.athletes;

        public void AddAthlete(IAthlete athlete)
        {
            if (this.athletes.Count + 1 > Capacity)
            {
                throw new InvalidOperationException("Not enough space in the gym.");
            }
            this.athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in this.athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name} is a {GetType().Name}:");
            if (this.athletes.Count == 0)
            {
                sb.AppendLine($"Athletes: No athletes");
            }
            else
            {
                sb.AppendLine($"Athletes:{string.Join(", ",this.athletes.Select(x=>x.FullName))}");
            }
            sb.AppendLine($"Equipment total count: {this.equipment.Count}");
            sb.AppendLine($"Equipment total weight: {this.EquipmentWeight:f2} grams");
            return sb.ToString().TrimEnd();

        }

        public bool RemoveAthlete(IAthlete athlete) => this.athletes.Remove(athlete);



    }
}
