using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Фабричный_метод.Factories;
using Фабричный_метод.Models;

namespace Фабричный_метод.GameLogic
{
	public class Map
	{
		private int width;
		private int height;
		private IMapObject[,] grid;
		private MapObjectFactory factory;
		private Player player;

		public int PlayerX { get; private set; }
		public int PlayerY { get; private set; }

		public Map(int width, int height)
		{
			this.width = width;
			this.height = height;
			grid = new IMapObject[width, height];
			factory = new MapObjectFactory();
			player = new Player();
			PlacePlayer();
		}

		private void PlacePlayer()
		{
			PlayerX = width / 2;
			PlayerY = height / 2;
		}

		public void GenerateRandomObjects(int count)
		{
			Random random = new Random();
			string[] types = new string[] { "Stone", "Tree", "Obstacle" };

			for (int i = 0; i < count; i++)
			{
				int x = random.Next(width);
				int y = random.Next(height);

				if ((x != PlayerX || y != PlayerY) && grid[x, y] == null)
				{
					string type = types[random.Next(types.Length)];
					grid[x, y] = factory.CreateMapObject(type);
				}
				else
				{
					i--; // Повторяем, если место уже занято или это позиция игрока
				}
			}
		}

		public void MovePlayer(int dx, int dy)
		{
			int newX = PlayerX + dx;
			int newY = PlayerY + dy;

			if (IsInsideMap(newX, newY) && grid[newX, newY] == null)
			{
				PlayerX = newX;
				PlayerY = newY;
			}
		}

		private bool IsInsideMap(int x, int y)
		{
			return x >= 0 && x < width && y >= 0 && y < height;
		}

		public void Display()
		{
			Console.Clear();
			for (int y = 0; y < height; y++)
			{
				for (int x = 0; x < width; x++)
				{
					if (x == PlayerX && y == PlayerY)
					{
						Console.ForegroundColor = player.Color;
						Console.Write(player.Symbol);
					}
					else if (grid[x, y] != null)
					{
						Console.ForegroundColor = grid[x, y].Color;
						Console.Write(grid[x, y].Symbol);
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write('·'); // Пустое место
					}
					Console.ResetColor();
				}
				Console.WriteLine();
			}
		}
	}
}
