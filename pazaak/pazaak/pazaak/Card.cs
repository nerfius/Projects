using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace pazaak
{
    abstract class Card
    {
        private Texture2D cardTexture;
        private Vector2 coords;

        public Card(Texture2D cardTexture, Vector2 coords)
        {
            this.cardTexture = cardTexture;
            this.coords = coords;
        }
        public virtual void DrawCard(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            spriteBatch.Draw(cardTexture, coords, Color.White);
        }
    }
}
