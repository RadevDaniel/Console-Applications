using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int br = 0;
        int tekushtaStoinost = 0;

        for (int i = 0; i <= n; i++)
        {
            
            for (int j = 0; j <= i; j++)
            {
                tekushtaStoinost++;
                Console.Write("{0} ",tekushtaStoinost);
                if (tekushtaStoinost == n)
                {
                    return;
                }
            }

            Console.WriteLine();
            
        }
    }
}

