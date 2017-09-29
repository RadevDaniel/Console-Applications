using System;

class Program
{
    static void Main()
    {
        int broiChisla = int.Parse(Console.ReadLine());

        double sumaNaChetni = 0;
        double minChetni = int.MaxValue;
        double maxChetni = int.MinValue;

        double sumaNaNeChetni = 0;
        double minNeChetni = int.MaxValue;
        double maxNeChetni = int.MinValue;

        for (double i = 1; i <= broiChisla; i++)
        {
            double number = double.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                sumaNaChetni += number;
                if (number < minChetni)
                {
                    minChetni = number;
                }
                if (number > maxChetni)
                {
                    maxChetni = number;
                }
            }

            else
            {
                sumaNaNeChetni += number;
                if (number < minNeChetni)
                {
                    minNeChetni = number;
                }
                if (number > maxNeChetni)
                {
                    maxNeChetni = number;
                }
            }
        }
        Console.WriteLine("OddSum = {0}", sumaNaNeChetni);
        if (minNeChetni == int.MaxValue)
        {
            Console.WriteLine("OddMin No");
        }
        else
        {
            Console.WriteLine("OddMin = {0}", minNeChetni);
        }
        if (maxNeChetni == int.MinValue)
        {
            Console.WriteLine("OddMax No");
        }
        else
        {
            Console.WriteLine("OddMax = {0}", maxNeChetni);
        }
       
        Console.WriteLine("EvenSum = {0}", sumaNaChetni);

        if (minChetni == int.MaxValue)
        {
            Console.WriteLine("EvenMin No");
        }
        else
        {
            Console.WriteLine("EvenMin = {0}", minChetni);
        }
        if (maxChetni == int.MinValue)
        {
            Console.WriteLine("EvenMax No");
        }
        else
        {
            Console.WriteLine("EvenMax = {0}", maxChetni);
        }
    }
}

