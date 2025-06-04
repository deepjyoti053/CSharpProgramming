using System.Net.Security;

namespace Switch_Case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Day = 0;
            
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                        Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.Write("Hello ");
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wait for weekend");
                    break;
                   }
            
            Console.ReadKey();
        }
    }
}
