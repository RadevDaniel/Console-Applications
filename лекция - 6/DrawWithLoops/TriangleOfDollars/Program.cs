using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string dollar = "$ ";

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(dollar);
            }
            Console.WriteLine(dollar);
            
        }
    }
}

