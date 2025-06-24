using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Async_Class
    {
        public async void f()
        {
              await Task.Run(new Action(f1));
              await Task.Run(new Action(f2));
              Task.Run(new Action(f3));
              
        }

         public void f1()
        {
            for (int n1 = 1; n1 <= 3; n1++)
            {
                Thread.Sleep(50);
                Console.WriteLine("I am from f1 {0}, Value is " + n1);
            }
        }
        public void f2()
        {
            for(int n2 = 1; n2 <= 3; n2++)
            {
                Thread.Sleep(50);
                Console.WriteLine("I am from f2 {0}, Value is " + n2);
            }
        }
        public void f3()
        {
            for(int n3 = 1; n3 <= 3; n3++)
            {
                Thread.Sleep(50);
                Console.WriteLine("I am from f3 {0}, Value is " + n3);
            }
        }
    }
}
