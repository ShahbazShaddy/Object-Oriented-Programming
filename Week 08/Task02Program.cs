using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Person object
            Person person = new Person("Ali", "123 Main Street");
            Console.WriteLine(person.ToString());

            // Create a Student object
            Student student = new Student("Saboor", "456 Side Street", "Computer Science", 2023, 2000.0);
            Console.WriteLine(student.ToString());

            // Create a Staff object
            Staff staff = new Staff("Nomi", "78 Jinnah Street", "ABC School", 5000.0);
            Console.WriteLine(staff.ToString());

            // Modify properties using getters and setters
            student.setProgram("Information Technology");
            student.setYear(2022);
            student.setFee(2500.0);

            staff.setSchool("XYZ University");
            staff.setPay(6000.0);

            // Print updated objects
            Console.WriteLine(student.ToString());
            Console.WriteLine(staff.ToString());
            Console.ReadKey();
        }
    }
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual String toString()
        {
            return "Person[Name=" + name + "Address" + address + "]";
        }
    }
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name, string address, string program, int year, double fee)
        : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
            this.name = name;
            this.address = address;
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public override string ToString()
        {
            return "Student[Person[name=" + name + ", Address=" + address + "]," +
                " program=" + program + ", year=" + year + ", fee=" + fee + "]";
        }
    }
    class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name, string address, string school, double pay):base(name,address)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public override string ToString()
        {
            return "Staff[Person[name=" + name + ", Address=" + address + "], school=" + school + ", pay=" + pay + "]";
        }
    }
}
