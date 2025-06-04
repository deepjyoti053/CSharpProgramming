namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Constructor_Class objC1 = new Constructor_Class();

            Constructor_Class objC2 = new Constructor_Class("Black");
            Console.WriteLine(objC1.Color_C1);


            Console.ReadKey();
        }
    }
}
