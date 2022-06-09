using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public interface IBuyer
    {
        public int Food { get; }

        public void BuyFood();

    }
}
