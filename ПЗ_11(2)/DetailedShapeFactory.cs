using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_11_2_
{
	public class DetailedShapeFactory : IShapeFactory
	{
		public ICircle CreateCircle()
		{
			return new DetailedCircle();
		}

		public ISquare CreateSquare()
		{
			return new DetailedSquare();
		}

		public ITriangle CreateTriangle()
		{
			return new DetailedTriangle();
		}
	}

}
