using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;

namespace Military_Elite.Interface
{
    public interface IMissions
    {
        public string CodeName { get; }
        public Status State { get; }

        public void CompleteMission();
    }
}
