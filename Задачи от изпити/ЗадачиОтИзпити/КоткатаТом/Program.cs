using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("въведи почивни дни");
        int pochivniDni = int.Parse(Console.ReadLine());

        int rabotniDni = 365 - pochivniDni;

        int igriviDniPrezPochivkata = pochivniDni * 127;
        int igriviDniPrezRabota = rabotniDni * 63;
        int vremeZaIgra = igriviDniPrezPochivkata + igriviDniPrezRabota;

        if (vremeZaIgra <= 30000)
        {
            int ostavashtoVremeZaIgra = 30000 - vremeZaIgra;
            int chasove = ostavashtoVremeZaIgra / 60;
            int minuti = ostavashtoVremeZaIgra % 60;
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", chasove, minuti);
        }
        else
        {
            int ostavashtoVremeZaIgra = Math.Abs(30000 - vremeZaIgra);
            int chasove = ostavashtoVremeZaIgra / 60;
            int minuti = ostavashtoVremeZaIgra % 60;
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", chasove, minuti);
        }
    }
}

