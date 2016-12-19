using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(25);
            student.SetFirstName("John");
            Console.WriteLine(student.GetFirstName());

            student.LastName = "Smith";
            Console.WriteLine(student.LastName);

            student.Age = 25;
            Console.WriteLine(student.Age);


            var obj1 = new Example(1);
            var obj2 = new Example(2);

            //Example.className = "";
            //obj1.n = 2;
            Console.WriteLine(obj1.N);
            //obj1.N = 1;
            obj1.ChnageN(1);
            Console.WriteLine(Example.className);
            Example.ChnageName("Test");
            
            
        }
    }
}
