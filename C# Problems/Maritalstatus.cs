using System;

namespace Problem
{

public class Maritalstatus
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter their gender:");
        string maritalstatus=Console.ReadLine();
        
        Console.WriteLine("Enter their age:");
        int age=Convert.ToInt32(Console.ReadLine());
        
        if(maritalstatus =="male")
        {
            if(age>21)
            {
                Console.WriteLine("He is eligible for married.");
            }
            else
            {
                Console.WriteLine("He does not eligible for married.");
            }
        }

        else if(maritalstatus == "female")
        {
            if(age>18)
            {
                Console.WriteLine("she is eligible for married.");
            }
            else
            {
                Console.WriteLine("she does not eligible for married.");
            }
        }

        else
        {
            Console.WriteLine("Invalid input.");
         }
       
    }
  }
}