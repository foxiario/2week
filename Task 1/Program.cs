using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> list = new List<string>();

        try
        {
            Console.WriteLine(list[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.ReadKey();
        }
    }
}