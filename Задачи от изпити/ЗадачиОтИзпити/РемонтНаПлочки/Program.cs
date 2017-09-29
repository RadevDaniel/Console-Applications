using System;

class Program
{
    static void Main()
    {
        int duljinaNaPloshtadka = int.Parse(Console.ReadLine());
        double shirinaNaPlochka = double.Parse(Console.ReadLine());
        double duljinaNaPlochka = double.Parse(Console.ReadLine());
        double shirinaNaSkameika = double.Parse(Console.ReadLine());
        double duljinaNaSkameika = double.Parse(Console.ReadLine());
                
        double ploshtNaSkameika = shirinaNaSkameika * duljinaNaSkameika;
        double ploshtNaPlochka = shirinaNaPlochka * duljinaNaPlochka;
        double obshtaPlosht = (duljinaNaPloshtadka * duljinaNaPloshtadka) - ploshtNaSkameika;

        double neobhodimiPlochki = obshtaPlosht / ploshtNaPlochka;
        double vreme = neobhodimiPlochki * 0.2;

        Console.WriteLine(neobhodimiPlochki);
        Console.WriteLine(vreme);


    }
}

