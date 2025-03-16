using System;


public class HaloGeneric
{
    public static void sapaUser<T>(T param)
    {
        Console.WriteLine($"\nHalo user {param}");
    }
}


public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah {data}");
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        string NIM = Console.ReadLine();
        DataGeneric<string> obj = new DataGeneric<string>(NIM);
        obj.PrintData();
    }
}

