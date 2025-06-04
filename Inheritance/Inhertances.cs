using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ParentClass
    {
        public string model = "Ford";
    }
    public class ChildClass : ParentClass
    {
        public string brand = "Mustang";
        public void Vehicle()
        {
            Console.WriteLine("Model Name is Ford and Mustang");
        }

    }


}
