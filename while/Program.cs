namespace While;

internal class Program
{
    static void Main(string[] args)
    {
        /*int i = 8;
        while (i <= 10) 
        {
            Console.WriteLine(i);
            i++;
        }
        Console.ReadKey();*/

        int i = -10;
        do {
            Console.WriteLine(i);
            i++;
        }
        while (i <= 10);
        Console.ReadKey();
   }
}

