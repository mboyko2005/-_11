using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_11_3_
{
	public class ComputerBuilder
	{
		private Computer computer;

		public ComputerBuilder()
		{
			computer = new Computer();
		}

		public ComputerBuilder SetCPU(string cpu)
		{
			computer.CPU = cpu;
			return this;
		}

		public ComputerBuilder SetGPU(string gpu)
		{
			computer.GPU = gpu;
			return this;
		}

		public ComputerBuilder SetRAM(int ram)
		{
			computer.RAM = ram;
			return this;
		}

		public ComputerBuilder SetStorage(int storage)
		{
			computer.Storage = storage;
			return this;
		}

		public ComputerBuilder SetWiFi(bool hasWiFi)
		{
			computer.HasWiFi = hasWiFi;
			return this;
		}

		public ComputerBuilder SetBluetooth(bool hasBluetooth)
		{
			computer.HasBluetooth = hasBluetooth;
			return this;
		}

		public Computer Build()
		{
			return computer;
		}
	}

}
