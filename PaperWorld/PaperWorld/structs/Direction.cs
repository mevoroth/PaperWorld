using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaperWorld.models.elements
{
	class Direction
	{
		private int _xAxis;
		private int _yAxis;
		public Direction(int xAxis, int yAxis)
		{
			_xAxis = xAxis;
			_yAxis = yAxis;
		}
		public int XAxis
		{
			get { return _xAxis; }
			set { _xAxis = value; }
		}
		public int YAxis
		{
			get { return _yAxis; }
			set { _yAxis = value; }
		}
	}
}
