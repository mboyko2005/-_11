using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_11_2_
{
	public class SimpleShapeFactory : IShapeFactory
	{
		public ICircle CreateCircle()
		{
			return new SimpleCircle();
		}

		public ISquare CreateSquare()
		{
			return new SimpleSquare();
		}

		public ITriangle CreateTriangle()
		{
			return new SimpleTriangle();
		}
	}

}
