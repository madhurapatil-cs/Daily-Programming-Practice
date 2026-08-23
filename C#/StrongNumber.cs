using System;

class StrongNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int original = n;
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            int fact = 1;

            for (int i = 1; i <= digit; i++)
            {
                fact *= i;
            }

            sum += fact;
            n /= 10;
        }

        if (sum == original)
            Console.WriteLine(original + " is a Strong Number.");
        else
            Console.WriteLine(original + " is not a Strong Number.");
    }
}