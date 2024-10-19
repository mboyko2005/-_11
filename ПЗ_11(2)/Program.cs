using System;
using ПЗ_11_2_;

public class Program
{
	public static void Main(string[] args)
	{
		// Выбор фабрики (простая или детализированная отрисовка)
		IShapeFactory factory;

		Console.WriteLine("Выберите тип отрисовки: 1 - Простая, 2 - Детализированная");
		string choice = Console.ReadLine();

		if (choice == "1")
		{
			factory = new SimpleShapeFactory();
		}
		else if (choice == "2")
		{
			factory = new DetailedShapeFactory();
		}
		else
		{
			Console.WriteLine("Неверный выбор");
			return;
		}

		// Создаем фигуры
		ICircle circle = factory.CreateCircle();
		ISquare square = factory.CreateSquare();
		ITriangle triangle = factory.CreateTriangle();

		// Отрисовываем фигуры
		Console.WriteLine();
		circle.Draw();

		Console.WriteLine();
		square.Draw();

		Console.WriteLine();
		triangle.Draw();

		Console.WriteLine("\nНажмите любую клавишу для выхода...");
		Console.ReadKey();
	}
}
