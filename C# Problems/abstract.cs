using System;

public class program
{
   public static void Main(string[]args)
   {
       child obj = new child();
       
       parent final =obj;
       
      final.add(5,5);
      final.sub(9,3);
      final.mul(5,5);
      final.div(10,2);
   }

}

public abstract class parent
{
    public void add(int i,int j)
    {
        Console.WriteLine(i+j);
    }
    public void sub(int i, int j)
    {
        Console.WriteLine(i-j);
    }
    
    public abstract void mul(int i,int j);
    public abstract void div(int i,int j);
}

public class child:parent
{
    public override  void mul(int i, int j)
    {
        Console.WriteLine(i*j);
    }
    public override void div(int i, int j)
    {
        Console.WriteLine(i/j);
    }
}
