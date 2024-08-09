using System;

namespace Problem
{
    public class CalSqCub
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their number:");
            int number=Convert.ToInt32(Console.ReadLine());
            
            int square = number * number;
            int cube = number * number * number;
            
            Console.WriteLine($"The Calculate of square value is:{square}");
            Console.WriteLine($"The Calculate of cube value is:{cube}");
        }
    }
}