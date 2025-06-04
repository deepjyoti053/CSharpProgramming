using System.Reflection.Metadata;
using System.Security.Principal;

namespace Interface_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string role = "IAdm";
            switch (role)
            {
              case "IMD":
              IMD Obj = new Organisation();
              Obj.f1();
              break;

                case "ISG":
                    ISG Obj1 = new Organisation();
                    Obj1.f2();
                    Obj1.f3();
                break;

                case "ISup":
                    ISup Obj2 = new Organisation();
                    Obj2.f3();
                    Obj2.f4();
                    
                 break;

                case "IAdmin":
                    IAdmin Obj3 = new Organisation();
                    Obj3.f1();
                    Obj3.f3();
                    Obj3.f5();
                    break;

                default:
                    Console.WriteLine("Invalid role");
                    break;

            }
            Console.ReadKey();




        }

    }
}
