using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{


	public class Computer


	{
		public string YearBuilt { get; set; }

		public readonly string Manufacturer = "Apple";

		public string Model { get; set; }

		public void SearchInternet(string txt)
		{
			Console.WriteLine($"Searching the internet for {txt}");
		}

		public void UseEmail()
		{
			Console.WriteLine("Using email");
		}

		public Computer(string year, string model)
		{
			YearBuilt = year;
			Model = model;
		}
	}

}
