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
		private delegate void ContextHandler(World _world, GameTime gameTime);
		private ContextHandler _realHandler;

		public KeyboardHandler()
		{
			_realHandler = inGame;
		}

		public void inGame(World _world, GameTime gameTime)
		{
			KeyboardState ks = Keyboard.GetState(PlayerIndex.One);
			if (ks.IsKeyDown(Keys.Right))
			{
				_world.Hero.move(new Direction(10, 0));
			}
			if (ks.IsKeyDown(Keys.Left))
			{
				_world.Hero.move(new Direction(-10, 0));
			}

			if (ks.IsKeyDown(Keys.X))
			{
				_world.Hero.jump(_world, gameTime);
			}
			else
			{
				_world.Hero.fall(_world);
			}

			if (ks.IsKeyDown(Keys.W))
			{
				_world.Hero.paperDart();
			}
			if (ks.IsKeyDown(Keys.C))
			{
				_world.Hero.clone();
			}
			if (ks.IsKeyDown(Keys.F))
			{
				_world.Hero.fold();
			}
			if (ks.IsKeyDown(Keys.B))
			{
				_world.Hero.ball();
			}
		}

		public void Handle(World _world, GameTime gameTime)
		{
			_realHandler(_world, gameTime);
		}
	}
}
