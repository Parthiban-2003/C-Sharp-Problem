using System;

namespace Problems
{
    public class Drive
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Age:");
            int age=Convert.ToInt32(Console.ReadLine());
            
            if(age<18)
            {
                Console.WriteLine("Not Eligible to drive");
            }
            else if(age<70)
            {
                Console.WriteLine(" Eligible to drive");
            }
            else
            {
                Console.Write("Take to rest");
            }
        }
    }
}