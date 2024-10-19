using System;
using ПЗ_11_2_;

public class SimpleSquare : ISquare
{
	public void Draw()
	{
		Console.WriteLine("Простой квадрат:");
		Console.WriteLine("*****");
		Console.WriteLine("*   *");
		Console.WriteLine("*   *");
		Console.WriteLine("*****");
	}
}
