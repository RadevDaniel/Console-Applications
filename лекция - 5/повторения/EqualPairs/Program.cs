using System;

class Program
{
    static void Main()
    {
        int dvoiki = int.Parse(Console.ReadLine());

        int sum = 0;
        int[] officialSum = new int[dvoiki];

        for (int i = 0; i < dvoiki; i++)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            officialSum[i] = sum;

            if (i == 1)
            {
              
            }
        }
        Console.WriteLine(officialSum.Length);
    }
}

