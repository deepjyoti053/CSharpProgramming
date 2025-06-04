namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
             for (int i = 0; i<= 10; i++)
             {
                 Console.WriteLine(i);
             }
             Console.ReadKey();

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                  // continue;
                }
                Console.WriteLine(i);
               

            }
            Console.ReadKey();
        }

    }



           /* int i = 0;
            while (i < 10)
            {               
                Console.WriteLine(i);
                i++;
                if (i == 5) 
                {
                    continue;
                }
                
            }*/
        
}


