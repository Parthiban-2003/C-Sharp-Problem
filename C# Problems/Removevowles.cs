using System;

namespace Program
{
    public class Removevowles
    {
        static string deleted(string str)
        {
            string vowles="AEIOUaeiou";
            string result="";
            
            foreach(char voels in str)
            {
              if(!vowles.Contains(voels))
                {
                result=result+voels;
                }
          }
          return result;
        }
        
        public static void Main(string[]args)
        {
            Console.WriteLine("Enter their string:");
            string Text=Console.ReadLine();
            
            string input=deleted(Text);
            Console.WriteLine(input);
        }
    }
}