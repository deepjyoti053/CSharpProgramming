using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    class Collections
    {
        public void collection_1()
        {
           ArrayList Studentdetail = [103, "Deep Jyoti", 98.7];

            Console.WriteLine("Detail of Student : ");

            foreach (object x in Studentdetail)
            {

                Console.WriteLine(x);
            }

            Studentdetail.Remove("Deep Jyoti");
            Console.WriteLine();


            Console.WriteLine("After Remove : ");


            foreach (object x in Studentdetail)
            {

                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("After Insert : ");


            Studentdetail.Insert(1,"Pradip");
            
            foreach (object x in Studentdetail)
            {
                Console.WriteLine(x);
            }
        }

        public void collection_2()
        {
            Hashtable hsName = new Hashtable();
            hsName.Add(102, "Amit");
            hsName.Add(104,"Sumit");
            hsName.Add(78,"Sunil");
           
            Console.WriteLine("Student Detail : ");

            foreach (object x in hsName)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();


            Console.WriteLine("After Remove");

            hsName.Remove(102);

            foreach (object x in hsName)
            {
                Console.WriteLine(x);
            }



        }

    }
}
