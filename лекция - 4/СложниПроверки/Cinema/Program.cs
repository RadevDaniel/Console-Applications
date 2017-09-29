using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int red = int.Parse(Console.ReadLine());
        int colona = int.Parse(Console.ReadLine());

        int mesta = red * colona;
        double prihod = 0.00;

        if (type == "Premiere")
        {
            Console.WriteLine("{0:F2}", mesta * 12.00);
        }
        else if (type == "Normal")
        {
            Console.WriteLine("{0:F2}", mesta * 7.50);
        }
        else if (type == "Discount")
        {
            Console.WriteLine("{0:F2}", mesta * 5.00);
        }
    }
}

