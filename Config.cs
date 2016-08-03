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
    class Config
    {
        //Map-Generator Settings
        public Vector2 mapsize;
        int mapx = 1000;
        int mapy = 1000;

        // Graphics Settings
        public bool fullscreen = false;
        public int width = 1600;
        public int height = 900;

        public Config()
        {
            mapx = width / 8+1;
            mapy = height / 8+1;
            mapsize = new Vector2(mapx, mapy);
        }
    }
}
