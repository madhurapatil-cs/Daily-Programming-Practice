using System;
class ReverseNumber()
{
    static void Main(string[] args)
    {
        int n, rev=0, digit;
        Console.WriteLine("Enter a number:");
        n=Convert.ToInt32(Console.ReadLine());

        while(n>0)
        {
            digit=n%10;
            rev=rev*10+digit;
            n=n/10;
        }

        Console.WriteLine("Reverse of the number is: " + rev);
    }
}