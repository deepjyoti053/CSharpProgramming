using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IAnimal
    {
        void AnimalSound();
    }
        class Pig : IAnimal
        {
            public void AnimalSound()
            {
                Console.WriteLine("Pig says Wee Wee");
            }
        }


    }

