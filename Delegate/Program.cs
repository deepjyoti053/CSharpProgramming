using System.Runtime.InteropServices;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Custom_Delegate Obj = new Custom_Delegate();
            Obj.f();

            Console.ReadKey();
        }
    }
}
