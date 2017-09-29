using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Въведи число");
        int sumi = int.Parse(Console.ReadLine());

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 0; i < sumi; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes Sum = {0}", evenSum);
        }
        else
        {
            int rezultat = Math.Abs(evenSum - oddSum);
            Console.WriteLine("No Diff = {0}", rezultat);
        }
    }
}

