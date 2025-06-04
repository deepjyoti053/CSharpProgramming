namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of Fibonacci series ");
            int Num = Convert.ToInt32(Console.ReadLine());

            Fibonacii MyObj = new Fibonacii();
           
            MyObj.Series(Num);
        }
    }
}
