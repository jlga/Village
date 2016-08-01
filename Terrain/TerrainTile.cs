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
    class TerrainTile
    {
        public Texture2D TileTexture;
        public Color color;
        public Vector2 Position;
        public float Rotation;
        public bool Active;
        public int Width
        {
            get { return TileTexture.Width; }
        }
        public int Height
        {
            get { return TileTexture.Height; }
        }


        public void Initialize(Texture2D texture, Vector2 position, Color color)
        {
            TileTexture = texture;
            Position = position;
            Active = true;
            Rotation = 0;
            this.color = color;

        }

        public void Update(GameTime gameTime, KeyboardState KBS)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TileTexture, Position, null, color, Rotation, Vector2.Zero, 1f, SpriteEffects.None, 1f);
        }
    }
}
