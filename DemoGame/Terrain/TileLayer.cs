using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame.Terrain
{
    class TileLayer
    {
        private Mapcell[,] map;
        // A 2D array of Mapcells 
        // Mapcells handle properities of each tile
        // TileLayer draws map based on terrain type 
        List<Texture2D> tileTextures = new List<Texture2D>();

        public TileLayer(int[,] existingMap)
        {
            int[,] intmap = new int[,]
            {
            {0,0,1,0,0,0 },
            {0,0,1,0,0,0 },
            {0,0,0,1,0,0 },
            {0,0,0,1,0,0 },
            {0,0,0,1,0,0 },
            {0,0,0,1,0,0 },
            };

            map = new Mapcell[intmap.GetLength(0), intmap.GetLength(1)];

            for (int y = 0; y< intmap.GetLength(0); y++)
            {
                for (int x = 0; x< intmap.GetLength(1); x++)
                {
                    map[y, x] = new Mapcell(intmap[y, x]);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int y = 0; y< this.map.GetLength(0); y++)
            {
                for (int x = 0; x < this.map.GetLength(1); x++)
                {
                    int index = map[y, x].tileID;
                    Texture2D texture = tileTextures[index]; // Pull texture from list. Order matters. 
                    // Change to dictionary in the future?
                    Rectangle newrectangle = new Rectangle(x * GameEngine.TILE_WIDTH, y * GameEngine.TILE_HEIGHT,
                                                                    GameEngine.TILE_WIDTH, GameEngine.TILE_HEIGHT);
                    // Explicitly defining rectangle location and size. Allows for scaling of spirits with varying size 
                    spriteBatch.Draw(texture, newrectangle, Color.White);
                }
            }
        }
    }
}
