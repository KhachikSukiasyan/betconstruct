using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Jewelry.InstanceCount);

            Ring j1 = new Ring();

            Console.WriteLine(Jewelry.InstanceCount);

            j1.BaseMaterial = Jewelry.Material.Platinium;
            
            Console.WriteLine(j1.GemStone?.Weight);
        }
    }
}
