using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class MyStack
    {
        public int[] stack = new int[10];
        public int TOP = -1;
        public int size { get; set; }

        public MyStack(int stackSize)
        {
            size = stackSize;
        }

        public void push(int num)
        {
            if ((TOP + 1) < size)
            {
                TOP++;
                stack[TOP] = num;
            }
            else
            {
                throw new StackException("Upper bound limit acceded");
            }
        }

        public void pop()
        {
            if (TOP != -1)
            {
                TOP--;
            }
            else
            {
                throw new StackException("Lower bound limit acceded");
            }
        }
    }

    class StackException : Exception
    {
        public StackException() { }

        public StackException(string name)
            : base(String.Format("Stack exception: {0}", name))
        {

        }
    }

    public class Stack
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of stack: ");
            int stackSize = Convert.ToInt32(Console.ReadLine());
            MyStack m1 = new MyStack(stackSize);
            Console.WriteLine("1. Push Operation");
            Console.WriteLine("2. Pop Operation");
            Console.WriteLine("3. Show All");
            while (true)
            {
                try
                {
                    Console.Write("Enter your Choice:");
                    int menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Enter the Elements: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            m1.push(num);
                            break;
                        case 2:
                            m1.pop();
                            break;
                        case 3:
                            for (int i = 0; i < m1.TOP + 1; i++)
                                Console.Write(" " + m1.stack[i]);
                            break;
                        default:
                            Console.WriteLine("Invalid params");
                            break;
                    }

                    if (menu > 3)
                    {
                        break;
                    }

                }
                catch (StackException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            Console.WriteLine("Program ended");
            Console.ReadKey();
        }

    }
}
