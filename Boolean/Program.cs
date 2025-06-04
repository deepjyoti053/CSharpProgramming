namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int x = 10;
             int y = 20;
             Console.WriteLine(x>y);
             Console.WriteLine(x<y);
             bool IsCSharpInterestinhg = true;
             bool IsFishCurryTesty = false;
             Console.WriteLine(IsCSharpInterestinhg);
             Console.WriteLine(IsFishCurryTesty);
             Console.WriteLine(x==y);*/

            /* int Voting_age = 18;
             int My_age = 31;
             if (My_age  >= Voting_age)
             {
                 Console.WriteLine("I am eligible for Voting right");
             }
             else {
                 Console.WriteLine("I am not eligible for Voting right");
             } */

            string A = "Apple";
            string B = "Ball";

            Console.WriteLine("Choose character A and B");
            string  enteredChar=Console.ReadLine();
            
            if (enteredChar?.ToLower()=="a") 
            {
                Console.WriteLine(A);
            }
            else if (enteredChar?.ToLower()=="b")
            {
                Console.WriteLine(B);
            }
            else 
            {
                    Console.WriteLine("Invalid character");
            }

                    Console.ReadKey();
                    

        }
    }
}
