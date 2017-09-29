using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('*', number * 2), new string(' ', number));

        for (int i = 0; i < number - 2; i++)
        {
            if (i == (number-1) / 2 - 1)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', (number * 2) - 2), new string('|', number));
            }
            else
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', (number * 2) - 2), new string(' ', number));
            }

        }

        Console.WriteLine("{0}{1}{0}", new string('*', number * 2), new string(' ', number));
    }
}

