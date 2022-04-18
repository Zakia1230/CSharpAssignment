using System;

namespace Assignment2
{
    internal class Employee1
    {
        private int EmpNo { get; set; }
        private string EmpName { get; set; }
        private double Salary { get; set; }
        private double HRA { get; set; }
        private double TA { get; set; }
        private double DA { get; set; }
        private double PF { get; set; }
        private double TDS { get; set; }
        private double NetSalary { get; set; }
        private double GrossSalary { get; set; }

        // Parameterized Constructor
        // User defined
        public Employee1(int empNumber, string empName, double empSalary)
        {
            EmpNo = empNumber;
            empName = empName;
            Salary = empSalary;
            if (Salary >= 20000)
            {
                HRA = (double)Salary * 30 / 100;
                TA = (double)Salary * 25 / 100;
                DA = (double)Salary * 35 / 100;
                GrossSalary = (double)Salary + HRA + TA + DA;
            }
            else if (Salary >= 15000)
            {
                HRA = (double)Salary * 25 / 100;
                TA = (double)Salary * 20 / 100;
                DA = (double)Salary * 30 / 100;
                GrossSalary = (double)Salary + HRA + TA + DA;
            }
            else if (Salary >= 10000)
            {
                HRA = (double)Salary * 20 / 100;
                TA = (double)Salary * 15 / 100;
                DA = (double)Salary * 25 / 100;
                GrossSalary = (double)Salary + HRA + TA + DA;
            }
            else if (Salary >= 5000)
            {
                HRA = (double)Salary * 15 / 100;
                TA = (double)Salary * 10 / 100;
                DA = (double)Salary * 20 / 100;
                GrossSalary = (double)Salary + HRA + TA + DA;
            }
            else
            {
                HRA = (double)Salary * 10 / 100;
                TA = (double)Salary * 5 / 100;
                DA = (double)Salary * 15 / 100;
                GrossSalary = (double)Salary + HRA + TA + DA;
            }
        }

        public void CalculateSalary()
        {
            PF = (double)GrossSalary * 10 / 100;
            TDS = (double)GrossSalary * 18 / 100;
            NetSalary = (double)GrossSalary - (PF + TDS);
        }

        public void displayGrossSalary()
        {
            Console.WriteLine("Gross salary of employee " + GrossSalary);
            // return GrossSalary;
        }
    }
    public class Employee
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id ");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Employee's Salaray': ");
            double salaray = Convert.ToDouble(Console.ReadLine());

            Employee1 emp = new Employee1(empId, empName, salaray);
            emp.displayGrossSalary();           
            Console.ReadLine();
        }

    }
}
