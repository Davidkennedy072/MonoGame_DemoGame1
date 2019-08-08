using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

// From https://www.youtube.com/watch?v=2l2BBLnygHs
// Also https://www.youtube.com/watch?v=PKlHcxFAEk0

namespace TileEngine
{
    public class TileEngine : Microsoft.Xna.Framework.Game
    {
        GraphicsDevicemanager graphics;
        SpriteBatch spriteBatch;
        List<Texture2D> tileTextures = new List<Texture2D>;

        int[,] = new int[,]
        {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
        };
    }
}
