using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace IDisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDisposableExample();

            var obj1 = new MyClass($"Object 1");
            Console.WriteLine("-----------");
            obj1 = new MyClass($"Object 2");

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = Path.Combine(desktop, "file.html");

            var hd = new HtmlDownloader(path);
            hd.Save("http://mic.am");
        }

        private static void IDisposableExample()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var sha256 = SHA512.Create();
            var rnd = new Random();
            var bs = new byte[10000];

            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    //string s = Console.ReadLine();
                    //byte[] stringBytes = Encoding.UTF8.GetBytes(s);
                    rnd.NextBytes(bs);
                    byte[] hashBytes = sha256.ComputeHash(bs);

                    string hash = Encoding.UTF8.GetString(hashBytes);

                    //Console.WriteLine(Convert.ToBase64String(hashBytes));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sha256.Dispose();
            }

            using (var sha1 = SHA256.Create())
            using (var sha2 = SHA512.Create())
            {
                try
                {
                    sha1.ComputeHash(new byte[10]);
                    sha2.ComputeHash(new byte[10]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
