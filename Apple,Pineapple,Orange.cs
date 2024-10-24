using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Butun meyveleri bir classda yaratmagi yoxladim
namespace Upcasting__Downcasting
{
    public class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Alma sirindi");
        }
    }

    public class Pineapple : Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Ananas sirin ve tursmezedi");
        }
    }

    public class Orange : Fruit
    {
        public int VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Portagalin dadi tursdu");
        }
    }
}
