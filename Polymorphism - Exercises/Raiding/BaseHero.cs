using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            this.Power = power;

        }

        public string Name { get; protected set; }
        public int Power { get; protected set; }


        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name} ";
        }
    }
}
