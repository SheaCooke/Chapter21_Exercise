using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Smartphone : Computer
    {
        public string User { get; set; }

        public Smartphone (string user, string year, string model) : base(year, model)
        {
            User = user;
        }
    }
}
