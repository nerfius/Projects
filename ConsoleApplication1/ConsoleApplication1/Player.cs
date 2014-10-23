using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Player
    {
        public int cardValue { get; set; }
        public int score { get; set; }

        public Player()
        {
            cardValue = 0;
            score = 0;
        }

        public virtual void AddValueToPool()
        {
            cardValue += 1;
        }
    }
}
