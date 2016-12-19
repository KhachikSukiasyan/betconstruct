using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = 1;
                int* p_before = &x;
                x = 2;
                int* p_after = &x;
                Console.WriteLine((int)p_before);
                Console.WriteLine((int)p_after);

                DateTime s = new DateTime(2016, 12, 20);
                DateTime* ps_before = &s;
                s = new DateTime(2016,12,19);
                DateTime* ps_after = &s;
                Console.WriteLine((int)ps_before);
                Console.WriteLine((int)ps_after);
            }

            string a = "A";
            string b = a;
            Console.WriteLine(ReferenceEquals(a, b));
            a = "B";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(ReferenceEquals(a, b));

            int c = 1;
            int d = c;
            Console.WriteLine(ReferenceEquals(c, d));
        }
    }
}
