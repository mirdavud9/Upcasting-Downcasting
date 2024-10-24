using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting__Downcasting
{
    public abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }

        public virtual void Taste()
        {
            Console.WriteLine("Meyvenin dadini beyendim");
        }
    }
}
