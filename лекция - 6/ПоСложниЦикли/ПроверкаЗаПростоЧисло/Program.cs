using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool chislo = true;

        if (n < 2)
        {
            Console.WriteLine("Not prime");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                chislo = false;
                break;
            }
        }

        if (chislo)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not prime");
        }
        
    }
}

