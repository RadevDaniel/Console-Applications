using System;

class Program
{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        short b = short.Parse(Console.ReadLine());

        Console.WriteLine("Before:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        short c = a;
        a = b;
        b = c;

        Console.WriteLine("After:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);



    }
}

