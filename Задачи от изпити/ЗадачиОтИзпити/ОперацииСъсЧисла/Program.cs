using System;

    class Program
{
    static void Main()
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            double rezultat = number1 + number2;
            Console.Write(number1 + " + " + number2 + " = " + rezultat + " - ");
            Console.WriteLine(rezultat % 2 == 0 ? "even" : "odd");
        }
        else if (operation == "-")
        {
            double rezultat = number1 - number2;
            Console.Write(number1 + " - " + number2 + " = " + rezultat + " - ");
            Console.WriteLine(rezultat % 2 == 0 ? "even" : "odd");
        }
        else if (operation == "*")
        {
            double rezultat = number1 * number2;
            Console.Write(number1 + " * " + number2 + " = " + rezultat + " - ");
            Console.WriteLine(rezultat % 2 == 0 ? "even" : "odd");
        }
        else if (operation == "/")
        {
            if (number2 != 0)
            {
                double rezultat = number1 / number2;
                Console.WriteLine(number1 + " / " + number2 + " = " + Math.Round(rezultat, 2));
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", number1);
            }
        }
        else if (operation == "%")
        {
            if (number2 != 0)
            {
                double rezultat = number1 % number2;
                
                Console.WriteLine(number1 + " % " + number2 + " = " + rezultat);
            }
            else
            {
                Console.WriteLine("Cannot divide {0} by zero", number1);
            }
        }
    }
}

