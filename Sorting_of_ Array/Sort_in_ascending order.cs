using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sorting_of__Array
{
    class Sort_in_ascending_order
    {
        public void ascending()
        { 
          int[] array = new int[5];
          Console.WriteLine("Enter the 5 element");

            for (int i=0; i<5;i++)
            {
                 array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Array is : ");

            foreach (int element in array)
            {
                Console.WriteLine(element + " ");
            }

            Console.WriteLine("Sorting of Array is : ");


            for (int i=0;i<4;i++) // This loop ensures we repeat the sorting N-1(5-1) times.
            {
                for (int j = 0; j < 5-i-1;j++)
                    //Why? Every pass moves the largest element to the end.
                    // We reduce iterations(Length - i - 1)/(5-i-1) as the largest elements settle at the end.


                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    }
            }

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

        }

    }
}
