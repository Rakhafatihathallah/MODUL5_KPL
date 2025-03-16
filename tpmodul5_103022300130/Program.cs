using System;





public class HaloGeneric
{
    public static void sapaUser<T>(T param)
    {
        Console.WriteLine($"\nHalo user {param}");
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        HaloGeneric.sapaUser(input);
    }
}

