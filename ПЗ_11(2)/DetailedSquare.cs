using System;
using ПЗ_11_2_;

public class DetailedSquare : ISquare
{
	public void Draw()
	{
		Console.WriteLine("Детализированный квадрат:");
		Console.WriteLine("*********");
		Console.WriteLine("*       *");
		Console.WriteLine("*       *");
		Console.WriteLine("*       *");
		Console.WriteLine("*********");
	}
}
