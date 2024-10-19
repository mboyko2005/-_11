using System;
using ПЗ_11_2_;

public class DetailedCircle : ICircle
{
	public void Draw()
	{
		Console.WriteLine("Детализированная окружность:");
		Console.WriteLine("   ***   ");
		Console.WriteLine(" *     * ");
		Console.WriteLine("*       *");
		Console.WriteLine("*       *");
		Console.WriteLine(" *     * ");
		Console.WriteLine("   ***   ");
	}
}
