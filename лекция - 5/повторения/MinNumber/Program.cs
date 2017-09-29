using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int minValue = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int chislo = int.Parse(Console.ReadLine());

            if (minValue > chislo)
            {
                minValue = chislo;
            }
        }
        Console.WriteLine(minValue);
    }
}

