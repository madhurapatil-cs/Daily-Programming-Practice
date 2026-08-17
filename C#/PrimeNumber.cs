using System;
class PrimeNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());

        int count=0;
        for(int i=1;i<=n;i++)
        {
            if(n%i==0)
            {
                count++;
            }
        }

        if(count==2)
        {
            Console.WriteLine("The number is prime.");
        }
        else
        {
            Console.WriteLine("The number is not prime.");
        }

    }
}