using System;


namespace Problem
{
    public class Sumofseries
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Number:");
            int Number=Convert.ToInt32(Console.ReadLine());
            
              int values=(Number * (Number+1) / 2);
              
              Console.WriteLine($"Sums of series Number is: {values}");
        }
    }
} 