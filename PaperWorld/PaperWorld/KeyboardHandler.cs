using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using PaperWorld.models.elements;

namespace PaperWorld
{
	class KeyboardHandler
	{
		public void Handle(World _world, GameTime gameTime)
		{
			if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
			{
				_world.moveHero(new Direction(10, 0));
			}
			if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
			{
				_world.moveHero(new Direction(-10, 0));
			}

			if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Space))
			{
				_world.heroJump(gameTime);
			}
			else
			{
				_world.heroFall();
			}
		}
	}
}
