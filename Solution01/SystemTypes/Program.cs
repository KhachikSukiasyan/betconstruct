using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "A";
            var s2 = "B";
            var s3 = "A";

            var n1 = 2;
            var n2 = 2;

            Console.WriteLine("s1 is the same as s2?\t{0}",ReferenceEquals(s1, s2)); 
            Console.WriteLine(string.Format("s1 is the same as s3?\t{0}", ReferenceEquals(s1, s3)));
            Console.WriteLine($"n1 is the same as n2?\t{ReferenceEquals(n1, n2)}");

            var s4 = s1 + "," + s2 + "," + s3;
            var s5 = $"{s1},{s2},{s3}";

            var s = new int[100];
            //s = Enumerable.Range(0, 100).Select(x => 2 * x + 1).ToArray();

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = i;
            }

            var s6 = string.Empty;

            // Bad practice
            var sep = "";

            foreach (var item in s)
            {
                s6 += sep + item;
                sep = ",";
            }

            // Good practice
            var sb = new StringBuilder();

            sep = "";

            foreach (var item in s)
            {
                sb.Append($"{sep}{item}");
                sep = ",";
            }

            var s7 = sb.ToString();

            var s8 = string.Join(",", s);

            //int y = null; // Error
            //Nullable<int> x = null;
            int? x = null;
            int z = x ?? 0;
            // ?.
            // x == null ? 0 : x;
            // /= 2  Sashik's operator
        }
    }
}
