using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int stars = 1;
        int tireta = (number - stars) / 2;

        if (number % 2 == 0)
        {
            stars = 2;
        }

        for (int i = 0; i < (number + 1) / 2; i++)
        {

            Console.WriteLine("{0}{1}{0}", new string('-', tireta), new string('*', stars));
            stars += 2;
            tireta--;
        }


        for (int i = 0; i < number / 2; i++)
        {
            Console.WriteLine("|{0}|", new string('*', number - 2));
        }
    }
}

