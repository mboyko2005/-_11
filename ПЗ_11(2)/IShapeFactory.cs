using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_11_2_
{
	public interface IShapeFactory
	{
		ICircle CreateCircle();
		ISquare CreateSquare();
		ITriangle CreateTriangle();
	}

}
