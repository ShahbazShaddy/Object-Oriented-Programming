using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD01b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 0;
            int max = 100;
            int randomNumber = rnd.Next(min, max);
            Console.WriteLine(randomNumber);
            Console.ReadKey();
        }
    }
}
