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

namespace Village.Terrain
{
    class TerrainTile
    {
        //Rendering
        public Texture2D TileTexture;
        public Color color;
        public Vector2 Position;
        public Rectangle sourceRect;
        public float Rotation;
        public int Width
        {
            get { return TileTexture.Width; }
        }
        public int Height
        {
            get { return TileTexture.Height; }
        }
        bool Active;


        public void Initialize(Texture2D texture, Vector2 position, Color color)
        {
            TileTexture = texture;
            Position = position;
            Active = true;
            Rotation = 0;
            this.color = color;
            sourceRect = new Rectangle(0, 0, 8, 8);

        }

        public void Update(GameTime gameTime, KeyboardState KBS)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TileTexture, Position, sourceRect, color, Rotation, Vector2.Zero, 1f, SpriteEffects.None, 1f);
        }
    }
}
