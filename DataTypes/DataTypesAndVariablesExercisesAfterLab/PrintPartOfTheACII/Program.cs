using System;

class Program
{
    static void Main()
    {
        byte aciiStart = byte.Parse(Console.ReadLine());
        byte asciiStop = byte.Parse(Console.ReadLine());

        for (int i = aciiStart; i <= asciiStop; i++)
        {
            Console.Write("{0} ",(char)i);
        }
    }
}

