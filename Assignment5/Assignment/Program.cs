using System;

namespace Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            object[] arr = new object[5];
            object[] arr1 = new object[5];

            Console.WriteLine("Enter the Integer numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            arr[0] = num;
            Console.WriteLine("Enter the String: ");
            string name = Console.ReadLine();
            arr[1] = name;

            Array.Copy(arr, arr1, arr.Length);
            Console.WriteLine("After coping Integer numbers: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(" " + arr1[i]);
            }

            int[] numarr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Integer numbers to insert into array: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                numarr[i] = num1;
            }

            Array.Sort(numarr);
            Console.WriteLine("After sorting of array: ");
            foreach (int i in numarr)
            {
                Console.WriteLine(" " + i);
            }

            Array.Reverse(numarr);
            Console.WriteLine("After reversing of array: ");
            foreach (int i in numarr)
            {
                Console.WriteLine(" " + i);
            }

            Array.Clear(numarr, 0, numarr.Length);
            Console.WriteLine("Array Data cleared: ");
            Console.ReadLine();
        }

    }
}
