using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string symbol = "* ";

        for (int i = 0; i < number; i++)
        {
            for (int j = 1; j <= number; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            
        }
        
    }
}

