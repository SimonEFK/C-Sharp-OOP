using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Interface
{
    public interface IRepairs
    {
        public string PartName { get; }
        public int HoursWorked { get; }
    }
}
