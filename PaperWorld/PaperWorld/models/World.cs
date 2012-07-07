using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperWorld.structs;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace PaperWorld.models.elements
{
	class World
	{
		private Hero _hero;
		private Vector2 _spawn = new Vector2(.0f, 300.0f);

		public World()
		{
		}

		public Hero Hero
		{
			get { return _hero; }
			set
			{
				_hero = value;
				_hero.Position = _spawn;
			}
		}
		public void Draw(SpriteBatch spriteBatch, ContentManager content)
		{
			Vector2 cam = getCamera();
			Console.WriteLine(cam);
			spriteBatch.Draw(content.Load<Texture2D>("maps\\base"), new Vector2(-cam.X, -cam.Y), Color.White);
			_hero.Draw(spriteBatch, content, getCamera());
		}

		public Vector2 getCamera()
		{
			Vector2 p = _hero.Position;
			Console.WriteLine(p);
			float x = p.X + 200 - 640;
			if (x < 0)
			{
				x = 0;
			}
			else if (x > 128)
			{
				x = 128;
			}
			return new Vector2(x, 0);
		}
	}
}
