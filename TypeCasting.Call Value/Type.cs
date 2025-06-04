using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting.Call_Value
{
    class Type
    {
        int x = 10;               
        decimal x1 = 30.99m;
        string y = "20";
        public void Implicit_Type_Cating()
        {
            x1 = x;
            Console.WriteLine("After Implicit Type Casting Value of x1 is: " + x1);
        }

        public void Explicit_Type_Casting()
        {
           // x = (int)x1;
            x = Convert.ToInt32(x1);
            Console.WriteLine("After Explicit_Type_Casting Value of x is: " + x);
        }
        public void Boxing_Type_Casting() //Convert int to string/ Convert value Type to Refrence Type
        {
            y = Convert.ToString(x);
            Console.WriteLine("After Boxing Type Casting Value of y is : " + y);
        }

        public void Unboxing_Type_Casting() // Convert refrence type to value type
        {
            x = Convert.ToInt32(y);
            Console.WriteLine("After Unboxing Type Casting Value of x is : " + x);
        }

        public void parsing_Type() // Convert String type to any other type
        {
            x1 = Convert.ToDecimal(y);
        }

        // Call by Value // Can't Modified

        public void Call_by_value(int y1)
        {
            y1 = y1 + 20;
          // Console.WriteLine("y1 from method - Call_by_value " + y1);
        }

        // Call by reference // Can be modify

        /*  public void Call_by_refrence(ref int y1)
          {
              y1 = y1 + 20;
          }*/




        // Call by Out

        public void Call_by_out(out int y1)
        {
            y1 = 100;
            y1 = y1 + 20;
        }

    }
}
