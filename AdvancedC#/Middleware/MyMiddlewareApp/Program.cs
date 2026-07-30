using System;

public class Program
{
    public static void Main(string[] args)
    {
        Wrap("2", Second);
        Try("2", Second);
    }
    
    public static void First(string msg)
    {
	    Console.WriteLine("execute first function: "+msg);
    }

    public static void Second(string msg)
    {
        Console.WriteLine("execute second function: "+msg);
    }


    public static void Wrap(string msg, Action<string> function)
    {
        Console.WriteLine("Starting: "+msg);
        function(msg);
        Console.WriteLine("Ends");
    }
    
    public static void Try(string msg, Action<string> function)
    {
        try
        {
            Console.WriteLine("trying: "+msg);
            function(msg);
        }
        catch(Exception ex)
        {
            
        }
    }
}