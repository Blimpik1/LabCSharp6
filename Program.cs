using System;

public class Program
{
    public delegate void OperationDelegate(int x, int y);
    public static void Add(int x, int y)
    {
        Console.WriteLine("Додавання: " + (x + y));
    }
    public static void Multiply(int x, int y)
    {
        Console.WriteLine("Множення: " + (x * y));
    }

    public static void Main()
    {
        OperationDelegate addDelegate = Add;
        OperationDelegate multiplyDelegate = Multiply;
        OperationDelegate combinedDelegate = addDelegate + multiplyDelegate;

        int a = 5;
        int b = 3;
        combinedDelegate(a, b);
    }
}

