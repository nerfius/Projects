using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pazaak
{
    class Human : Player
    {
        public Human() : base() { }

        public override void pickCard(Texture2D cardTexture, Vector2 cardPos) // Change this method
        {
            Random rnd = new Random();
            this.cardValue += rnd.Next(1, 10);
        }
    }
}
