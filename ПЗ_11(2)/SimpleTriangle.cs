using System;
using ПЗ_11_2_;

public class SimpleTriangle : ITriangle
{
	public void Draw()
	{
		Console.WriteLine("Простой треугольник:");
		Console.WriteLine("  *  ");
		Console.WriteLine(" * * ");
		Console.WriteLine("*****");
	}
}
