using Lab_08_Sol04_.BL.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_08_Sol04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            List<Shape> shapes = new List<Shape>();


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a shape to create:");
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Circle");
                Console.WriteLine("Enter 0 to exit.");
                int option = int.Parse(Console.ReadLine());
                if (option == 0)
                    break;
                else if (option == 1)
                {
                    shape = ShapeUI.createRectangle();
                    shapes.Add(shape);
                    break;
                }
                else if (option == 2)
                {
                    shape = ShapeUI.createSquare();
                    shapes.Add(shape);
                    break;
                }
                else if (option == 3)
                {
                    shape = ShapeUI.createCircle();
                    shapes.Add(shape);
                    break;
                }
            }
            foreach (Shape s in shapes)
            {
                string shapeType = s.GetType().Name;
                double area = shape.calculateArea();
                Console.WriteLine("Type of figure:" + shapeType);
                Console.WriteLine("Area:" + area);
                Console.ReadKey();
            }


        }
    }
}
