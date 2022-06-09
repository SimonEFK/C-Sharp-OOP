using System;
using System.Collections.Generic;
using System.Text;
using Military_Elite.Enums;
using Military_Elite.Interface;

namespace Military_Elite.Models
{
    public class Mission : IMissions
    {
        public Mission(string codeName, Status state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; private set; }

        public Status State { get; private set; }

        public void CompleteMission()
        {
            State = Status.Finished;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }
}
