using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;

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
            map = new Mapcell[existingMap.GetLength(0), existingMap.GetLength(1)];

            for (int y = 0; y< existingMap.GetLength(0); y++)
            {
                for (int x = 0; x< existingMap.GetLength(1); x++)
                {
                    map[y, x] = new Mapcell(existingMap[y, x]);
                }
            }
        }

        public void LoadTileTextures(ContentManager content, params string[] filenames)
        {
            //Loads in texture from filenames. Do not pass extention. Order does matter 
            Texture2D tiletexture;
            foreach (string filename in filenames)
            {
                tiletexture = content.Load<Texture2D>(filename);
                this.tileTextures.Add(tiletexture);
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
                    Rectangle newrectangle = new Rectangle(x * GameEngine.DISPLAY_TILE_WIDTH, y * GameEngine.DISPLAY_TILE_HEIGHT,
                                                                    GameEngine.TILE_WIDTH, GameEngine.TILE_HEIGHT);
                    // Explicitly defining rectangle location and size. Allows for scaling of spirits with varying size 
                    // Pulling variables from GameEngine.cs class. Will be used to store all variables for game
                    spriteBatch.Draw(texture, newrectangle, Color.White);
                }
            }
        }
    }
}
