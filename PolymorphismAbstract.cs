using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyPolymorphismAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(5), new Cube(6),new Pyramid(3,4,5),new Cylinder(6,8),new Cone(7,9) };
            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0}",shape.Volume());
            }
           
            Thread.Sleep(135000);
        }
    }
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"this is a {Name}\t");
        }
        public abstract double Volume();
        
    }
    class Sphere : Shape
    {
        public double Radius { get; set; }
        public Sphere(double Radius)
        {
            Name = "Sphere";
            this.Radius = Radius;
        }
        public override double Volume()
        {
            return Math.Pow(Radius, 3) *4/ 3 * Math.PI;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has radius of {Radius} and his volume is: ");
        }
    }
    class Pyramid : Shape
    {
        public double baseLength { get; set; }
        public double baseWidth { get; set; }
        public double Height { get; set; }
        public Pyramid(double baseLength,double baseWidth,double Height)
        {
            Name = "Pyramid";
            this.baseLength = baseLength;
            this.baseWidth = baseWidth;
            this.Height = Height;
        }
        public override double Volume()
        {
            return baseLength * baseWidth * Height/3;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has base length of {baseLength} and it has base width of {baseWidth} and it " +
                $"has height of {Height} and his volume is: ");
        }
    }
    class Cylinder : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public Cylinder(double Radius,double Height)
        {
            Name = "Cylinder";
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double Volume()
        {
            return Math.Pow(Radius, 2) / 4 * Math.PI * Height;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has radius of {Radius} and it has height of {Height} " +
                $"and his volume is: ");
        }
    }
    class Cube : Shape
    {
        public double Length { get; set; }
        public Cube(double Length)
        {
            Name = "Cube";
            this.Length = Length;
        }
        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has length of {Length} and his volume is: ");
        }
    }
      class Cone : Shape
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public Cone(double Radius,double Height)
        {
            Name = "Cone";
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double Volume()
        {
            return Math.Pow(Radius, 2) * Math.PI * Height / 3;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"it has radius of {Radius} and it has height of {Height}" +
                $" and his volume is:");
        }
    }
}
