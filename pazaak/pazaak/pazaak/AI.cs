using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pazaak
{
    class AI : Player
    {
        public AI() : base() { }

        public override void PickCard() // Change this method
        {
            Random rnd = new Random();
            int tempVal = rnd.Next(1, 10);
            ValueCard tempCard = new ValueCard(tempVal);

            if (cardValue < 11)
            {
                cardsOnTable.Add(tempCard);
                cardValue += tempVal;
            }
            else
                if (rnd.Next(11, 20) > cardValue)
                {
                    cardsOnTable.Add(tempCard); // annars så räknas det som en stand
                    cardValue += tempVal;
                }

            //cardValue += rnd.Next(1, 10);
        }
    }
}
