using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pazaak
{
    class AI : Player
    {
        public AI() : base() { }

        public override void AddValueToPool() // Change this method
        {
            Random rnd = new Random();
            cardValue += rnd.Next(1, 10);
        }
    }
}
