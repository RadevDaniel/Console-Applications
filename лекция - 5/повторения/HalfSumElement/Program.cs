using System;

class Program
{
    static void Main()
    {
        int broiChisla = int.Parse(Console.ReadLine());
        int maxValue = 0;
        int allNumbers = 0;

        for (int i = 0; i < broiChisla; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (maxValue < number)
            {
                maxValue = number;
            }

            allNumbers += number;
        }

       int writeNums = allNumbers - maxValue;

        if (writeNums == maxValue)
        {
            Console.WriteLine("Yes Sum = {0}", maxValue);
        }
        else
        {
            int diff = Math.Abs(writeNums - maxValue);
            Console.WriteLine("No Diff = {0}",diff);
        }
    }
}

