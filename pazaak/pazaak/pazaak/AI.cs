using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pazaak
{
    class AI : Player
    {
        public AI() : base() { }

        public override void pickCard(Texture2D cardTexture, Vector2 cardPos) // Change this method
        {
            Random rnd = new Random();
            int tempVal = rnd.Next(1, 10);
            ValueCard tempCard = new ValueCard(cardTexture, cardPos, tempVal);  // onödigt att skapa ett nytt kort om vi ännu inte vet om ett nytt kort ska dras -NF

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
        }
    }
}
