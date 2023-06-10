using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02a
{
    internal class Program
    {
        class Student
        {
            public string name;
            public int roll_num;
            public float cgpa;
        }
        static void Main(string[] args)
        {
            //First Object
            Student student = new Student();
            Console.WriteLine( "name:");
            student.name = Console.ReadLine();
            Console.WriteLine( "roll num:");
            student.roll_num = int.Parse(Console.ReadLine());
            Console.WriteLine("cgpa:");
            student.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine( "name:"+student.name+"\t"+"roll num:"+student.roll_num+"\t"+"cgpa:"+student.cgpa);

            Console.ReadKey();
        }
    }
}
