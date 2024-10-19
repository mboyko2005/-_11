using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фабричный_метод.Models;

namespace Фабричный_метод.Factories
{
	public class MapObjectFactory
	{
		public IMapObject CreateMapObject(string type)
		{
			switch (type)
			{
				case "Stone":
					return new Stone();
				case "Tree":
					return new Tree();
				case "Obstacle":
					return new Obstacle();
				default:
					throw new ArgumentException("Invalid type");
			}
		}
	}
}
