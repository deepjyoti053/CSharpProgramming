using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    interface IMD
    {
        void f1();
    }

    interface ISG
    {
        void f2();
        void f3();
    }

    interface ISup
    {
        void f3();
        void f4();
    }

    interface IAdmin
    {
        void f1();
        void f3();
        void f5();
    }



    class Organisation:IMD, ISG, ISup, IAdmin
    {
       public void f1()
        {
            Console.WriteLine("I am from f1");
        }

        public void f2()
        {
            Console.WriteLine("I am from f2");
        }
        public void f3()
        {
            Console.WriteLine("I am from f3");
        }

        public void f4()
        {
            Console.WriteLine("I am from f4");
        }

        public void f5()
        {
            Console.WriteLine("I am from f5");
        }

    
    }
}
