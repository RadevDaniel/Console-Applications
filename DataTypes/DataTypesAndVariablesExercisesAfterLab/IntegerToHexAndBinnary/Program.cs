using System;

class Program
{
    static void Main()
    {
        int integerNumber = int.Parse(Console.ReadLine());

        string hexValue = integerNumber.ToString("X");
        string binary = Convert.ToString(integerNumber, 2);

        Console.WriteLine(hexValue);
        Console.WriteLine(binary);
    }
}

