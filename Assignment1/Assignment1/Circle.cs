using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Circle
    {
        public static double circumferenceOfCircle(double radius)
        {
            double circumference;
            circumference = 2 * 22 / 7 * radius;
            return circumference;
        }

        public static double areaOfCircle(double radius)
        {
            double area;
            area = 22 / 7 * radius * radius;
            return area;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter radius of the Circle: ");
            int num = Convert.ToInt32(Console.ReadLine());

            double circumference = circumferenceOfCircle(num);
            double area = areaOfCircle(num);
            Console.WriteLine("Circumference of circle " + circumference);
            Console.WriteLine("area of circle " + area);
        }

    }
}
