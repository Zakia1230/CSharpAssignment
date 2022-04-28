using System;
using System.Collections.Generic;
namespace Assignment6
{
    internal class Account
    {
        public string accountNO { get; set; }
        public string accountName { get; set; }
        public double balance { get; set; }
        private const double MINIMUN_BAL = 1000.00;

        public Account(string accountNUmber, string name, double bal)
        {
            accountNO = accountNUmber;
            accountName = name;
            balance = bal;
        }

        public void deposit(double bal)
        {
            balance += bal;
            Console.WriteLine("Deposited amount: " + bal);
            Console.WriteLine("Total balance: " + balance);
        }

        public void withdrawal(double bal)
        {
            if (balance <= MINIMUN_BAL)
            {
                Console.WriteLine("Warning: Minimun balance occured");
            }

            if (balance - bal < 0)
            {
                Console.WriteLine("Can perform this action: Insufficient balance");
            }
            else
            {
                balance -= bal;
                Console.WriteLine("Withdrwal amount: " + bal);
                Console.WriteLine("Total balance: " + balance);
            }
        }
    }

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Eneter account no: ");
            string accNO = Console.ReadLine();
            Console.WriteLine("Eneter account holder name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Eneter account intitail ammount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Account acc = new Account(accNO, name, amount);
            Console.WriteLine("Enter 1 to deposit: ");
            Console.WriteLine("Enter 2 to withdrwal: ");
            Console.WriteLine("Enter 3 for exit: ");
            while (true)
            {
                Console.WriteLine("Enter Your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposite: ");
                        double amountToDeposit = Convert.ToDouble(Console.ReadLine());
                        acc.deposit(amountToDeposit);
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdrawal: ");
                        double amountToWithdrawal = Convert.ToDouble(Console.ReadLine());
                        acc.withdrawal(amountToWithdrawal);
                        break;
                    default:
                        Console.WriteLine("Invalid params");
                        break;
                }

                if (choice == 3)
                {
                    break;
                }
            }
            Console.WriteLine("Program ended");
            Console.ReadLine();
        }

    }
}
