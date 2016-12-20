using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Ring : Jewelry
    {
        static Ring()
        {
            InstanceCount = 0;
            Console.WriteLine("Ring Static Ctor");
        }

        public Ring() : base()
        {
            
            Console.WriteLine("Ring Ctor");
        }

        public Ring(Material material, decimal price, float weight, string brand, float diameter, TargetGender gender) : base(material, price, weight, brand)
        {
            Diameter = diameter;
            For = gender;
        }

        public float Diameter { get; set; }
        public TargetGender For { get; set; }
        // TODO: Use interfaces intead
        public GemStone GemStone { get; set; }
    }
}
