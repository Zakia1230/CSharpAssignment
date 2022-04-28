using System;
using System.Data.SqlClient;

namespace CRUDOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn;
            string ConnectionString = @"Data Source=DESKTOP-TQ3FFEK\SQLEXPRESS;Initial Catalog=ADO_CRUD;Integrated Security=True";
            conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                Console.WriteLine("Connection establish sucessfully!!! ");
                string status;

                do
                {
                    Console.WriteLine("Select the CRUD Operations: ");
                    Console.WriteLine("1. Create");
                    Console.WriteLine("2. Select");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.Write("Choose one option: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter the Employee ID: ");
                            int EmpId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Employee Name: ");
                            string EmpName = Console.ReadLine();
                            Console.Write("Enter the salary of an Employee: ");
                            int EmpSalary = Convert.ToInt32(Console.ReadLine());
                            string InsertData = "Insert into Employee(EmpId, EmpName, EmpSalary) values ('" + EmpId + "','" + EmpName + "','" + EmpSalary + "');";
                            SqlCommand InsertCommand = new SqlCommand(InsertData, conn);
                            InsertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data inserted sucessfully!!!!");
                            break;

                        case 2:

                            string SelectData = "select * from Employee";
                            SqlCommand SelectCommand = new SqlCommand(SelectData, conn);
                            SqlDataReader reader = SelectCommand.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine("Employee ID: " + reader.GetValue(0).ToString());
                                Console.WriteLine("Employee Name: " + reader.GetValue(1).ToString());
                                Console.WriteLine("Employee Salary: " + reader.GetValue(2).ToString());
                            }
                            reader.Close();
                            break;

                        case 3:

                            int EmpID;
                            //int EmpSalary;
                            Console.WriteLine("Enter the employee Id for updation: ");
                            EmpID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the employee Salary for updation: ");
                            EmpSalary = Convert.ToInt32(Console.ReadLine());

                            string UpdateData = "Update Employee set EmpSalary = " + EmpID + " where EmpID = " + EmpSalary + "";
                            SqlCommand UpdateCommand = new SqlCommand(UpdateData, conn);
                            UpdateCommand.ExecuteNonQuery();
                            Console.WriteLine("Data updated sucessfully!!!");
                            break;

                        case 4:

                            Console.WriteLine("Enter the detail the u want to delete: ");
                            int num = Convert.ToInt32(Console.ReadLine());
                            string DeleteData = "Delete from Employee where EmpID= " + num;
                            SqlCommand DeleteCommand = new SqlCommand(DeleteData, conn);
                            DeleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Data deleted sucessfully!!!");
                            break;

                        default:

                            Console.WriteLine("Invalid Choice!!!");
                            break;


                    }

                    Console.WriteLine("Do u want to continue----");
                    status = Console.ReadLine();
                }

                while (status !="  no");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}