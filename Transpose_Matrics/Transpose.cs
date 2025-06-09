using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose_Matrics
{
    //Accept a 3 X 3 Matrix and display TRANSPOSE Matrix.

    class Transpose
    {
        public void Matrics()
        {
            int[,] array = new int[3,3];
            int[,] trans = new int[3,3];

            Console.WriteLine("Enter the array element : ");

            for (int i = 0; i<3; i++)

            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine((i,j));
                     array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Original Array");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

        
            // Transpose
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    trans[j,i] = array[i,j];
                }
            }

            Console.WriteLine("Transpose of the Matrics is : ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(trans[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }      
}
