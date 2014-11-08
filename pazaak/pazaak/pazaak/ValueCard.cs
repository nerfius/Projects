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
        public int value { get; private set; }
        private string valueString;
        private Vector2 textPos;

        public ValueCard(Texture2D cardTexture, Vector2 coords, int value)
            : base(cardTexture, coords)
        {
            this.value = value;
            valueString = value.ToString();
            textPos = coords; // for now
        }

        public override void DrawCard(SpriteBatch spriteBatch, SpriteFont spriteFont)
        {
            base.DrawCard(spriteBatch, spriteFont);
            spriteBatch.DrawString(spriteFont, valueString, textPos, Color.White);
        }
    }
}
