using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фабричный_метод.GameLogic
{
	// Класс игры
	public class Game
	{
		private Map map;
		private bool isRunning;

		public Game()
		{
			map = new Map(40, 20);
			map.GenerateRandomObjects(200);
			isRunning = true;
		}

		public void Run()
		{
			while (isRunning)
			{
				map.Display();
				ProcessInput();
			}
		}

		private void ProcessInput()
		{
			Console.WriteLine("Используйте клавиши WASD для перемещения. Нажмите Q для выхода.");
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			switch (keyInfo.Key)
			{
				case ConsoleKey.W:
					map.MovePlayer(0, -1);
					break;
				case ConsoleKey.S:
					map.MovePlayer(0, 1);
					break;
				case ConsoleKey.A:
					map.MovePlayer(-1, 0);
					break;
				case ConsoleKey.D:
					map.MovePlayer(1, 0);
					break;
				case ConsoleKey.Q:
					isRunning = false;
					break;
			}
		}
	}
}
