using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryForConsole;

namespace ConsoleAppLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sqr sqr = new Sqr();
            
            Console.WriteLine(sqr.Size);

            try
            {
                sqr.Size = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect Value");
            }

            Sqr.StaticMethod();

            ConsoleMenu.PrintMessage();

            Console.ReadKey();
        }
    }
}
