using System;

class Program
{
    static void Main()
    {
        string produkt = Console.ReadLine();
        string grad = Console.ReadLine();
        double cena = double.Parse(Console.ReadLine());

        if (grad == "Sofia")
        {
            if (produkt == "coffee")
            {
                Console.WriteLine(0.50 * cena);
            }
            else if (produkt == "water")
            {
                Console.WriteLine(0.80 * cena);
            }
            else if (produkt == "beer")
            {
                Console.WriteLine(1.20 * cena);
            }
            else if (produkt == "sweets")
            {
                Console.WriteLine(1.45 * cena);
            }
            else if (produkt == "peanuts")
            {
                Console.WriteLine(1.60 * cena);
            }
        }
        else if (grad == "Plovdiv")
        {
            if (produkt == "coffee")
            {
                Console.WriteLine(0.40 * cena);
            }
            else if (produkt == "water")
            {
                Console.WriteLine(0.70 * cena);
            }
            else if (produkt == "beer")
            {
                Console.WriteLine(1.15 * cena);
            }
            else if (produkt == "sweets")
            {
                Console.WriteLine(1.30 * cena);
            }
            else if (produkt == "peanuts")
            {
                Console.WriteLine(1.50 * cena);
            }
        }
        else if (grad == "Varna")
        {
            if (produkt == "coffee")
            {
                Console.WriteLine(0.45 * cena);
            }
            else if (produkt == "water")
            {
                Console.WriteLine(0.70 * cena);
            }
            else if (produkt == "beer")
            {
                Console.WriteLine(1.10 * cena);
            }
            else if (produkt == "sweets")
            {
                Console.WriteLine(1.35 * cena);
            }
            else if (produkt == "peanuts")
            {
                Console.WriteLine(1.55 * cena);
            }
        }

    }
}

