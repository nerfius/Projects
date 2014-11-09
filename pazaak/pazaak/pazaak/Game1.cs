using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace pazaak
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // our fields
        Human humanPlayer;
        AI aiPlayer;
        SpriteFont spriteFont;
        List<Player> players;
        KeyboardState kbState;
        MouseState mState;

        Texture2D button;
        string mousePosX;
        string mousePosY;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.IsMouseVisible = true;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            spriteFont = Content.Load<SpriteFont>("font01");
            humanPlayer = new Human();
            aiPlayer = new AI();
            players = new List<Player>();

            button = Content.Load<Texture2D>("button");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            kbState = Keyboard.GetState();
            if (kbState.IsKeyDown(Keys.Escape))
                this.Exit();

            mState = Mouse.GetState(); // Mus-klick-logik

            if (mState.X <= button.Bounds.Right && mState.X >= button.Bounds.Left
                && mState.Y >= button.Bounds.Top && mState.Y <= button.Bounds.Bottom
                &&  mState.LeftButton == ButtonState.Pressed) // kolla om muspekaren är inom texturens rektangel, och om LMB tryckts ned. Isf Exit
            {
                this.Exit();
            }

            mousePosX = mState.X.ToString(); // mus-koordinater för print
            mousePosY = mState.Y.ToString();
            mousePosX = mousePosX + "," + mousePosY;

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            // Draw everything here
            spriteBatch.Draw(button, new Vector2(0, 0), Color.White); // rita ut knapp
            spriteBatch.DrawString(spriteFont, mousePosX, new Vector2(200, 200), Color.White); // skriv ut muskoordinater
            spriteBatch.DrawString(spriteFont, button.Bounds.Left.ToString(), new Vector2(200, 250), Color.White); // skriv ut knapp-koordinater
            spriteBatch.DrawString(spriteFont, button.Bounds.Right.ToString(), new Vector2(200, 275), Color.White);
            spriteBatch.DrawString(spriteFont, button.Bounds.Top.ToString(), new Vector2(200, 300), Color.White);
            spriteBatch.DrawString(spriteFont, button.Bounds.Bottom.ToString(), new Vector2(200, 325), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
