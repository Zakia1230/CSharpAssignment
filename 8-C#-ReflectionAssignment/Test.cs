using System;
using System.Reflection;

namespace Assignment8
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property, AllowMultiple = true)]

    class SoftwareAttribiute : System.Attribute
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartDate;
        private string EndDate;
        public string ProjName
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }

        public string ProjDescription
        {
            get { return Description; }
            set { Description = value; }
        }

        public string clientName
        {
            get { return ClientName; }
            set { ClientName = value; }
        }

        public string startDate
        {
            get { return StartDate; }
        }

        public string endDate
        {
            get { return EndDate; }
            set { EndDate = value; }
        }

        public class HDFCAccount : SoftwareAttribiute
        {
            public void DisplayAccount(string ProjName, string ProjDescription, string clientName)
            {
                this.ProjectName = ProjName;
                this.ProjDescription = Description;
                this.ClientName = clientName;
                Console.WriteLine("Project Name: " + ProjName);
                Console.WriteLine("Project Description: " + ProjDescription);
                Console.WriteLine("Project Client Name: " + clientName);
            }
        }

        public class ICICIAccount : SoftwareAttribiute
        {
            public void AccountDetail(string ProjName, string ProjDescription, string clientName, string startDate, string EndDate)
            {
                this.ProjectName = ProjName;
                this.ProjDescription = Description;
                this.ClientName = clientName;
                this.StartDate = startDate;
                this.endDate = EndDate;
                Console.WriteLine("Project Name: " + ProjName);
                Console.WriteLine("Project Description: " + ProjDescription);
                Console.WriteLine("Project Client Name: " + clientName);
                Console.WriteLine("Project Start Date: " + StartDate);
                Console.WriteLine("Project End Date: " + EndDate);
            }
        }
        class Test
        {
            static void Main(string [] args)
            {
                HDFCAccount hdfcAccount = new HDFCAccount();
                hdfcAccount.DisplayAccount("New Batch Project", "iTransform", "iTransform Microsoft .Net");
                ICICIAccount icicAccount = new ICICIAccount();
                icicAccount.AccountDetail("New Batch Project", "iTransform", "iTransform Microsoft .Net", "22-03-2022", "30-06-2022");

                Assembly excuting = Assembly.GetExecutingAssembly();
                Type [] types = excuting.GetTypes();
                foreach (Type t in types)
                {
                    MethodInfo[] mi = t.GetMethods();
                    foreach (var m in mi)
                    {
                        Console.WriteLine(m);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
