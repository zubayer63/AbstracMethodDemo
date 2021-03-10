using System;

namespace Figure
{
    abstract class Program
    {
        public double width, height, radius;
        public const float pi = 3.14f;
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    class Rectangle : Program
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }
        public override double GetArea()
        {
            return width * height;

        }
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
    class Circle : Program
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * radius * pi;
        }
    }
    class Triangle : Program
    {
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double GetArea()
        {
            return 0.5 * width * height;
        }
        public override double GetPerimeter()
        {
            return width + height;
        }
        /*
         public override double GetArea()
         {
             return 0.5 * 100 * 20;
         }
         public override double GetPerimeter()
         {
             return 10 + 20;
         }


         static void Main()
         {
             //Triangle tr = new Triangle(10, 20);
             Triangle tr = new Triangle();
             Console.WriteLine("perimeter :" + tr.GetPerimeter());
             Console.WriteLine("area: " + tr.GetArea());
         }*/
    }
    class Cone : Program
    {
        public Cone(double height, double radius)
        {
            this.height = height;
            this.radius = radius;

        }
        public override double GetArea()
        {
            return pi * radius * (radius + Math.Sqrt(height * height + radius * radius));
        }
        public override double GetPerimeter()
        {
            return 0.3 * (pi * radius * radius * height);
        }
    }
    class TestFigures
    {
        static void Main()
        {
            TestFigures t = new TestFigures();
            Rectangle R = new Rectangle(12.67, 56.78);
            Circle C = new Circle(45.67);
            Triangle T = new Triangle(10, 20);
            Cone Cn = new Cone(12.98, 4.98);
            Console.WriteLine("Area of rectangle:" + R.GetArea());
            Console.WriteLine("Perimeter of rectange: " + R.GetPerimeter());

            Console.WriteLine("Area of Circl:" + C.GetArea());
            Console.WriteLine("Perimeter of circle: " + C.GetPerimeter());

            Console.WriteLine("Area of Triangle:" + T.GetArea());
            Console.WriteLine("Perimeter of triangle: " + T.GetPerimeter());

            Console.WriteLine("Area of Cone:" + Cn.GetArea());
            Console.WriteLine("Perimeter of cone: " + Cn.GetPerimeter());
        }
    }

}
