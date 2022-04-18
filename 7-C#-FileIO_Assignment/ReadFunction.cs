using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment7
{
    [Serializable]
    class Employee
    {
        public string empId { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
    }

    [Serializable]
    class MarketingExecutive : Employee
    {
        public int organizedEvent { get; set; }

        public MarketingExecutive(string id, string name, double salary, int events)
        {
            empId = id;
            empName = name;
            empSalary = salary;
            organizedEvent = events;
        }

        public void showData()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee employee name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Employee no Organized Events: " + organizedEvent);
        }
    }

    [Serializable]
    class Manager : Employee
    {
        public int teamSize { get; set; }

        public Manager(string id, string name, double salary, int size)
        {
            empId = id;
            empName = name;
            empSalary = salary;
            teamSize = size;
        }

        public void showData()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee employee name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Manager Team Size: " + teamSize);
        }
    }

    public class ReadFunction
    {
        public static void Main(string[] args)
        {
            // mareting executive
            Console.WriteLine("Enter MarketingExecutive empId: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter MarketingExecutive Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter MarketingExecutive Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter no of organized Events: ");
            int organizedEvent = Convert.ToInt32(Console.ReadLine());
            //create delegate instances
            MarketingExecutive me = new MarketingExecutive(id,
            name, salary, organizedEvent);

            // serialize marketing executive
            BinaryFormatter meFormatter = new BinaryFormatter();

            FileStream meFile = new FileStream(@"C:\Users\HP\Desktop\ExecutiveManager.txt", FileMode.Create, FileAccess.Write);

            meFormatter.Serialize(meFile, me);
            meFile.Close();

            // deserialize marketing executive
            BinaryFormatter meDFormatter = new BinaryFormatter();

            FileStream meReadFile = new FileStream(@"C:\Users\HP\Desktop\ExecutiveManager.txt", FileMode.Open, FileAccess.Read);

            MarketingExecutive meObj = (MarketingExecutive)meDFormatter.Deserialize(meReadFile);

            Console.WriteLine("After Deserializing of marketing executive obj");
            meObj.showData();
            meReadFile.Close();

            // manager
            Console.WriteLine("Enter Manager empId: ");
            string mId = Console.ReadLine();
            Console.WriteLine("Enter Manager Name: ");
            string mName = Console.ReadLine();
            Console.WriteLine("Enter Manager Salary: ");
            double mSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Team size of manager: ");
            int teamSize = Convert.ToInt32(Console.ReadLine());
            //create manager instances
            Manager mng = new Manager(mId,
            mName, mSalary, teamSize);

            // serialize marketing executive
            BinaryFormatter mFormatter = new BinaryFormatter();

            FileStream mFile = new FileStream(@"C:\Users\HP\Desktop\Manager.txt", FileMode.Create, FileAccess.Write);

            mFormatter.Serialize(mFile, mng);
            mFile.Close();
            // deserialize manager
            BinaryFormatter mDFormatter = new BinaryFormatter();

            FileStream mReadFile = new FileStream(@"C:\Users\HP\Desktop\Manager.txt", FileMode.Open, FileAccess.Read);

            Manager mngObj = (Manager)meFormatter.Deserialize(mReadFile);
            Console.WriteLine("After Deserializing of marketing executive obj");
            mngObj.showData();
            Console.WriteLine("Program ended");
            Console.ReadLine();
            mReadFile.Close();
        }
    }
}