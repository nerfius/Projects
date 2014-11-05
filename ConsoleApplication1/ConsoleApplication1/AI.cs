using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class AI : Player
    {

        //Testing http://youtu.be/5g_bVCJVFVE
        // ett andra test https://www.youtube.com/watch?v=mSnRq6iyHKg
        public AI() { }

        public override void AddValueToPool()
        {
            Random rnd = new Random();
            Console.WriteLine("ai draws a card...");
            cardValue += rnd.Next(1, 10);
        }
    }
}
