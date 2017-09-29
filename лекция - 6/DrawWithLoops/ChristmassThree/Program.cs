using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int spaces = number;
        int stars = 0;

        Console.WriteLine("{0}|{0}", new string(' ', number + 1));
        
            for (int a = 0; a < number; a++)
            {
                spaces--;
                stars++;
                Console.WriteLine("{1}{0} | {0}", new string('*', stars), new string(' ', spaces));
            }
        
    }
}

