using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

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

        public virtual void pickCard(Texture2D cardTexture, Vector2 cardPos)
        {
            cardValue += 1;
        }

        public void DrawCards(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            foreach (ValueCard vc in cardsOnTable)
            {
                vc.DrawCard(spriteBatch, spriteFont); // PROBLEM
            }
        }
    }
}
