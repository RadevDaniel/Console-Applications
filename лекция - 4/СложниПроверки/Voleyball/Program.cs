using System;

class Program
{
    static void Main()
    {
        string godina = Console.ReadLine();
        int praznici = int.Parse(Console.ReadLine());
        int vSelo = int.Parse(Console.ReadLine());
        int weekends = 48;
        int weekendsInSofia = weekends - vSelo;
        double broiIgriVuvSofiq = weekendsInSofia * (3.0 / 4);
        double broiIgriVuvPraznici = praznici * (2.0 / 3);

        double vremeZaIgra = broiIgriVuvSofiq + broiIgriVuvPraznici + vSelo;

        if (godina == "leap")
        {
            vremeZaIgra = vremeZaIgra + (vremeZaIgra * 1.5) / 10;
            Console.WriteLine(Math.Truncate(vremeZaIgra));
        }
        else if (godina == "normal")
        {
            Console.WriteLine(Math.Truncate(vremeZaIgra));
        }
    }
}

