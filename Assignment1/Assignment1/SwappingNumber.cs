using System;

namespace Assignment1
{
    internal class SwappingNumber
    {
        public static void sawapNumber(int num1, int num2)
        {
            int temp;
            Console.WriteLine("Before Swaping: " + num1 + " " + num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swaping: " + num1 + " " + num2);
        }
        public static void Main(string[] args)
        {
            //sawapNumber(4,5);
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            sawapNumber(num1, num2);
        }

    }
}
