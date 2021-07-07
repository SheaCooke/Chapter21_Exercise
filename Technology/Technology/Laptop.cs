using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology 
{
    public class Laptop : Computer
    {
        public string User { get; set; }

        public string ChangeLocation(string newLocation)
        {
            return $"Moving to {newLocation}";
        }

        public Laptop(string user, string year, string model, string manufacturer) :base(year, model, manufacturer)
        {
            User = user;
        }


    }
}
