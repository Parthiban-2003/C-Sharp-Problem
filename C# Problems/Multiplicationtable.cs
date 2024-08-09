using System;

namespace program
{

public class Multiplicationtable
 {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter their number:");
        int num=Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<=10;i++)
        {
           Console.WriteLine(i + " * " + num +" = "+ num*i);
        }
    }
  }
}