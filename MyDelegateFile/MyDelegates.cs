using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegateFile
{
    internal class MyDelegates
    {
        public delegate void MyDel(int x);
        int Num=10;

        public void f()
        {
            MyDel del = new MyDel(Add);
            MyDel del1 = new MyDel(Multiply);
            MyDel del2 = new MyDel(Divide);
          //  MyDel del3 = del1 + del2;
                
            
            del1(10);
            del(5);
            del2(5);
          //  del3(10);
            
            Console.WriteLine(Num);
        }

        public void Add(int x)
        {
            Num = Num + x;
        }

        public void Multiply(int x)
        {
            Num = Num * x;
        }

        public void Divide(int x)
        {
            Num = Num / x;
        }


    }
}
