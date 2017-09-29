using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxValue = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int chislo = int.Parse(Console.ReadLine());
           
            if (maxValue < chislo)
            {
                maxValue = chislo;
            }
        }
        Console.WriteLine(maxValue);
    }
}

