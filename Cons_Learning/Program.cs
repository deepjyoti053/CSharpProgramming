namespace Cons_Learning
{
    internal class Program
    {
        
            
        static void Main(string[] args)
        {
            Cons_Learning Obj = new Cons_Learning("Mustang", "Red", 1970);
            Cons_Learning Obj1 = new Cons_Learning("Default", "Black", 1875 );

            Console.WriteLine(Obj.model + " " + Obj.color + " " + " " + Obj.year);
            Console.WriteLine(Obj1.model + " " + Obj1.color + " " + Obj1.year);
            Console.ReadKey();
        }
    }
}
