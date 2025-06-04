namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            cars[0] = "ope1";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars.Length);
            Console.ReadKey();

           string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
           /* for (int i = 0; i<cars.Length; i++)
            {}
                Console.WriteLine(cars[i]);
            }*/
            /*Array.Sort(cars); 
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();*/

            /*string[] Name = { "Deep Jyoti", "Pradip", "Suraj", "Aman", "Vishal", "Vivek", "Anu", "Saman", "Shilpi"};
            Array.Sort(Name);
            foreach (string n in Name)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();*/

            int[] MyNum = {12, 6, 5, 1, 0, 56, 14, 17, 3, 4, 10, 9, 6, 7};
           // Array.Sort(MyNum);
           // foreach (int i in MyNum)
            {
                //Console.WriteLine(i);
                Console.WriteLine(MyNum.Max());
                Console.WriteLine(MyNum.Min());
                Console.WriteLine(MyNum.Sum());
            }

            Console.ReadKey();



        }
    }
}
