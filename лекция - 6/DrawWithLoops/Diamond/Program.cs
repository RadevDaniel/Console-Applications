using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 1)
        {
            Console.WriteLine("*");

            return;
        }
        if (number == 2)
        {
            Console.WriteLine("**");

            return;
        }

        int midTire = 1;
        int star = 1;

        if (number % 2 == 0)
        {
            star = 2;
            midTire = 2;
        }

        int outTireta = (number - star) / 2;

        Console.WriteLine("{0}{1}{0}", new string('-', outTireta), new string('*', star));
        outTireta--;
        for (int i = 0; i < (number - 1) / 2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outTireta), new string('-', midTire));
            outTireta--;
            midTire += 2;
        }

        outTireta += 2;
        midTire -= 4;



        for (int i = 0; i < (number - 1) / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('-', outTireta), new string('-', midTire));
            outTireta++;
            midTire -= 2;
        }

        outTireta = (number - star) / 2;
        Console.WriteLine("{0}{1}{0}", new string('-', outTireta), new string('*', star));
    }
}

