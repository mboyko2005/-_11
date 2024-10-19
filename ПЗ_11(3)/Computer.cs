using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ_11_3_
{
	public class Computer
	{
		public string CPU { get; set; }
		public string GPU { get; set; }
		public int RAM { get; set; }          
		public int Storage { get; set; }     
		public bool HasWiFi { get; set; }
		public bool HasBluetooth { get; set; }

		public override string ToString()
		{
			return $"Computer [CPU={CPU}, GPU={GPU}, RAM={RAM}GB, Storage={Storage}GB, WiFi={HasWiFi}, Bluetooth={HasBluetooth}]";
		}
	}

}
