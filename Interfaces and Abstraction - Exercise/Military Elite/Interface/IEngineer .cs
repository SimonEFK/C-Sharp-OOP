using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interface
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public IReadOnlyCollection<IRepairs> Repairs { get; }

        public void AddRepair(IRepairs repairs);
    }
}
