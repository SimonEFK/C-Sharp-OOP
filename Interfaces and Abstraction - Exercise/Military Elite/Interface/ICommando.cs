using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interface
{
    public interface ICommando : ISpecialisedSoldier
    {
        public IReadOnlyCollection<IMissions> Missions { get; }

        public void AddMission(IMissions newMission);


    }
}
