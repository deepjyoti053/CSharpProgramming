namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PropertyExample obj = new PropertyExample(10,20,30,40,50,60);

            int Number1 = obj.Number1; // Assigning obj.Number1 value in Number1 by reading obj.Number1 value.
            //obj.Number1 = 20;  //Assigning of value in Number1 property is not possible bcs it is read only.

            int Number2 = obj.Number2; // Assigning obj.Number2 value in Number2 by reading obj.Number2 value.
            //obj.Number2 = 20;  //Assigning of value in Number1 property is not possible bcs it is read only.

            int Number3 = obj.Number3;
            obj.Number3 = 300;
            Number3 = obj.Number3;

            int Number4 = obj.Number4;
            obj.Number4 = 400;
            Number4 = obj.Number4;

            int Number5 = obj.Number5;
            obj.Number5 = 500;
            Number5 = obj.Number5;

            int Number6 = obj.Number6;
            obj.Number6 = 600;
            Number6 = obj.Number6;

            Console.WriteLine(obj.Number1);
            Console.WriteLine(obj.Number2);
            Console.WriteLine(obj.Number3);
            Console.WriteLine(obj.Number4);
            Console.WriteLine(obj.Number5);
            Console.WriteLine(obj.Number6);


            Console.ReadKey();


        }
    }
}
