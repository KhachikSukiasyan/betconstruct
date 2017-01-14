using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{


    public class Program
    {
        public static void Main()
        {
            var md = new int[,] { { 1, 1 }, { 2, 2 } };
            //md[0, 0];

            var jag = new int[][] { new int[] { 1 }, new int[] { 1, 2 } };
            //jag[0][0]


            var s = "abc";
            Console.WriteLine(s[0]);
            //s[0] = 'z';

            var example = new Example(new int[] { 1, 2, 3 });
            Console.WriteLine(example[0]);
            //example[0] = 8;
        }
    }

    public class Example
    {
        private int[] arr;

        public Example(int[] value)
        {
            arr = new int[value.Length];
            Array.Copy(value, arr, value.Length);
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return arr[index];
            }
        }

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }
    }
}
