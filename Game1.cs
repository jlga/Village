using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Utilities;


namespace Village
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D logo;
        private Texture2D grass;
        private Texture2D dirt;
        private Rectangle rect;
        Config config;
        Vector2 mapsize;
        Player player;
        Terrain terrain;
        public Game1()
        {
            config = new Config();
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = config.fullscreen;
            graphics.PreferredBackBufferWidth = config.width;
            graphics.PreferredBackBufferHeight = config.height;
            Window.Title = "Village Random Tile Terrain";

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
            mapsize = config.mapsize;
            this.player = new Player();
            terrain = new Terrain();
            terrain.Initialize(mapsize);
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
            logo = Content.Load<Texture2D>("logo");
            grass = Content.Load<Texture2D>("grass_top");
            dirt = Content.Load<Texture2D>("dirt");
            rect = new Rectangle(-128, -128, 256, 256);
            player.Initialize(grass,new Vector2(256,256));

            terrain.LoadContent(grass, dirt);
            GC.Collect();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            KeyboardState KBS = Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.Update(gameTime, KBS);
            base.Update(gameTime);

            terrain.Update(gameTime);
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
            terrain.Draw(spriteBatch);
            player.Draw(spriteBatch);
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
