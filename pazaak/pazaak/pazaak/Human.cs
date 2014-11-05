using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pazaak
{
    class Human : Player
    {
        public Human() : base() { }

        public override void pickCard() // Change this method
        {
            Random rnd = new Random();
            this.cardValue += rnd.Next(1, 10);
        }
    }
}
