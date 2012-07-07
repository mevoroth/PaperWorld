using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperWorld.structs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PaperWorld.models.elements
{
	class Hero : Element
	{
		private double _lastJump;
		private bool _lockJump = false;

		public Hero() : base(10, new Size(130, 160)) { }

		public void move(Direction d)
		{
			Position = new Vector2(
				Position.X + d.XAxis,
				Position.Y + d.YAxis
			);
		}
		//public Vector2 Position
		//{
		//    get { return _position; }
		//    set { _position = value; }
		//}
		public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Microsoft.Xna.Framework.Content.ContentManager content)
		{
			spriteBatch.Draw(content.Load<Texture2D>("assets\\hero"), Position, Color.White);
		}

		public void fall(World w)
		{
			if (Position.Y >= 300)
			{
				Position = new Vector2(
					Position.X,
					300
				);
				_lockJump = false;
			}
			else
			{
				_lastJump = 500.0f;
				Position = new Vector2(
					Position.X,
					Position.Y + 10
				);
			}
		}

		public void jump(World w, GameTime gameTime)
		{
			if (_lockJump)
			{
				_lastJump += gameTime.ElapsedGameTime.TotalMilliseconds;
				if (_lastJump < 500.0f
					&& _isInBound(w))
				{
					float tmp = (float)(_lastJump*_lastJump);
					Console.WriteLine(tmp);
					Position = new Vector2(
						Position.X,
						Position.Y - 25000/tmp
					);
				}
				else
				{
					fall(w);
				}
			}
			else
			{
				_lockJump = true;
				_lastJump = .0f;
			}
		}

		private bool _isInBound(World w)
		{
			return true;
		}
	}
}
