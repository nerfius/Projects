using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace pazaak
{
    abstract class Player // because this class is never used directly
    {
        public int cardValue { get; set; }
        public int score { get; set; }
        protected List<Card> cardsOnTable;

        public Player()
        {
            cardValue = 0;
            score = 0;
        }

        public virtual void pickCard()
        {
            cardValue += 1;
        }

        public void DrawCards(SpriteBatch spriteBatch)
        {
            foreach (Card c in cardsOnTable)
            {
                c.DrawCard(spriteBatch);
            }
        }
    }
}
