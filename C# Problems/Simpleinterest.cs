using System;

namespace Program
{
    public class Simpleinterest
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Principal:");
            int principal=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Rate Of interest:");
            int rateofprincipal=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Time Period:");
            int timeperiod=Convert.ToInt32(Console.ReadLine());
            
            int SimpleInterest=(principal * rateofprincipal * timeperiod) / 100;
            
            Console.WriteLine($"The simple interest on 100 at a rate of 20% across 2 time periods is {SimpleInterest}");
        }
    }
}