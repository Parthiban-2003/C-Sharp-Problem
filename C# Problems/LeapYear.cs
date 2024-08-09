using System;

namespace Program
{
    public class LeapYear
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their number:");
            int Number=Convert.ToInt32(Console.ReadLine());
            
            if(Number%400==0 || Number%100!=0 && Number%4==0)
            {
                Console.WriteLine($"The {Number} year is a leap Year.");
            }
            else
            {
                Console.WriteLine("This {Number} year is not a leap year.");
            }
        }
    }
}