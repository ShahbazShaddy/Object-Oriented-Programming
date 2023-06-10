using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            Console.Title = "Univerty Admission Management System";
            int option;
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }
                else if (option == 3)
                {
                    List<Student> sortedStudentList= new List<Student>();
                    sortedStudentList = sortStudentByMerit();
                    giveAdmission(sortedStudentList);
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write( "Enter Degree Name:");
                    degName= Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write( "Enter Student Name:");
                    string name= Console.ReadLine();
                    Student s = studentPresent(name);
                    if(s!=null)
                    {
                        viewSubjects(s);
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFeeForAll();
                }
                clearScreen();

            } while (option != 8);
            Console.ReadKey();
        }
        static Student studentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void calculateFeeForAll()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "has" + s.calculateFee() + "fees");
                }
            }
        }
        static void registerSubjects(Student s)
        {
            Console.WriteLine("How many subjects you want to register?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the subject code:");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    i--;
                }
            }
        }
        static List<Student> sortStudentByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        static void printStudents()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get admission");
                }
            }
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }
        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFSC\tECAT\tAge");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }
        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
        static DegreeProgram takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.WriteLine("Eneter Degree Name:");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration:");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats:");
            seats = int.Parse(Console.ReadLine());

            DegreeProgram degProg = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.WriteLine("How many subjects to enter:");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                degProg.AddSubject(takeInputForSubject());
            }
            return degProg;
        }
        static Subject takeInputForSubject()
        {
            string code;
            string type;
            int creditHours;
            int subjectFees;
            Console.WriteLine("Subject Code:");
            code = Console.ReadLine();
            Console.WriteLine("Subject Type:");
            type = Console.ReadLine();
            Console.WriteLine("Subject Credit Hours:");
            creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject Fee:");
            subjectFees = int.Parse(Console.ReadLine());
            Subject sub = new Subject(code, type, creditHours, subjectFees);
            return sub;
        }
        static void addIntoStudentList(Student s)
        {
            studentList.Add(s);
        }
        static Student takeInputForStudent()
        {
            string name;
            int age;
            double fscMarks;
            double ecatMarks;
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            Console.WriteLine("Enter Student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Student Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("FSC marks:");
            fscMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("ECAT Marks:");
            ecatMarks = float.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Program:");
            viewDegreePrograms();

            Console.WriteLine("Enter how many preferences to enter:");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach (DegreeProgram dp in programList)
                {
                    if (degName == dp.degreeName && !(preferences.Contains(dp)))
                    {
                        preferences.Add(dp);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Ente Valid Degree Program Name");
                    x--;
                }
            }
            Student s = new Student(name, age, fscMarks, ecatMarks, preferences);
            return s;
        }
        static void viewDegreePrograms()
        {
            foreach (DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeName);
            }
        }
        static void header()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("               UAMS                   ");
            Console.WriteLine("**************************************");
        }
        static void viewSubjects(Student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code\tSub Type");
                foreach (Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }
        static int Menu()
        {
            header();
            int option;
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students For a Specific Program");
            Console.WriteLine("6. Register Subject for a Specific Student");
            Console.WriteLine("7. Calculate Fees For All Registered Students");
            Console.WriteLine("8. Exit");
            Console.Write("Enter Option:");
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
