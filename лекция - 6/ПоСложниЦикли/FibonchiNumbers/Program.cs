using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstNum = 1;
        int secondNum = 1;

        for (int i = 0; i < n - 1; i++)
        {
            int sum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = sum;
        }
        Console.WriteLine(secondNum);
    }
}

