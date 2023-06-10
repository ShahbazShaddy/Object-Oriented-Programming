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
            public Student()
            {
                name = "Jill";
            }
            public string name;
            public float matricMarks;
            public float fscMarks;
            public float ecat;
            public float aggregate;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.name);
            Console.ReadKey();
        }
    }
}
