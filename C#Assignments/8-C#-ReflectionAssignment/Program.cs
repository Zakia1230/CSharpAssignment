using System;
using System.Reflection;
namespace Assignment8
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpID = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }

        public void empDetails()
        {
            Console.WriteLine("Enter the Employee ID : " + EmpID);
            Console.WriteLine("Enter the Employee Name : " + EmpName);
            Console.WriteLine("Enter the Employee Salary : " + EmpSalary);
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee(1, "Zakia", 17000);

                //Assembly execution 
                Assembly executing = Assembly.GetExecutingAssembly();
                Type[] types = executing.GetTypes();
                emp.empDetails();

                foreach (var item in types)
                {
                    Console.WriteLine(item.Name);
                    MethodInfo[] md = item.GetMethods();

                    foreach (var method in md)
                    {
                        //metadata
                        Console.WriteLine(method.Name);
                        Console.WriteLine(method.Attributes);
                }
                }
                Console.ReadLine();

            }

        

    }
}
