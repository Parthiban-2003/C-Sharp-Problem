using System;

public class Program
{
    public static void Main(string[]args)
    {
        Implementationclass1 obj1=new Implementationclass1();
        Implementationclass2 obj2=new Implementationclass2();
        
        obj1.add(5,6);
        obj2.sub(9,2);
    }
}

interface ITestinterface1
{
    void add(int i,int j);
}
interface ITestinterface2
{
    void sub(int i, int j);
} 

public class Implementationclass1 : ITestinterface1
{
    public void add(int i, int j)
    {
        Console.WriteLine(i+j);
    }
} 
    public class Implementationclass2:ITestinterface2
    {
        public void sub(int i, int j)
        {
            Console.WriteLine(i-j);
        }
    }
