using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{

    public class Organisation
    {
        int est_Year = 2012;
        string Org_Name = "HCL";

        public void Orag()
        {
            Console.WriteLine();
            Console.WriteLine($"Organisation Name is {Org_Name} and Year of Establishment is {est_Year}. ");
        }

    }

    internal class Department:Organisation
    {
        protected int Emp_Id = 6008;
        string EmpName = "Pradeep";

        protected void Dept()
        {
            Console.WriteLine();
            Console.WriteLine($"Name of the Employee is {EmpName} and Emp Id is {Emp_Id}.");
        }

    }



    public class Employee : Organisation
    {
        public Employee()
        {
            int Employee_ID;
            string Employee_Name;
        }

        public void Employees()
        {
            int Employee_ID = 2;
            string Employee_Name = "Deep Jyoti";

            Console.WriteLine($"Name of Employee is {Employee_Name} and Employee_Id is {Employee_ID}.");
        }
    }


    sealed class Vendor
    {
        string vendor_Name = "ABC";

        public void Vendor_1()
        {
            Console.WriteLine();
            Console.WriteLine($"Vendor Name is {vendor_Name}.");
        }
    }
}
