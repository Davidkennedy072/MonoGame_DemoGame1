using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoGame.Stats;

namespace DemoGame
{
    public class Sprite
    {
        protected Texture2D texture;
        public Vector2 position;

        public StatsManager stats;

        public Rectangle rectangle
        {
            get {
                return new Rectangle((int)position.X,
              (int)position.Y, texture.Width, texture.Height);
            }
        }
        public Rectangle entity_rectangle
        {
            get
            {
                return new Rectangle((int)position.X,
                    (int)position.Y, (int)this.stats.entity_radius, (int)this.stats.entity_radius);
            }
        }

        public Sprite(Texture2D texture, Vector2 position)
        // Constructor with Texture and Position
        {
            this.texture = texture;
            this.position = position;
        }

        public virtual void Initialize()
        {
            this.stats = new StatsManager();
        }

        public virtual void Move()
        {

        }

        public virtual void Update()
        {
            this.Move();
        }

        public void Draw(SpriteBatch spriteBatch)
            // Passing SpriteBatch object from Game1.cs
            //SpriteBatch object is used for drawing
        {
            spriteBatch.Draw(this.texture, this.rectangle, Color.White);
        }
    }
    
}
