using System;

class Program
{
    static void Main()
    {
        int sumator = 0;
        for (int i = 0; i < 1000; i++)
        {
            
            if (i % 10 == 7)
            {
                sumator++;
                Console.WriteLine(i);
            }
            
        }
        Console.WriteLine("huqmi - {0}",sumator);
    }
}

