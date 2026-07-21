using System;

public class Program
{
    public static void Main(string[] args)
    {
        Wrap(First());
        Wrap(Second());
    }
    
    public void First()
    {
	    Console.WriteLine("execute first function");
    }

    public void Second()
    {
        Console.WriteLine("execute second function");
    }

    public delegate void ToWrap();

    public void Wrap(ToWrap function)
    {
        Console.WriteLine("Starts");
    }
    
}