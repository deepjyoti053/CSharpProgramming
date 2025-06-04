namespace OopsConcept
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.cpAdd(2, 3));      // Output: 5
            Console.WriteLine(calc.Subtract(5, 1)); // Output: 4

            Console.ReadKey();
        }
    }
}
