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
using Village;

namespace Village
{
    class Terrain
    {
        Texture2D grass;
        Texture2D dirt;
        int grasssize;
        Random r;
        TerrainTile[,] tileArray;
        public void Initialize(Vector2 mapsize)
        {
            tileArray = new TerrainTile[(int)mapsize.X, (int)mapsize.Y];    
        }

        public void LoadContent(Texture2D grass, Texture2D dirt)
        {
            this.grass = grass;
            this.dirt = dirt;
            grasssize = grass.Width;
            Texture2D curTexture;
            Color curColor;
            r = new Random();
            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    //TODO: Add Perlin Nois Generator
                    int randomint = r.Next(0, 30);
                    if(randomint<15)
                    {
                        curTexture = grass;
                        curColor = Color.LightGreen;
                    }
                    else
                    {
                        curTexture = dirt;
                        curColor = Color.White;
                    }
                    tileArray[i, j] = new TerrainTile();
                    Vector2 position = new Vector2(i * grasssize, j * grasssize);
                    tileArray[i, j].Initialize(curTexture, position, curColor);
                    randomint = 0;
                }
            }
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < tileArray.GetLength(0); i++)
            {
                for (int j = 0; j < tileArray.GetLength(1); j++)
                {
                    tileArray[i, j].Draw(spriteBatch);
                }
            }
        }
    }
}
