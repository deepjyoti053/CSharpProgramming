using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    interface IFirstInterface
    {
        void mymethod();
    
    }

    interface Isecondinterface
    {
        void myothermethod();
    }   
        class Democlass:IFirstInterface, Isecondinterface
        {
            public void mymethod()
            {
            Console.WriteLine("Some text are.....");
            }

             public void myothermethod()
              {
            Console.WriteLine("Some other text are.....");
              }

        }

    }


