using ПЗ_11_3_;

class Program
{
	static void Main(string[] args)
	{
		Computer myComputer = new ComputerBuilder()
			.SetCPU("Intel Core i7")
			.SetGPU("NVIDIA RTX 3080")
			.SetRAM(32)
			.SetStorage(1000)
			.SetWiFi(true)
			.SetBluetooth(true)
			.Build();

		Console.WriteLine(myComputer.ToString());
	}
}
