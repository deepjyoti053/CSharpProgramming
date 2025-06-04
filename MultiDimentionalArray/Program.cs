namespace MultiDimentionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] NewArray = { { 3, 8, 7 },
                              { 6,8,6} };
            //NewArray[1, 1] = 10;
            // Console.WriteLine(NewArray[1,1]);
            //foreach (int i in NewArray)
            // {
            //     Console.WriteLine(i);
            // }

            for (int i = 0; i < NewArray.GetLength(0); i++) 
            {
                for ( int j=0; j < NewArray.GetLength(1); j++) 
                {
                    Console.WriteLine(NewArray[i,j]);
                    
                }
            }

            Console.ReadKey();
        }
    }
}
