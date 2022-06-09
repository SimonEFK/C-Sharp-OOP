using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_of_Strings
{
    public class StackOfStrings : Stack<string>
    {



        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }
        public void AddRange(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Push(item);
            }
        }
    }
}
