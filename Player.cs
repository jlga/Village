using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Village
{
    class Player
    {
        public Texture2D PlayerTexture;
        public Vector2 Position;
        public float Rotation;
        public float Speed;
        public bool Active;
        public int Health;
        public int Width
        {
            get { return PlayerTexture.Width; }
        }
        public int Height
        {
            get { return PlayerTexture.Height; }
        }


        public void Initialize(Texture2D texture, Vector2 position)
        {
            PlayerTexture = texture;
            Position = position;
            Active = true;
            Health = 100;
            Speed = 100f;
           
        }

        public void Update(GameTime gameTime, KeyboardState KBS)
        {
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (KBS.IsKeyDown(Keys.Up) || KBS.IsKeyDown(Keys.W))
            {
                Position.Y -= Speed * delta;
            }
            if (KBS.IsKeyDown(Keys.Down) || KBS.IsKeyDown(Keys.S))
            {
                Position.Y += Speed * delta;
            }
            if (KBS.IsKeyDown(Keys.Right) || KBS.IsKeyDown(Keys.D))
            {
                Position.X += Speed * delta;
            }
            if (KBS.IsKeyDown(Keys.Left) || KBS.IsKeyDown(Keys.A))
            {
                Position.X -= Speed * delta;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(PlayerTexture, Position, null, Color.White, Rotation, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
