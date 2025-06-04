namespace OOP_Concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            oops Objof = new oops(10, 20);

            Console.WriteLine("x: " + Objof.x);
            Console.WriteLine("y: " + Objof.y);
            // Console.WriteLine("Sum: " + Objof.Add());


            /* oops Objofoops = new oops();
            Console.WriteLine("x : " + Objofoops.x);
            Console.WriteLine("y : " + Objofoops.y);


           // SumofTwoNo.Add();

            Console.WriteLine("Sum :" + SumofTwoNo.Add()); */
            oops SumofTwoNo = new oops(10, 20);
            SumofTwoNo.Add1();

            oops ObjSubstraction = new oops(50, 20);
            ObjSubstraction.Substraction2();

            oops ObjMutiply = new oops(5,20);
            ObjMutiply.Multiplication3();

            oops ObjSwitch = new oops(7,8);
            ObjSwitch.Switch_Case();


            Console.ReadKey();
        }
       



    }
}
