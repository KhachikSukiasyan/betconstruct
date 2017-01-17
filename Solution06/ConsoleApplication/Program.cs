using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //throw new Exception();

            var n = 2;

            var arr = new int[n];

            // Bad practice
            try
            {
                Console.WriteLine(arr[n]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) // Good practice
            {
                Console.WriteLine(ex.Message);
            }

            
            // Good practice
            if(n >= 0 && n < arr.Length)
            {
                try
                {
                    Console.WriteLine(arr[n]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("Index out of range.");
            }



            try
            {
                FunctionWithException(1);
                FunctionWithException(0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException?.Message);
            }
            finally
            {

            }
        }

        // This code contains some bad practices and written for demonstration purposes
        static void FunctionWithException(int x)
        {
            //throw new Exception();
            //throw new DivideByZeroException();
            float? y = null;

            try
            {
                y = 1 / x;
            }
            catch (Exception ex)
            {
                //throw ex;
                throw new Exception($"Unable to divide on {x}", ex);
            }
            finally
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            
        }
    }
}
