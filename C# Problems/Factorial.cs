using System;

namespace Program
{
    public class Factorial
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their factorial number:");
            int number=Convert.ToInt32(Console.ReadLine());
            int result=1;
            
            for(int i=1;i<=number;i++)
            {
                result=result*i;
            }
            Console.WriteLine($"Factorial of {number} is {result}");
        }
    }
}