﻿using System;

class Program
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine().ToLower());

        if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
        {
            Console.WriteLine("digit");
        }
        else if (symbol == 'a'|| symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
       
    }
}

