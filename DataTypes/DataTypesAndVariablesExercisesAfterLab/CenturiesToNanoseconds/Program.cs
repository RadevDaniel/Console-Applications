using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        ushort centuries = ushort.Parse(Console.ReadLine());
        ushort years = (ushort)(centuries * 100);
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        ulong minutes = (ulong)(hours * 60);
        ulong seconds = minutes * 60;
        ulong milliSeconds = (seconds * 1000);
        BigInteger microSeconds = milliSeconds * 1000;
        BigInteger nanoSeconds = microSeconds * 1000;

        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries, years, days, hours, minutes, seconds, milliSeconds, microSeconds, nanoSeconds);
    }
}

