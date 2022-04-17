using System;

namespace Assignment1
{
    internal class Calculator
    {
        public static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1 for Addition: ");
            Console.WriteLine("2 for Subtraction: ");
            Console.WriteLine("3 for Multiplication: ");
            Console.WriteLine("4 for Division: ");
            Console.WriteLine("Enter key to perform opration: ");
            int opr = Convert.ToInt32(Console.ReadLine());

            switch (opr)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;
            }
            Console.WriteLine("Result: " + result);
        }

    }
}
