using System;
using ПЗ_11_2_;

public class DetailedTriangle : ITriangle
{
	public void Draw()
	{
		Console.WriteLine("Детализированный треугольник:");
		Console.WriteLine("    *    ");
		Console.WriteLine("   * *   ");
		Console.WriteLine("  *   *  ");
		Console.WriteLine(" *     * ");
		Console.WriteLine("*********");
	}
}
