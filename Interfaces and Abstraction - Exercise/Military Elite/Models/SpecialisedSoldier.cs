﻿using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
