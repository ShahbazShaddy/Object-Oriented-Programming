using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Cylinder cylinder1 = new Cylinder();
            cylinder1.setHeight(1.0);
            Console.WriteLine( "Volume 1:"+cylinder1.getVolume());
            Cylinder cylinder2 = new Cylinder(1.0,1.0);
            Console.WriteLine( "Volume 2:"+cylinder2.getVolume());
            Cylinder cylinder3 = new Cylinder(1.0, 2.0);
            Console.WriteLine( "Volume 3:"+cylinder3.getVolume());
            Console.WriteLine(cylinder1.toString());
            Console.ReadKey();
        }

    }

    class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }
        public double getArea()
        {
            double area = Math.PI * (Math.Pow(radius, 2));
            return area;
        }

        public String toString()
        {
            return "Circle [radius=" + radius + ", color=" + color + "]";
        }

    }
    class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double height)
        {
            this.height = height;
        }
        public Cylinder(double height,double radius)
        {
            this.radius = radius;
            this.height = height;
        }
        public Cylinder(double height, double radius,string color)
        {
            this.radius = radius;
            this.height = height;
            this.color = color;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            double volume= base.getArea()* height;
            return volume;
        }
    }
}
