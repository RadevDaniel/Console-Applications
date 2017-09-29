using System;

class Program
{
    static void Main()
    {
        string city = Console.ReadLine();
        double chislo = double.Parse(Console.ReadLine());
        double price = 0;

        if (city == "Sofia")
        {
            if (chislo >= 0 && chislo <= 500)
            {
                price = 0.5;
                Console.WriteLine("{0:f2}", (price * chislo)/10);
            }
            else if (chislo > 500 && chislo <= 1000)
            {
                price = 0.7;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 1000 && chislo <= 10000)
            {
                price = 0.8;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 10000)
            {
                price = 1.2;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city == "Varna")
        {
            if (chislo >= 0 && chislo <= 500)
            {
                price = 4.5/10;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 500 && chislo <= 1000)
            {
                price = 7.5/10;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 1000 && chislo <= 10000)
            {
                price = 1.0;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 10000)
            {
                price = 1.3;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else if (city == "Plovdiv")
        {
            if (chislo >= 0 && chislo <= 500)
            {
                price = 5.5 / 10;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 500 && chislo <= 1000)
            {
                price = 0.8;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 1000 && chislo <= 10000)
            {
                price = 1.2;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else if (chislo > 10000)
            {
                price = 14.5 / 10;
                Console.WriteLine("{0:f2}", (price * chislo) / 10);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

