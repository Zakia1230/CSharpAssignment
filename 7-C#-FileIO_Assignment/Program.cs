using System;
using System.IO;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String lines;
            lines = File.ReadAllText(@"C:\Users\HP\Desktop\Capgemini\learningLinks.txt");
            Console.WriteLine(lines);
            Console.ReadKey();



            string[] dir = Directory.GetDirectories(@"c:\", "p*", SearchOption.TopDirectoryOnly);
            Console.WriteLine("The number of directories:", dir.Length);
            foreach (string d in dir)
            {
                Console.WriteLine(dir);
            }
        }
    }
}

