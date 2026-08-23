using System;

class CountDigits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (n != 0)
        {
            n /= 10;
            count++;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}