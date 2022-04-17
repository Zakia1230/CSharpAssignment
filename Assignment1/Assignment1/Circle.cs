using System;
namespace Assignment1
{
    internal class Circle
    {
        public static void circumferenceAndArea(double radius)
        {
            double circumference = (double)2 * 22 / 7 * radius;
            double area = (double)22 / 7 * radius * radius;
            Console.WriteLine("Circumference of circle: " + circumference);
            Console.WriteLine("area of circle: " + area);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter radius of the Circle: ");
            double num = Convert.ToDouble(Console.ReadLine());

            circumferenceAndArea(num);

        }

    }
}
