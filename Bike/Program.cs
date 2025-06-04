using System.ComponentModel.DataAnnotations;

namespace Bike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike MyObj = new Bike();
            MyObj.Color = "Red";
            MyObj.Model = "Musturd";
            MyObj.Year = 1970;


            Bike MyObj1 = new Bike();
            MyObj1.Color = "Blue";
            MyObj1.Model = "Ygsxuy";
            MyObj1.Year = 1972;

            Bike MyObj2 = new Bike();
            MyObj2.Color = "Red";
            MyObj2.Model = "Musturd";
            MyObj2.Year = 1974;

            Console.WriteLine(MyObj1.Color);
            Console.WriteLine(MyObj2.Model);
            Console.WriteLine(MyObj.Year);

            Console.ReadKey();
        }
    }
}
