//Pattern Matching Program with both "is" expression and "Switch case" statement.
using System;

namespace PatternMatching
{
    public class Shape
    {
        public const double pi = 3.14;
    }

       public class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }        
    }

    public class Circle : Shape
    {
        public double radius { get; set; }
    }

    class PatterMatchingDemo
    {
        public static void CalculateArea(Shape S)
        {
            //c# 7.0 Feature using is expression
          /*  if (S is Circle c)
            {
                Console.WriteLine("Area of Circle: " + c.radius * c.radius * Circle.pi);
            }
            else if (S is Rectangle r)
            {
                Console.WriteLine("Area of Rectangle: " + r.length * r.width);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", nameof(S));
            }*/

            //c# 7.0 Feature using switch expression
            switch (S)
            {
                case Rectangle rec when rec.length == rec.width:
                    Console.WriteLine("Area of Square: " + rec.length * rec.width);
                    break;

                case Rectangle rec:
                    Console.WriteLine("Area of Rectangle: " + rec.length * rec.width);
                    break;

                case Circle cir:
                    Console.WriteLine("Area of Circle: " + cir.radius * cir.radius * Circle.pi);
                    break;

            }
        }

        public static void Main(string[] args)
        {
            //object initializer
            Rectangle r1 =new Rectangle { length = 44.23, width = 12 };
            Rectangle r2 = new Rectangle { length = 24.21, width = 24.21 };
            Circle c = new Circle { radius = 34 };

            CalculateArea(r1);
            CalculateArea(r2);
            CalculateArea(c);

            Console.ReadLine();
        }

    }
}

