using System;
using System.IO;

delegate void setCustomerData(string name, string email, string address);
namespace Assignment7
{
    class Customer
    {
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string customerAddress { get; set; }

        public void addCustomerData(string name, string email, string address)
        {
            customerName = name;
            customerEmail = email;
            customerAddress = address;
            string lineOne = "------Customer data---------";
            string lineTwo = "Customer Name: " + customerName;
            string lineThree = "Customer Email: " + customerEmail;
            string lineFour = "Customer Adress: " + customerAddress;

            UpdateAccountData(lineOne, lineTwo, lineThree, lineFour);
        }

        public void showCustomerData()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer Email: " + customerEmail);
            Console.WriteLine("Customer Email: " + customerAddress);
        }

        public void UpdateAccountData(string lineOne = null, string linetwo = null, string lineThree = null, string lineFour = null)
        {
            string text = @"C:\Users\HP\Desktop\pandu.txt";


            // Appending the given texts
            using (StreamWriter sw = File.AppendText(text))
            {
                if (!String.IsNullOrEmpty(lineOne))
                {
                    sw.WriteLine(lineOne);
                }

                if (!String.IsNullOrEmpty(linetwo))
                {
                    sw.WriteLine(linetwo);
                }

                if (!String.IsNullOrEmpty(lineThree))
                {
                    sw.WriteLine(lineThree);
                }

                if (!String.IsNullOrEmpty(lineFour))
                {
                    sw.WriteLine(lineFour);
                }
            }
        }
    }

    public class ReadWriteFunction
    {
        public static string customerName;
        public static string customerEmail;
        public static string customerAddress;

        public static void addCustomerData(string name, string email, string address)
        {
            customerName = name;
            customerEmail = email;
            customerAddress = address;
            string lineOne = "------Customer data---------";
            string lineTwo = "Customer Name: " + customerName;
            string lineThree = "Customer Email: " + customerEmail;
            string lineFour = "Customer Adress: " + customerAddress;

            UpdateAccountData(lineOne, lineTwo, lineThree, lineFour);
        }

        public static void showCustomerData()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Customer Email: " + customerEmail);
            Console.WriteLine("Customer Email: " + customerAddress);
        }

        public static void UpdateAccountData(string lineOne = null, string linetwo = null, string lineThree = null, string lineFour = null)
        {
            string text = @"C:\Users\HP\Desktop\pandu.txt";


            // Appending the given texts
            using (StreamWriter sw = File.AppendText(text))
            {
                if (!String.IsNullOrEmpty(lineOne))
                {
                    sw.WriteLine(lineOne);
                }

                if (!String.IsNullOrEmpty(linetwo))
                {
                    sw.WriteLine(linetwo);
                }

                if (!String.IsNullOrEmpty(lineThree))
                {
                    sw.WriteLine(lineThree);
                }

                if (!String.IsNullOrEmpty(lineFour))
                {
                    sw.WriteLine(lineFour);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Eneter Customer Name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Eneter Customer Email: ");
            string customerEmail = Console.ReadLine();
            Console.WriteLine("Eneter Customer Address: ");
            string Address = Console.ReadLine();
            //create delegate instances
            setCustomerData cs = new setCustomerData(addCustomerData);
            cs(customerName, customerEmail, Address);
            Console.WriteLine("Program ended");
            Console.ReadLine();
        }
    }
}