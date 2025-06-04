using ClassLibraryProject;
namespace Namespace_Using_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine(obj.MultiplyTwoNumber(2,3));
            Console.ReadKey();
            
        }
    }
}
