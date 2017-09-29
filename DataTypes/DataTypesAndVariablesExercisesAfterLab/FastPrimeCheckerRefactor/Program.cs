using System;

class Program
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        for (int checker = 2; checker <= numberToCheck; checker++)
        {
            bool isPrime = true;
            for (int primeNum = 2; primeNum <= Math.Sqrt(checker); primeNum++)
            {
                if (checker % primeNum == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{checker} -> {isPrime}");
        }

    }
}

