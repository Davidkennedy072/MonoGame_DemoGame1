﻿
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
    class Player : Sprite
    {
        public Input Input;

        public Player(Texture2D texture, Vector2 position) : base(texture, position)
        {

        }

        public override void Move()
        {
            if (Input == null)
            {
                return;
            }

            if (Keyboard.GetState().IsKeyDown(Input.Left))
            {
                position.X -= this.stats.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Right))
            {
                position.X += this.stats.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Up))
            {
                position.Y -= this.stats.speed;
            }
            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                position.Y += this.stats.speed;
            }
        }
    }
}
