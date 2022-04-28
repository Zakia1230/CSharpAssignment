using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edetail
{
    public class EmpDet
    {
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Department
        {
            get;
            set;
        }
    }

    public class EmployeeData
    {
        public static void Main(string[] args)
        {
            List<EmpDet> empList = new List<EmpDet>();
            empList.Add(new EmpDet()
            {
                Id = 1,
                Name = "Shreesh",
                Department = "CSE"
            });
            empList.Add(new EmpDet()
            {
                Id = 2,
                Name = "Raj",
                Department = "IT"
            });
            empList.Add(new EmpDet()
            {
                Id = 3,
                Name = "Amit",
                Department = "CSE"
            });
            Console.WriteLine(empList.Count);
            foreach (var data in empList)
            {
                Console.WriteLine("Employee Id: {0} Name: {1} Department: {2}", data.Id, data.Name, data.Department);
            }

        }
    }
}

