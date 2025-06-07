using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Exception_Class
    {
        public void f1()
        {
            try
            {
                Exception_3();
            }

            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }


            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Exception_1()
        {
            Console.WriteLine("Enter the 1st Number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number : ");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                int z = x / y;
                Console.WriteLine("Result : " + z);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            
            try
            {
                int k = x + y;
                Console.WriteLine("Sum of No. is : " + k);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void Exception_2()
        {
            Console.WriteLine("Enter the 1st Number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number : ");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (y == 0)
                {
                    throw new ArithmeticException("Dear user, Don't enter 0 for the y.");
                }
                else
                {
                    int z = x / y;
                    Console.WriteLine(z);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void Exception_3()
        {
            Console.WriteLine("Enter the 1st Number : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number : ");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (y == 0)
                {
                    throw new MyCustomException("Don't enter 0 for y");
                }
                else 
                {
                   int z= x / y;
                    Console.WriteLine(z);
                }

            }

            finally
            {
                GC.Collect();
            }

        } 
           


    }
}
