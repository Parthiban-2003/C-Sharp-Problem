using System;

namespace Program
{
    public class Greatestnum
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their First number:");
            int num1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Second number:");
            int num2=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Third number:");
            int num3=Convert.ToInt32(Console.ReadLine());
            
            int largest = num1;
            if(num2>largest)
            {
                largest=num2;
            }
            if(num3>largest)
            {
            largest=num3; 
            }
            
            Console.WriteLine($"The largest number is:{largest}");
        }
    }
}