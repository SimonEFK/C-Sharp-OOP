using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interface
{
    public interface ISpy : ISoldier
    {
        public int CodeNumber { get; }
    }
}
