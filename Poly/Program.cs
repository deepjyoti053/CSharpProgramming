namespace Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organisation MyObj;

            MyObj = new Organisation();
            MyObj.ShowName();

           MyObj = new Department();
            MyObj.ShowName();

           MyObj = new Employee();
            MyObj.ShowName();


            
            Console.ReadKey();
        }
    }
}
