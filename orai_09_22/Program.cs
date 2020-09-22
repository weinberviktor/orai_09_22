using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_09_22
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Weinber Viktor");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(rnd.Next(Console.WindowHeight),
                    rnd.Next(Console.WindowWidth));
                Console.Write("*");
            }
            Console.ReadKey(true);
        }
    }
}
