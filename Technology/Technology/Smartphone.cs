using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Smartphone : Computer
    {
        //public int Id { get; set; }
        public string User { get; set; }

        public string Call(string personToCall)
        {
            return $"Calling {personToCall}";
        }

        public Smartphone (string user, string year, string model, string manufacturer) : base(year, model, manufacturer)
        {
            User = user;
        }
    }
}
