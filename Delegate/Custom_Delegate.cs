using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
   internal class Custom_Delegate
  {
        int num = 10;

        public void f()
        {
            Add(5);
            Console.WriteLine(num);
        }
        public void Add(int x)
        {
            num = num + x;
        }
 
  }
}
