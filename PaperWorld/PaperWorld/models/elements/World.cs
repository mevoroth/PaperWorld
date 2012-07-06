using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperWorld.structs;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Graphics.PackedVector;

namespace PaperWorld.models.elements
{
	class World
	{
		private Microsoft.Xna.Framework.Content.ContentManager Content;
		private Hero _hero;

		public World()
		{	
		}

		public void setHero(Hero hero)
		{
			_hero = hero;
			
		}
	}
}
