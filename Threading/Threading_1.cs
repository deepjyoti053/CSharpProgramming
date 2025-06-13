using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class Threading_1
    {
        public void f()
        {
            Thread t1 = new Thread(new ThreadStart(f1));
            Thread t2 = new Thread(new ThreadStart(f2));
          
            t1.Start();
            t2.Start();

        }
        public void f1()
        {
            for (int i = 0; i <= 20; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("f1 value is {0}", i);
            }
        }

        public void f2()
        {
            for (int i = 0; i <= 20; i++)
            {
                Thread.Sleep(50);
                Console.WriteLine("f2 value is {0}", i);
            }
        }

    }
}
