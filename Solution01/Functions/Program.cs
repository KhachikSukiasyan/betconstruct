using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
        }


    }

    class MyProgramm
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            F1(1, 2);
            F1(1, 2, 3);
            F2(1, 2);
            F2(b: 1, a: 2);
            F2(1, 2, d: 5);
            F3(1, 2, 3, 4, 5, 6);
            F3(1, 2, new int[] { 3, 4, 5, 6 });
            F3(1, new int[] { 3, 4, 5, 6 });

            int x;
            F4(out x);

            int y = 0;
            F4(ref y, 0);

            int c;
            if(!int.TryParse("5", out c))
            {
                c = 5;
            }

            for (ulong i = 0; i < 100; i++)
            {
                try
                {
                    Console.WriteLine($"{i}:\t{Factorial(i)}");
                }
                catch
                {
                    break;
                }
            }

            for (ulong i = 0; i < ulong.MaxValue; i++)
            {
                // Do not uncomment
                // Console.WriteLine(BadFactorial(i));
            }
        }

        static ulong Factorial(ulong n)
        {
            checked
            {
                return n == 0 ? 1 : n * Factorial(n - 1);
            }
        }

        static ulong BadFactorial(ulong n)
        {
            return n == 0 ? 1 : n * BadFactorial(n - 1);
        }

        static ulong Fibonacci(ulong n)
        {
            return (n == 0 || n == 1) ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void F1(int a, int b, int c = 10)
        {

        }

        static void F2(int a, int b)
        {

        }

        static void F2(int a, int b, int c = 3, int d = 4)
        {

        }

        static void F3(int a, int b, params int[] c)
        {
             
        }

        static void F3(int a, int[] b)
        {

        }

        static void F4(ref int a, int b)
        {

        }

        static void F4(out int a)
        {
            a = 1;
        }

        
    }
}
