using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaperWorld.structs;

namespace PaperWorld.models
{
	class Element
	{
		private int _hpmax;
		private int _hp;
		private Size _hitbox;
		public Element(int hpmax, Size hitbox)
		{
			_hpmax = hpmax;
			_hp = hpmax;
			_hitbox = hitbox;
		}
		public void heal(int hp)
		{
			_hp += hp;
		}
		public void damage(int hp)
		{
			_hp -= hp;
			if (_hp < 0)
			{
				_hp = 0;
			}
		}
		public bool isDead()
		{
			return _hp <= 0;
		}
	}
}
