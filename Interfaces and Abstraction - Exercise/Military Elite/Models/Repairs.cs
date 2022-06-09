﻿using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    public class Repairs : IRepairs
    {
        public Repairs(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }


        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}
