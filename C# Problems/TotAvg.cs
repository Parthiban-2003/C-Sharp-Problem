using System;

namespace Problems
{
    public class TotAvg
    {
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their Stundent roll number:");
            int roll=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Stundent subject1 mark:");
            int sub1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Stundent subject2 mark:");
            int sub2=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter their Stundent subject3 mark:");
            int sub3=Convert.ToInt32(Console.ReadLine());
            
            int Tot=sub1+sub2+sub3;
            int Avg=(sub1+sub2+sub3)/3;
            
            Console.WriteLine($"The student total mark is:{Tot}");
              Console.WriteLine($"The student Average is:{Avg}");
            
            
            
        }
    }
}