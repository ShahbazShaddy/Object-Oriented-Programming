using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_Sol03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat("ANGI");
            Console.WriteLine(c1.ToString());
            c1.Greet();
            Cat c2 = new Cat("LEZAY");
            Console.WriteLine(c2.ToString());
            c2.Greet();
            Dog d1 = new Dog("LUCY");
            Console.WriteLine(d1.ToString());
            d1.Greet();
            Dog d2 = new Dog("SHAFORD");
            Console.WriteLine(d2.ToString());
            d2.Greet();
            Console.ReadKey();
        }
    }
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string ToString()
        {
            return "[Animal[name=" + name + "]";
        }
    }

    class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }
        public override string ToString()
        {
            return "Mammal[" + base.ToString() + "]";
        }
    }

    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
        }
        public void Greet()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return "Cat[" + base.ToString() + "]";
        }
    }

    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
        }
        public void Greet()
        {
            Console.WriteLine("Woof");
        }

        public void Greet(Dog another)
        {
            Console.WriteLine("Woof");
        }

        public override string ToString()
        {
            return "Dog[" + base.ToString() + "]";
        }
    }
}
