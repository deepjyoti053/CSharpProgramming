using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N_Matrics
{
    //User should enter a number “n” indicating the array should n X n.
    //Accept the value into that n X n array.Find sum of both diagonal elements in it.
    class N_Class
    {
        int n;
         public void array()
        {
            int Sum_of_primaryDiagonal = 0;
            int Sum_of_secondaryDiagonal = 0;

            Console.WriteLine("Enter the size of Matrics nxn : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[n,n];
            
            Console.WriteLine("Enter the value to display array : ");


            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine((i,j));
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Array is : ");
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Sum_of_primaryDiagonal = Sum_of_primaryDiagonal + array[i, i];
                Sum_of_secondaryDiagonal = Sum_of_secondaryDiagonal + array[i,n-i-1];

                
            }
            Console.WriteLine();

            Console.WriteLine("Sum of Primary Diagonal is : " + Sum_of_primaryDiagonal);
            Console.WriteLine("Sum of Secondary Diagonal is : " + Sum_of_secondaryDiagonal);

            int Sum_of_both_Diagonal = Sum_of_primaryDiagonal + Sum_of_secondaryDiagonal;
            Console.WriteLine("Sum of both Diagonal is: " + Sum_of_both_Diagonal);

        }


    }
}
