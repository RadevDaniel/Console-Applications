﻿using System;

class Program
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        if (number >= 100 && number <= 200 || number == 0 )
        {

        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

