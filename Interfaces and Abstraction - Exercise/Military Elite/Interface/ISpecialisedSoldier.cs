using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;

namespace Military_Elite.Interface
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get; }
    }
}
