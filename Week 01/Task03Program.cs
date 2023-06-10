using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD01c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am message one without color");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I am red color");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("I am an example with background color");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
