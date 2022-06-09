using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepairs> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepairs>();
        }

        public IReadOnlyCollection<IRepairs> Repairs => repairs.AsReadOnly();

        public void AddRepair(IRepairs repairs)
        {
            this.repairs.Add(repairs);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (var item in Repairs)
            {
                sb.AppendLine($" {item.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
