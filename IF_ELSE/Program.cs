namespace IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int time = 10;

             if (time > 10)
             {
                 Console.WriteLine("Good Day");
             }
             else if (time < 10)
             {
                 Console.WriteLine("Good Evening");
             }

             else
             {
                 Console.WriteLine("Good Night");
             }
             */

            int time = 10;
            string result = (time > 20) ? ("Good Morning") : ("Good Evening");
            Console.WriteLine(result);




                Console.ReadKey();
            }
        }
    }

