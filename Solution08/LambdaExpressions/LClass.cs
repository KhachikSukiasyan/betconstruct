using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class LClass
    {
        public float X { get; set; }
        public float Y { get; set; }

        //public override string ToString()
        //{
        //    return $"({X};{Y})";
        //}

        public override string ToString() => $"({X};{Y})";
    }
}
