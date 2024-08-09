using System;

namespace Problem
{

public class Sumofnumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter their values:");
        int values=Convert.ToInt32(Console.ReadLine());
        
       int sum=0;
        
       while(values>0)
       {
         int rem=values%10;
         values=values/10;
          sum=sum+rem;
       }
       Console.WriteLine(sum);
    }
  }
}