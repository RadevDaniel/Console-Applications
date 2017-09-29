using System;

class Program
{
    static void Main()
    {
        int distance = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        double allMinutes = (hours * 60) + minutes + (seconds / 60);
        double allSeconds = allMinutes * 60;
        double allHours = hours + 

        double metersPerSeconds = distance / allSeconds;
        double kilometersPerHour = (distance / 1000) / hours;
        double milesPerHour = (distance * 0.000621371192) / hours;

        Console.WriteLine(metersPerSeconds);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}

