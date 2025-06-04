using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Calculator
    {
        private int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int cpAdd(int a, int b)
        {
            int result = Add(a, b);
            return result;
        }
    }
}
