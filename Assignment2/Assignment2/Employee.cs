using System;

namespace Assignment2
{
    internal class Employee
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
        public Employee(int empNumber, string empName, double empSalary)
        {
            EmpNo = empNumber;
            empName = empName;
            Salary = empSalary;
            if (Salary >= 20000)
            {
                HRA = Salary * 30 / 100;
                TA = Salary * 25 / 100;
                DA = Salary * 35 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 15000)
            {
                HRA = Salary * 25 / 100;
                TA = Salary * 20 / 100;
                DA = Salary * 30 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 10000)
            {
                HRA = Salary * 20 / 100;
                TA = Salary * 15 / 100;
                DA = Salary * 25 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary >= 5000)
            {
                HRA = Salary * 15 / 100;
                TA = Salary * 10 / 100;
                DA = Salary * 20 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else
            {
                HRA = Salary * 10 / 100;
                TA = Salary * 5 / 100;
                DA = Salary * 15 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
        }

        public void CalculateSalary()
        {
            this.PF = this.GrossSalary * 10 / 100;
            this.TDS = this.GrossSalary * 18 / 100;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
        }

        public void displayGrossSalary()
        {
            Console.WriteLine("Gross salary of employee " + GrossSalary);
            // return GrossSalary;
        }
    }
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id ");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter Employee Employee's Salaray': ");
            double salaray = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(empId, empName, salaray);
            emp.displayGrossSalary();
            // Console.WriteLine("Gross salary of employee " + salary);
            // Console.WriteLine("Gross salary of employee " + emp.GrossSalary);
            Console.ReadLine();
        }

    }
}
