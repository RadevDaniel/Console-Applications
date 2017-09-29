using System;

class Program
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        if (budget <= 100)
        {
            if (season == "summer")
            {
                decimal sredstva = budget * 0.3m;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Camp - {0:0.00}", sredstva);
            }
            else if (season == "winter")
            {
                decimal sredstva = budget * 0.7m;
                Console.WriteLine("Somewhere in Bulgaria");
                Console.WriteLine("Hotel - {0:0.00}", sredstva);
            }
        }
        else if (budget <= 1000)
        {
            if (season == "summer")
            {
                decimal sredstva = budget * 0.4m;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Camp - {0:0.00}", sredstva);
            }
            else if (season == "winter")
            {
                decimal sredstva = budget * 0.8m;
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine("Hotel - {0:0.00}", sredstva);
            }
        }
        else
        {
            decimal sredstva = budget * 0.9m;
            Console.WriteLine("Somewhere in Europe");
            Console.WriteLine("Hotel - {0:0.00}", sredstva);
        }
    }
}

