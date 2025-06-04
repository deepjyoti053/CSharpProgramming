using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   public class Addition
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of Two No is {x+y}");
        }
    }

    public class Addition1:Addition
    {
        public void Add(int x1, int x2, int x3)
        {
            Console.WriteLine($"Addition of Three No is {x1+x2+x3}");
        }
    }
}
