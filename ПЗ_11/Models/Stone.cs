using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод.Models
{
		// Камень
		public class Stone : IMapObject
		{
			public char Symbol => '⬥';
			public ConsoleColor Color => ConsoleColor.Gray;
		}
}
