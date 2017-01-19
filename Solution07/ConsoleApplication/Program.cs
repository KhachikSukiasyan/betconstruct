using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            int c = a;
            a = b;
            b = c;

            object x = new object();
            object y = new object();
            object temp = new object();
            temp = x;
            x = y;
            y = temp;

            double u = 1;
            double v = 2;
            Swap(u, v);

            Swap<object>(x, y);
            Swap(x, y);

            object[] result1 = Gen<int, double, object>();
            object[] result2 = Gen<int, double, object>(1, 2.0);

            var gen1 = new GenericExample<InvalidCastException>();
            var gen2 = new AnotherGenericExample<int, double, SystemException>();

            
        }

        static void Swap<T>(T x, T y)// where T : class, IEnumerable, new()
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static T[] Gen<T1, T2, T>()
            where T1 : T
            where T2 : T
        {
            return new T[] { };
        }

        static T[] Gen<T1, T2, T>(T1 a, T2 b)
            where T1 : T
            where T2 : T
        {
            return new T[] { a, b };
        }
    }
}
