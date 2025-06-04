using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poly
{
   internal class Organisation
    {
        string OrganisationName = "ABC Ltd";

        public virtual void ShowName()
        { 
        Console.WriteLine($"Name of Oraganisation is {OrganisationName}");
        }
    }

    class Department:Organisation
    {
        string Depart = "Software Developer";
        public override void  ShowName()
        {
            Console.WriteLine($"Name of Department is {Depart}");
        }
    }



     class Employee:Department
    {
        string EmployeeName = "Deep Jyoti";
        public override void ShowName()
        {
            Console.WriteLine($"Name of Employee is {EmployeeName}");
        }
         
    }

    


}
