using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{


	public class Computer : AbstractEntity


	{
		//public int Id { get; set; }

		public string YearBuilt { get; set; }

		public readonly string Manufacturer;

		public string Model { get; set; }

		public string SearchInternet(string txt)
		{
			return $"Searching the internet for {txt}";
		}

		public string UseEmail()
		{
			return "Using email";
		}

		public Computer(string year, string model, string manufacturer) : base()
		{
			Manufacturer = manufacturer;
			YearBuilt = year;
			Model = model;
		}

		/*public override int IdNumber()
        {


        }*/
	}

}
