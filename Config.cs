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
        int map = 100;

        // Graphics Settings
        public bool fullscreen = false;
        public int width = 1600;
        public int height = 900;

        public Config()
        {
            mapsize = new Vector2(map, map);
        }
    }
}
