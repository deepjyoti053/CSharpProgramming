namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Level myVar = Level.Medium;
             Console.WriteLine(myVar);

             int myvar = (int) Level.Low;
             Console.WriteLine(myvar); */

            /* Month myMonth = Month.June;
             Console.WriteLine(myMonth);

             int myMonth1 = (int) Month.June;
             Console.WriteLine(myMonth1);*/

            Level MyMonth = Level.Medium;

            switch(MyMonth)
            {
                case Level.Low:
                Console.WriteLine("Low Level");
                break;

                case Level.Medium:
                Console.WriteLine("Medium Level");
                break;

                case Level.High:
                Console.WriteLine("High Medium");
                    break;
             

             }


        Console.ReadKey();
        }
    }
}
