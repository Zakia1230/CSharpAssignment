using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Manager
    {
        public int MID { get; set; }
        public string MName { get; set; }
        public int Msalary { get; set; }
        public static void ManagerDetail(List<Manager> ManagerList)
        {
            foreach (Manager mng in ManagerList)
            {
                if (mng.Msalary >= 5000)
                {
                    Console.WriteLine(mng.MName);
                }
            }
        }
        public static void Main()
        {
            List<Manager> mng = new List<Manager>();
            mng.Add(new Manager() { MID = 101, MName = "Ravi", Msalary = 2000 });
            mng.Add(new Manager() { MID = 102, MName = "John", Msalary = 3000 });
            mng.Add(new Manager() { MID = 103, MName = "Mary", Msalary = 80000 });
            mng.Add(new Manager() { MID = 104, MName = "Mike", Msalary = 10000 });
            Manager.ManagerDetail(mng);
        }
    }

}
