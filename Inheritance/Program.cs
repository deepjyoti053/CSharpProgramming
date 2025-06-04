using System.ComponentModel.DataAnnotations;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChildClass MyObj = new ChildClass();

            ParentClass MyObj1 = new ParentClass();

            MyObj.Vehicle();

            Console.WriteLine(MyObj1.model + " " + MyObj.brand);
            Console.ReadKey();
        }
    }
}
