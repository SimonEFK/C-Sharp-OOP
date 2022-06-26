using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Equipment.Contracts;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private EquipmentRepository equipment;
        private List<IGym> gyms;

        public Controller()
        {
            this.equipment = new EquipmentRepository();
            this.gyms = new List<IGym>();
        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            IAthlete athlete = null;
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            if (athleteType == nameof(Boxer))
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
            }
            else if (athleteType == nameof(Weightlifter))
            {
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
            }
            else
            {
                throw new InvalidOperationException($"Invalid athlete type.");
            }

            if (athlete.GetType().Name == nameof(Boxer) && gym.GetType().Name == nameof(BoxingGym))
            {
                gym.AddAthlete(athlete);
                return $"Successfully added {athleteType} to {gymName}.";
            }
            else if (athlete.GetType().Name == nameof(Weightlifter) && gym.GetType().Name == nameof(WeightliftingGym))
            {
                gym.AddAthlete(athlete);
                return $"Successfully added {athleteType} to {gymName}.";
            }
            else
            {
                throw new InvalidOperationException($"The gym is not appropriate.");
            }

        }

        public string AddEquipment(string equipmentType)
        {
            IEquipment equipment = null;
            if (equipmentType == nameof(BoxingGloves))
            {
                equipment = new BoxingGloves();
            }
            else if (equipmentType == nameof(Kettlebell))
            {
                equipment = new Kettlebell();
            }
            else
            {
                throw new InvalidOperationException("Invalid equipment type.");
            }
            this.equipment.Add(equipment);
            return $"Successfully added { equipmentType}.";
        }

        public string AddGym(string gymType, string gymName)
        {
            IGym gym = null;
            if (gymType == nameof(BoxingGym))
            {
                gym = new BoxingGym(gymName);
            }
            else if (gymType == nameof(WeightliftingGym))
            {
                gym = new WeightliftingGym(gymName);
            }
            else
            {
                throw new InvalidOperationException("Invalid gym type.");
            }
            this.gyms.Add(gym);
            return $"Successfully added {gymType}.";
        }

        public string EquipmentWeight(string gymName)
        => $"The total weight of the equipment in the gym {gymName} is {this.gyms.FirstOrDefault(x=>x.Name==gymName).EquipmentWeight:f2} grams.";

        public string InsertEquipment(string gymName, string equipmentType)
        {
            IEquipment equipment = this.equipment.FindByType(equipmentType);
            if (equipment == null)
            {
                throw new InvalidOperationException($"There isn’t equipment of type {equipmentType}.");
            }
            IGym gym = this.gyms.FirstOrDefault(x => x.Name == gymName);
            gym.AddEquipment(equipment);
            this.equipment.Remove(equipment);
            return $"Successfully added {equipmentType} to {gymName}.";
        }

        public string Report()
        {
            var sb = new StringBuilder();
            foreach (var item in this.gyms)
            {
                sb.AppendLine($"{item.GymInfo()}");
            }
            return sb.ToString().TrimEnd();
        }

        public string TrainAthletes(string gymName)
        {
            
            int count = 0;

            foreach  (var athlete in this.gyms.First(x => x.Name == gymName).Athletes)
            {                
                athlete.Exercise();
                count++;
            }
            return $"Exercise athletes: {count}.";
        }
    }
}
