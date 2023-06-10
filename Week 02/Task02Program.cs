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
            student.name = "ali";
            student.roll_num = 10;
            student.cgpa = 3.59F;
            Console.WriteLine( "name:"+student.name+"\t"+"roll num:"+student.roll_num+"\t"+"cgpa:"+student.cgpa);

            //Second Object
            Student student1 = new Student();
            student.name = "ahmed";
            student.roll_num = 25;
            student.cgpa = 3.01F;
            Console.WriteLine("name:" + student1.name + "\t" + "roll num:" + student1.roll_num + "\t" + "cgpa:" + student1.cgpa);
            Console.ReadKey();
        }
    }
}
