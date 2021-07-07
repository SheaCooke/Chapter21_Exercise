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

        public Laptop(string user, string year, string model) :base(year, model)
        {
            User = user;
        }
    }
}
