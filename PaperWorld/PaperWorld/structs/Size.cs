using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperWorld.structs
{
	class Size
	{
		private int _w;
		private int _h;
		public Size(int w, int h)
		{
			_w = w;
			_h = h;
		}
		public int Width
		{
			get { return _w; }
			set { _w = value; }
		}
		public int Height
		{
			get { return _h; }
			set { _h = value; }
		}
	}
}
