using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeDetail
    {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public int EmpSalary { get; set; }
            public EmployeeDetail(int eid, string ename, int esalary)
            {
                this.EmpId = eid;
                this.EmpName = ename;
                this.EmpSalary = esalary;
            }
        }
        class EmpDet
        {
            public static void Main()
            {
                ArrayList arr = new ArrayList();
                EmployeeDetail emp1 = new EmployeeDetail(1, "Zakia", 7000);
                EmployeeDetail emp2 = new EmployeeDetail(2, "Parween", 12000);
                EmployeeDetail emp3 = new EmployeeDetail(3, "Jaanvi", 16000);
                arr.Add(emp1);
                arr.Add(emp2);
                arr.Add(emp3);

                foreach (EmployeeDetail emp in arr)
                {
                    Console.WriteLine(emp.EmpId + " " + emp.EmpName + " " + emp.EmpSalary);
                }
            }
        }
    }

