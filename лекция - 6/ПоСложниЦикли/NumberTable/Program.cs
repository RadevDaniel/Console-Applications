using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        for (int i = 1; i <= n; i++)
        {
            int plus = i;
            int minus = n;
            for (int j = 1; j <= n; j++)
            {
                if (plus < n)
                {
                    Console.Write(plus + " ");
                    plus++;
                }
                else
                {
                    Console.Write(minus + " ");
                    minus--;
                }

            }

            Console.WriteLine();
        }
    }
}

