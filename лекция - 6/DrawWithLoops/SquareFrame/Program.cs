using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string tire = "- ";
        Console.Write("+ ");
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write(tire);
        }
        Console.WriteLine("+");

        for (int i = 0; i < number - 2; i++)
        {
            Console.Write("| ");
            for (int j = 1; j < number - 2; j++)
            {
                Console.Write(tire);
            }

            Console.Write(tire);
            Console.WriteLine("|");
        }

        Console.Write("+ ");
        for (int i = 0; i < number - 2; i++)
        {
            Console.Write(tire);
        }
        Console.WriteLine("+");
    }
}

