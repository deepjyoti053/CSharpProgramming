using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    class String_Class
    {
        public void f()
        {
            string name = string.Empty;
            StringBuilder names = new StringBuilder();
            Console.WriteLine("Enter the 3 names");
            for (int i = 0; i < 3; i++)
            {
                name = Console.ReadLine();
                names.Append(" ");
                names.Append(name);
            }
            Console.WriteLine(names.ToString());
        }

        public void f1()
        {
            string s = "This is a book";
            string w = "pen";

            if (s.Contains(w))
            {
                Console.WriteLine(w +" "+ "is belongs to s.");
            }

            else 
             {
                Console.WriteLine(w + " "+"is not belongs to s.");
             }
        }

        public void f2()
        {
            string s = "book ";
            string w = "Book";

            if (s.Trim().ToLower().Equals(w.Trim().ToLower()))
            {
                Console.WriteLine("s is equals to w");
            }

            else 
            {
                Console.WriteLine("s is not equals to w");
            }

        }

        



    }
}
