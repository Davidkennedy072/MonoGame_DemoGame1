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
	public class Camera
	{
		public Matrix Transform { get; private set;}

		public void Follow(Sprite target)
		{
			var offset = Matrix.CreateTranslation(
				Game1.ScreenWidth/2,
				Game1.ScreenHeight/2,
				0);
			var position = Matrix.CreateTranslation(
				-target.Position.X -(target.Rectangle.Width/2),
				-target.Position.Y -(taget.Rectangle.Height/2),
				0);// This is X,Y,Z at center of sprite with a negative
			this.Transform = position * offset 
		}
	}
}