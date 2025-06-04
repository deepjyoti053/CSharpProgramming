using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Parameter
{
    class Program
    {
        static void MyMethod(string Country = "India")
        {
            Console.WriteLine("Mera Bharat Mahan " + Country);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
