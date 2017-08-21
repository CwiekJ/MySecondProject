using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;

namespace MySecondProject
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player = new Player();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player.Load(Content);
        }

        protected override void UnloadContent()
        {
                // TODO: Unload any non ContentManager content here
            }

            protected override void Update(GameTime gameTime)
        {
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back ==
                    ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

                // TODO: Add your update logic here
                float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
                player.Update(deltaTime);

                base.Update(gameTime);
            }
           protected override void Draw(GameTime gameTime) {
                GraphicsDeviceClear(Color.CornflowerBlue);

                // TODO: Add your drawing code here
                spriteBatch.Begin();
                player.Draw(spriteBatch);
                spriteBatch.End();

                base.Draw(gameTime);
            }
        }
    }
