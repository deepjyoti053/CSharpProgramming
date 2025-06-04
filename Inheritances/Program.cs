namespace Inheritances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee MyObj = new Employee();
            MyObj.Employees();
            MyObj.Orag();

            Department Obj2 = new Department();
           // Obj2.Dept();

            Vendor Obj1 = new Vendor();
            Obj1.Vendor_1();


            Console.ReadKey();

        }
    }
}
