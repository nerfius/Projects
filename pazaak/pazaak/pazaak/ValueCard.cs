using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace pazaak
{
    class ValueCard : Card
    {
        private int value { public get; set; }

        public ValueCard(Texture2D cardTexture, Vector2 coords, int value)
            : base(cardTexture, coords)
        {
            this.value = value; 
        }

        public override void DrawCard(SpriteBatch spriteBatch)
        {
            base.DrawCard(spriteBatch);
            spriteBatch.DrawString(spriteFont, text, position, color); // parameters are currently placeholders
            // spriteFont from main
            // text is value of card
        }
    }
}
