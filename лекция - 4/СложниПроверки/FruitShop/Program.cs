using System;

class Program
{
    static void Main()
    {
        string product = Console.ReadLine();
        string den = Console.ReadLine();
        double kolichestvo = double.Parse(Console.ReadLine());

        if (den == "Monday" || den == "Tuesday" || den == "Wednesday" || den == "Thursday" || den == "Friday")
        {
            if (product == "banana")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 2.50);
            }
            else if (product == "apple")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 1.20);
            }
            else if (product == "orange")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 0.85);
            }
            else if (product == "grapefruit")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 1.45);
            }
            else if (product == "kiwi")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 2.70);
            }
            else if (product == "pineapple")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 5.50);
            }
            else if (product == "grapes")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 3.85);
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
        else if (den == "Saturday" || den == "Sunday")
        {
            if (product == "banana")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 2.70);
            }
            else if (product == "apple")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 1.25);
            }
            else if (product == "orange")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 0.90);
            }
            else if (product == "grapefruit")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 1.60);
            }
            else if (product == "kiwi")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 3.00);
            }
            else if (product == "pineapple")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 5.60);
            }
            else if (product == "grapes")
            {
                Console.WriteLine("{0:0.00}", kolichestvo * 4.20);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}

