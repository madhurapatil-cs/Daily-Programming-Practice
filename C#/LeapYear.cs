using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }
}