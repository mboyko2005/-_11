using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод.Models
{
		// Интерфейс для объектов карты
		public interface IMapObject
		{
			char Symbol { get; }
			ConsoleColor Color { get; }
		}
}

