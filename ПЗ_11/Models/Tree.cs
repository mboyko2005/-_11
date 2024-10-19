using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод.Models
{
	public class Tree : IMapObject
	{
		public char Symbol => '♣';
		public ConsoleColor Color => ConsoleColor.Green;
	}
}
