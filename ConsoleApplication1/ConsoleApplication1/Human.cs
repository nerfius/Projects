using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Human : Player
    {
        public Human() { }

        public override void AddValueToPool()
        {
            Random rnd = new Random();
            Console.WriteLine("Waiting for human...");
            Console.ReadKey();
            this.cardValue += rnd.Next(1, 10);
        }
    }
}
