using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int chislo = int.Parse(Console.ReadLine());
            sum = sum + chislo;
        }
        Console.WriteLine(sum);
    }
}

