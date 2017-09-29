using System;

class Program
{
    static void Main()
    {
        int leftNumber = int.Parse(Console.ReadLine());

        double sumLeft = 0;
        double sumRight = 0;

        for (int i = 0; i < leftNumber; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sumLeft = sumLeft + number;
        }
        for (int i = 0; i < leftNumber; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sumRight = sumRight + number;
        }        

        if (sumLeft == sumRight)
        {
            double rezultat = sumLeft;
            Console.WriteLine("Yes, sum = {0}", rezultat);
        }
        else
        {
            double rezultat = Math.Abs(sumLeft - sumRight);
            Console.WriteLine("No, diff = {0}",rezultat );
        }
    }
}

