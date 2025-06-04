using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        public abstract void animalsound();
        public void Seep()
        {
            Console.WriteLine("Zzzzz");
        }
    }

    class Pig : Animal
    {
        public override void animalsound() 
        {
            Console.WriteLine("pig make a sound wee wee"); 
        }
    }
}
