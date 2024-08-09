using System;

namespace Program
{
    public class Gradecalculations
    {
        public static void Main(string[]args)
        {
          Console.WriteLine("Enter their student name:");
          string name=Console.ReadLine();
          
          Console.WriteLine("Enter your sub1 mark:");
          int mark1=Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter your sub2 mark:");
          int mark2=Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter your sub3 mark:");
          int mark3=Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter your sub4 mark:");
          int mark4=Convert.ToInt32(Console.ReadLine());
          
          Console.WriteLine("Enter your sub5 mark:");
          int mark5=Convert.ToInt32(Console.ReadLine());
          
          int calculate=mark1+mark2+mark3+mark4+mark5;
          Console.WriteLine(calculate);
          
          if(calculate<500 && calculate>400)
          {
              Console.WriteLine("Grade '0'");
          }
          else if(calculate<400 && calculate>300)
          {
              Console.WriteLine("Grade 'A'");
          }
          else if(calculate<300 && calculate>200)
          {
               Console.WriteLine("Grade 'B'");
          }
          else
          {
               Console.WriteLine("Grade 'C'");
          }
        }
    }
}
