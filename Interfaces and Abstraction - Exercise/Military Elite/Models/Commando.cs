using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    class Commando : SpecialisedSoldier, ICommando
    {
        private List<IMissions> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMissions>();
        }

        public IReadOnlyCollection<IMissions> Missions => missions.AsReadOnly();

        public void AddMission(IMissions newMission)
        {
            missions.Add(newMission);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            foreach (var item in Missions)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
