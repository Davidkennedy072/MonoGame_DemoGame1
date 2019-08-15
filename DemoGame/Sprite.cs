using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGame
{
    public class Sprite
    {
        private Texture2D texture;
        public Vector2 position;
        public Input Input; 
        public float speed = 1f;

        public Rectangle rectangle
        {
            get {
                return new Rectangle((int)position.X,
              (int)position.Y, texture.Width, texture.Height);
            }
        }

        public Sprite(Texture2D texture)
            // Constructor with only Texture
        {
            this.texture = texture;
        }

        public Sprite(Texture2D texture, Vector2 position)
            // Constructor with Texture and Position
        {
            this.texture = texture;
            this.position = position;
        }

        private void Move()
        {
            if (Input == null)
            {
                return;
            }

            if (Keyboard.GetState().IsKeyDown(Input.Left))
            {
                position.X -= this.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Right))
            {
                position.X += this.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Up))
            {
                position.Y -= this.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                position.Y += this.speed;
            }
        }

        public void Update()
        {
            this.Move();
        }

        public void Draw(SpriteBatch spriteBatch)
            // Passing SpriteBatch object from Game1.cs
            //SpriteBatch object is used for drawing
        {
            spriteBatch.Draw(this.texture, this.position, Color.White);
        }
    }
}
