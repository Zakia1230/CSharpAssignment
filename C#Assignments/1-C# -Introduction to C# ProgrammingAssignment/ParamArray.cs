using System;

namespace Assignment1
{
    internal class ParamArray
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           // int[] arr = { 12, 15, 5, 10, 20 };
            int sum = sumOfArray(arr);
            Console.WriteLine("Sum of array: " + sum);
        }

        public static int sumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
