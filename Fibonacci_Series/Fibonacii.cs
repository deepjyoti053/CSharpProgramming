using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{

    /// <summary>
    /// 1. Display first 15 elements of Fibonacci series. ( 0,1,1,2,3,5,8,13, . . . . )
    /// </summary>
    class Fibonacii
    {
        public void Series(int Num)
        {
            int n1=0;
            int n2=1;
            int n3;
            
            Console.Write(n1+" ");
            Console.Write(n2+" ");
            for (int i=2; i<Num; i++) 
            {
                 n3 = n1 + n2;
                Console.Write(n3 + " ");

                n1 = n2;
                n2 = n3;


            }
            Console.ReadKey();

        }
    
    }
}
