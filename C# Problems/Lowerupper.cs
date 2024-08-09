using System;

namespace program
{
    public class Lowerupper
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Test:");
            string Test=Console.ReadLine();
            
            String Upper=Test.ToUpper();
            Console.WriteLine(Upper);
            
        }
    }
}