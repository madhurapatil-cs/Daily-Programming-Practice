using System;

class LCM
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int x = a;
        int y = b;

        while (y != 0)
        {
            int remainder = x % y;
            x = y;
            y = remainder;
        }

        int gcd = x;
        int lcm = (a * b) / gcd;

        Console.WriteLine("LCM = " + lcm);
    }
}