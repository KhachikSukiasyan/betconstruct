using ClassLibrary;
using System;
using System.Diagnostics;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();

            var sw = new Stopwatch();

            var temp = string.Empty;

            test.PrintHello();

            sw.Start();

            var x = int.Parse(Console.ReadLine());

            sw.Stop();

            Debug.WriteLine(sw.ElapsedMilliseconds);

            Debug.WriteLine(x);

            Console.WriteLine(x);
        }
    }
}
