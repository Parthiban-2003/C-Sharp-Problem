using System;

namespace hello
{
    public class vowleConstant
    {
        public static void Main(string[]args)
        {
          Console.WriteLine("Enter their letters:");
          string letter=Console.ReadLine();
          
          if(letter=="a" || letter=="e" || letter=="i" || letter=="o" || letter=="u")
         {
             Console.WriteLine($"{letter} is a Vowle.");
         }

         else
         {
             Console.WriteLine($"{letter} is a Constant.");
         }

        }
    }
}