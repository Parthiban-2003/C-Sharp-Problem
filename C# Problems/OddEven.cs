using System;


namespace Problem
{
    public class OddEven
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Number:");
            int Number=Convert.ToInt32(Console.ReadLine());
            
            if(Number%2 == 0)
            {
                Console.WriteLine("The given number is Even");
            }
            else
            {
                Console.WriteLine("The given number is add");
            }
        }
    }
}

