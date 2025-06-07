using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Check_Array
{
  /*Accept an integer array of 6 elements and then accept another number to check whether the
     number exists in the array or not.*/
    class Array_of_6_Element
    {
        public void array_1()
        {

            int[] Arr = new int[6];
            Console.WriteLine("Enter the 6 Number of Elements : ");
            
            for (int i = 0; i<6; i++)
            {
                //Console.WriteLine(i);
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered element of Array is : ");
            foreach (int element in Arr)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Enter the Number to check whether the number exits in the array or not : ");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Arr.Contains(Num))
                {
                    Console.WriteLine($"{Num} exits in the array");
                }

                else
                {
                    Console.WriteLine($"{Num} doesn't exists in the array.");
                }
                
            }
                      

    }
}
