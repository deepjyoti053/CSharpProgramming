namespace Return
{
    internal class Program
    {

        static int Add(int x, int y) 
        {
           return x + y;
        }
        static int Subtract(int x1, int y1)
        {
            return x1 - y1;
        }

        static double plusMethod(double x2, double y2) 
        {
            return x2 + y2;
        }
      

        static void Main(string[] args)
        {
            int z = Add(14,6);
            int z1 = Subtract(20,10);
            double z3 = plusMethod(4.6, 7.8);
            //Console.WriteLine(Add(14,6));
            //Console.WriteLine(Subtract(20,10));
            Console.WriteLine("Sub " + z1);
            Console.WriteLine("Add " + z);
            Console.WriteLine(z3);
            Console.ReadKey();
        }
    }
}
