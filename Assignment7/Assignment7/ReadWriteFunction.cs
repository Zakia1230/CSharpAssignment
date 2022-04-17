using System;
using System.IO;

namespace Assignment7
{
    class Account
    {
        public string accountNO { get; set; }
        public string accountName { get; set; }
        public double balance { get; set; }
        private const double MINIMUN_BAL = 1000;



        /*StreamReader sr = File.OpenText(@"C:\Users\HP\Desktop\Capgemini\learningLinks.txt");
        {
            string file = null;

            while ((file = sr.ReadLine()) != null)
            {
                Console.WriteLine("{0}", file);
            }
            Console.WriteLine("File Printed.");
        }


    public static void WriteToFile()
    {
        using (StreamWriter sw = File.CreateText(@"E:\Programming Practice\CSharp\Console\table.tbl"))
        {
            sw.WriteLine("Please find the below generated table of 1 to 10");
            sw.WriteLine("");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    sw.WriteLine("{0}x{1}= {2}", i, j, (i * j));
                }
                sw.WriteLine("==============");
            }
            Console.WriteLine("Table successfully written on file.");
        }
    }*/

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
        /*public void UpdateAccountData()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\HP\source\repos\Assignment7");
            Console.WriteLine(text);

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(text))
            {
                sw.WriteLine("accNo");
                sw.WriteLine("name");
                sw.WriteLine("amount");

            }
        }*/

        public class ReadWriteFunction
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter account no: ");
                string accNO = Console.ReadLine();
                Console.WriteLine("Enter account holder name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter account intitail ammount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Account acc = new Account(accNO, name, amount);
                //acc.UpdateAccountData();
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
}
