using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame.Terrain
{
    class Mapcell
    {
        //Map cell class. Here we can set the properities of each tile.
        // Properities can include collision, heal, damage, etc
        public int tileID { get; set; }
        public int collisionID { get; set; }

        public Mapcell(int tileID)
        {
            this.tileID = tileID;
        }

        public Mapcell(int tileID, int collisionID)
        {
            this.tileID = tileID;
            this.collisionID = collisionID;
        }
    }
}
