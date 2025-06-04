using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class MyGenericCollection
    {
        public void List_1()
        {
            List<string> StudentDetails = new List<string>();
            StudentDetails.Add("Abhi");
            StudentDetails.Add("Pradip");
            StudentDetails.Add("DJ");

            Console.WriteLine($"Name\n");
            foreach (string i in StudentDetails)
            {
                Console.WriteLine(i);
            }

            StudentDetails.Remove("Abhi");

            Console.WriteLine();
            foreach (string i in StudentDetails)
            {
                Console.WriteLine(i);
            }

            StudentDetails.Insert(0, "Suraj");
            Console.WriteLine();

            foreach (string i in StudentDetails)
            {
                Console.WriteLine(i);
            }



        }

        /*for 2D Entity class required because I want one column Roll No as int, one column Name as string,
           one column Marks as decimal*/

        public void List_2()
        {
            List<Student> StudentDetail = new List<Student>();

            //Var VariableName // Var = Student, Variable Name =  Obj1, 
            Student Obj1 = new Student { RollNumber = 1, Name = "AAA", Marks = 56.8m };
            Student stud1 = new Student { RollNumber = 2, Name = "BBB", Marks = 78.5m };
            Student stud2 = new Student { RollNumber = 4, Name = "CCC", Marks = 89.5m };


            StudentDetail.Add(Obj1);
            StudentDetail.Add(stud1);
            StudentDetail.Add(stud2);
            //   StudentDetail.AddRange(StudentDetail);

            Console.WriteLine($"Name\t RollNumber\tMarks\n");

            foreach (Student x in StudentDetail)
            {
                Console.WriteLine($"{x.Name}\t {x.RollNumber}\t\t {x.Marks}");
            }
        }

        public void Dictionary()
        {
            Dictionary<int, Student> StudentDetail = new Dictionary<int, Student>();

            Student stud1 = new Student { RollNumber = 2, Name = "DeepJyoti", Marks = 56.4m };
            Student stud2 = new Student { RollNumber = 4, Name = "Pradip", Marks = 78.4m };
            Student stud4 = new Student { RollNumber = 8, Name = "Suraj", Marks = 56.3m };

            StudentDetail.Add(stud1.RollNumber, stud1);
            StudentDetail.Add(stud2.RollNumber, stud2);
            StudentDetail.Add(stud4.RollNumber, stud4);

            Console.WriteLine($"RollNumer\tName\t\tMarks");


            foreach (Student k in StudentDetail.Values)
            {
                Console.WriteLine($"{k.RollNumber}\t\t{k.Name}\t\t{k.Marks}");
                
            }
            Console.WriteLine("==============================================");

            Console.WriteLine("After Remove");

            Console.WriteLine("==============================================");

            StudentDetail.Remove(stud1.RollNumber, out stud1);
            Console.WriteLine($"RollNumer\tName\t\tMarks");

            foreach (Student k in StudentDetail.Values)
            {
                Console.WriteLine($"{k.RollNumber}\t\t{k.Name}\t\t{k.Marks}");
                
            }
        }
    }
}
