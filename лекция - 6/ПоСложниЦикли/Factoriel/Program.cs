using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 1;

        while (n != 0)
        {
            sum = sum * n;
            n--;
        }

        Console.WriteLine(sum);
    }
}

