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

        public override void pickCard() // Change this method
        {
            Random rnd = new Random();
            int tempVal = rnd.Next(1, 10);
            ValueCard tempCard;

            if (cardValue < 11)
            {
                tempCard = new ValueCard(card_sprite, new Vector2(stackCoords.X + (cardsOnTable.Count*24) , stackCoords.Y), tempVal); 
                cardsOnTable.Add(tempCard);
                cardValue += tempVal;
            }
            else
                if (rnd.Next(11, 20) > cardValue)
                {
                    tempCard = new ValueCard(card_sprite, new Vector2(stackCoords.X + float (cardsOnTable.Count*24) , stackCoords.Y), tempVal);
                    cardsOnTable.Add(tempCard);
                    cardValue += tempVal;
                }
        }
    }
}
