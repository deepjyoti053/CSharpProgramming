using System.Net.Security;

namespace Concatanation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Pradip";
            string MiddleName = "Kumar";
            string LastName = "Rausion";
            string FullName = string.Concat(FirstName, MiddleName, LastName);
            string FullName3 = $"{FirstName} {MiddleName} {LastName}";
            Console.WriteLine(FullName);
            string FullName1 = FirstName + " " + MiddleName + " " + LastName;
            Console.WriteLine(FullName1);

            int x = 10;
            int y = 20;
            int z = x + y;
            Console.WriteLine(z);
            string x1 = "10";
            string y1 = "20";
            string z1 = x1 + y1;
            Console.WriteLine(z1);
            // Console.ReadKey();

            // String Interpolation

            string FirstName1 = "DEEP";
            string LastName1 = "JYOTI";
            string FullName2 = $"{FirstName1} {LastName1}";
            Console.WriteLine(FullName2);
            string name3 = "Deep";
            Console.WriteLine(name3[0]);
            string txt = "I am \"Deep Jyoti\" From North India";
            Console.WriteLine(txt);
            string txt1 = "Hello It\'s Me";
            Console.WriteLine(txt1);

            Console.ReadKey();


        }
    }
}

