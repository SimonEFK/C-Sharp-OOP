using System;
using System.Collections.Generic;
using System.Text;

namespace Random_List
{
    class RandomList : List<string>
    {


        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, Count);
            index = rnd.Next(0, Count);
            index = rnd.Next(0, Count);
            return this[index];
        }
        public void RandomRemove()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, Count);
            index = rnd.Next(0, Count);
            index = rnd.Next(0, Count);
            index = rnd.Next(0, Count);
            RemoveAt(index);
        }
    }
}
