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
        public bool dead {get; set; }

        public StatsManager()
        {
            this.health = 100f;
            this.speed = 1f;
            this.dead = false;
        }

        public StatsManager(float health = 100, float speed = 1f)
        {
            this.health = health;
            this.speed = speed;
            this.dead = false;
        }
        
        public TakeDamage(float damage)
        {
            this.health = this.health - damage;
            
            if this.health <= 0
            {
                this.health = 0;
                this.dead = true;
            }
        }
    }
}
