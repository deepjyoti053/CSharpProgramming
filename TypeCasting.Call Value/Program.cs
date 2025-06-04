namespace TypeCasting.Call_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type objImplicit = new Type();
            objImplicit.Implicit_Type_Cating();

            Type objExplicit = new Type();
            objExplicit.Explicit_Type_Casting();

            Type objBoxing = new Type();
            objBoxing.Boxing_Type_Casting();

            Type objUnboxing = new Type();
            objUnboxing.Unboxing_Type_Casting();

            Type objParsing = new Type();
            objParsing.parsing_Type();

             int y1;
         /* Type objCallbyvalue = new Type();
           objCallbyvalue.Call_by_value(y1);

           Console.WriteLine("y1 value from Program.cs " +y1);

           Type objCallbyrefrence = new Type();
            {
                objCallbyrefrence.Call_by_refrence(ref y1);
                Console.WriteLine(y1);
            } */

            Type objCallbyout = new Type();
            {
                objCallbyout.Call_by_out(out y1);
                Console.WriteLine(y1);
            }




            Console.ReadKey();
        }
    }
}
