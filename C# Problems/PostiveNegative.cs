using System;

namespace Problems
{
    public class PostiveNegative
    {
        public static void Main(string[]args)
        {
           Console.WriteLine("Enter their number:");
           int num=Convert.ToInt32(Console.ReadLine());
           
           if(num > 0)
           {
               Console.WriteLine($"The {num} value is postive");
           }
           else if(num < 0)
           {
                Console.WriteLine($"The {num} value is nagative");
           }
        else
        {
             Console.WriteLine($"The {num} value is zero");
        }
        }
    }
}