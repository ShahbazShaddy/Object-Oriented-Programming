using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        class Student
        {
            public string name;
            public float matricMarks;
            public float fscMarks;
            public float ecat;
            public float aggregate;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine( student.name);
            Console.WriteLine( student.matricMarks);
            Console.WriteLine( student.fscMarks);
            Console.WriteLine( student.ecat);
            Console.WriteLine( student.aggregate);
            Console.ReadKey();
        }
    }
}
