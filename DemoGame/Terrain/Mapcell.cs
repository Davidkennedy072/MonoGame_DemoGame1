using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame.Terrain
{
    class Mapcell
    {
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
