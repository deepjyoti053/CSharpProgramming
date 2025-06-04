using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{


    public class oops
    {
        public int x;
        public int y;

        public oops(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public void Switch_Case()
        {
            Console.WriteLine("1.\t\tAdd1\n2.\t\tSubstraction2\n3.\t\tMultiplication3");
            Console.WriteLine("Read above and Enter Your Choices");
            int Choices = Convert.ToInt32(Console.ReadLine());

            int Sum = x + y;
            int Substraction = x - y;
            int Multiplication = x * y;
            switch (Choices)
            {
                case 1: Console.WriteLine("Sum is : " + Sum);

                    break;

                case 2: Console.WriteLine("Substraction is : " + Substraction);
                    break;

                case 3: Console.WriteLine("Multiplication is : " + Multiplication);
                    break;

                default:
                    Console.WriteLine("Invalid Choices");
                    break;
            }


        }



        public void Add1()

        {
            int Sum = x + y;
            Console.WriteLine(Sum);

        }

        public void Substraction2()
        {
            int Subs = x - y;
            Console.WriteLine(Subs);
        }

        public void Multiplication3()
        {
            int Multiply = x * y;
            Console.WriteLine(Multiply);
        }

    
    }

}

