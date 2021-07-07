using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Technology
{
    public abstract class AbstractEntity
    {

        public List<int> Ids = new List<int>();
        //public int IdNumber = 1;

        //public abstract int IdNumber();
        public int Id;

       

        public AbstractEntity()
        {
            Random rnd1 = new Random();
            do
            {
                Id = rnd1.Next(1000);
            }
            while (Ids.Contains(Id));

            Ids.Add(Id);


        }
    }
}
