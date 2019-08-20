using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame.Stats
{
    public class StatsManager
    {
        public float health { get; set; }
        public float speed {get; set; }

        public StatsManager()
        {
            this.health = 100f;
            this.speed = 1f;
        }

        public StatsManager(float health = 100, float speed = 1f)
        {
            this.health = health;
            this.speed = speed;
        }
    }
}
