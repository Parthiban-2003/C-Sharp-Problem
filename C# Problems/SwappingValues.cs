using System;

namespace Program
{
    public class SwappingValues
    {
        public static void Main(string[]args)
        {
           Console.WriteLine("Enter their number A:");
           int A=Convert.ToInt32(Console.ReadLine());
            
           Console.WriteLine("Enter their number B:");
           int B=Convert.ToInt32(Console.ReadLine());
           
           Console.WriteLine($"Before their swapping number a value is:{A}");
           Console.WriteLine($"Before their swapping number b value is:{B}");
           
           int swap = A;
           A=B;
           B=swap;
           
           Console.WriteLine($"After their swapping number a value is:{A}");
           Console.WriteLine($"After their swapping number b value is:{B}");
        }
    }
}