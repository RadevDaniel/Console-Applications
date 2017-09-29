using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string space = " ";
        string star = "* ";

        for (int i = 1; i <= number; i++)
        {

            for (int j = 1; j <= number - i; j++)
            {
                Console.Write(space);
            }

            Console.Write(star);

            for (int v = 1; v < i; v++)
            {
                Console.Write(star);
            }

            Console.WriteLine();
        }

        for (int i = 1; i <= number; i++)
        {

            for (int j = 0; j < i; j++)
            {
                Console.Write(space);
            }

            for (int v = 0; v < number - i; v++)
            {
                Console.Write(star);
            }

            Console.WriteLine();
        }
    }
}