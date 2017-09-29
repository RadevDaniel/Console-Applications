using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int kushtichki = n / 2;

        if (n == 3)
        {
            Console.WriteLine("/{0}\\/{0}\\", new string('^', kushtichki));

            return;
        }

        if (n == 4)
        {
            Console.WriteLine("/{0}\\/{0}\\", new string('^', kushtichki));

            return;
        }

        Console.WriteLine("/{0}\\{1}/{0}\\",new string('^', kushtichki), new string('_',kushtichki));
    }
}

