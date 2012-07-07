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

		public void setHero(Hero hero)
		{
			_hero = hero;
			_hero.Position = _spawn;
		}
		public void moveHero(Direction d)
		{
			_hero.move(d);
		}

		public void Draw(SpriteBatch spriteBatch, ContentManager content)
		{
			spriteBatch.Draw(content.Load<Texture2D>("maps\\base"), new Vector2(0,0), Color.White);
			_hero.Draw(spriteBatch, content);
		}

		public void heroFall()
		{
			_hero.fall(this);
		}

		public void heroJump(GameTime gameTime)
		{
			_hero.jump(this, gameTime);
		}
	}
}
