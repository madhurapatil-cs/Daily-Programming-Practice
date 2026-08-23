using System;

class GCD
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        Console.WriteLine("GCD = " + a);
    }
}