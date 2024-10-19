using System;
using ПЗ_11_2_;

public class SimpleCircle : ICircle
{
	public void Draw()
	{
		Console.WriteLine("Простая окружность:");
		Console.WriteLine("  ***  ");
		Console.WriteLine(" *   * ");
		Console.WriteLine("  ***  ");
	}
}
