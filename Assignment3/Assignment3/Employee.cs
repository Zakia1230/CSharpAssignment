using System;

namespace Assignment3
{
    interface IPrintable
    {
        double calculateGrossSalary();
    }
    // base class
    class Employee : IPrintable
    {

        private int emp_no;
        private string emp_name;
        private double emp_salary;
        public int empNo
        {
            get { return emp_no; }
            set { emp_no = value; }
        }
        public string empName
        {
            get { return emp_name; }
            set { emp_name = value; }
        }
        public double empSalary
        {
            get { return emp_salary; }
            set { emp_salary = value; }
        }

        public virtual double calculateGrossSalary()
        {
            return emp_salary;
        }

    }

    // derived class of Employee 
    class Manager : Employee
    {

        private double PA { set; get; }
        private double FA { set; get; }
        private double OA { set; get; }

        public Manager(int empNnumber, string name, double salary)
        {
            empNo = empNnumber;
            empName = name;
            empSalary = salary;
            PA = salary * 8 / 100;
            FA = salary * 13 / 100;
            OA = salary * 3 / 100;
        }

        public override double calculateGrossSalary()
        {
            return empSalary + PA + FA + OA;
        }
    }
    // derived class of Employee 
    class MarketingExecutive : Employee
    {

        private int kmTravel { set; get; }
        private double TA { set; get; }
        private double TelephoneA { set; get; }

        public MarketingExecutive(int empNnumber, string name, double salary, int traveledKm)
        {
            empNo = empNnumber;
            empName = name;
            empSalary = salary;
            kmTravel = traveledKm;
            TA = traveledKm * 5;
            TelephoneA = 1000;
        }

        public override double calculateGrossSalary()
        {
            return empSalary + TA + TelephoneA;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Manager Id");
            int MId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Manager Name");
            string MName = Console.ReadLine();
            Console.WriteLine("Enter the Manager Salary");
            double MSalary = Convert.ToDouble(Console.ReadLine());
            Manager manager1 = new Manager(MId, MName, MSalary);

            Console.WriteLine("Enter the MarketingExecutive Id");
            int MEId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the MarketingExecutive Name");
            string MEName = Console.ReadLine();
            Console.WriteLine("Enter the MarketingExecutive Salary");
            double MESalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Travelling Km");
            int MKm = Convert.ToInt32(Console.ReadLine());
            MarketingExecutive mExecutive1 = new MarketingExecutive(MEId, MEName, MESalary, MKm);

            double managerSalary = manager1.calculateGrossSalary();
            double mExecutiveSalary = mExecutive1.calculateGrossSalary();

            Console.WriteLine("Manager Gross Salary " + managerSalary);
            Console.WriteLine("Marketing Executive Gross Salary " + mExecutiveSalary);
            Console.ReadLine();
        }
    }

}
