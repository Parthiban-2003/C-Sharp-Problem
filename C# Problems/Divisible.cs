using System;

namespace Problem
{

public class Divisible
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter their values:");
        int value=Convert.ToInt32(Console.ReadLine());
        
        if(value % 5 == 0)
        {
            Console.WriteLine($"The {value} is divied by 5");
        }
        else
        {
            Console.WriteLine($"The {value} is not divide by 5");
        }
    }
  }
}