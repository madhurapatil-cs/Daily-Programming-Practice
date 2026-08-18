using System;
class FibonacciSeries()
{
    static void Main(string[] args)
    {
        int n, firstTerm=0, secondTerm=1, nextTerm;
        Console.WriteLine("Enter the number of terms:");
        n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        for(int i=0; i<n; i++)
        {
            if(i<=1)
                nextTerm=i;
            else
            {
                nextTerm=firstTerm+secondTerm;
                firstTerm=secondTerm;
                secondTerm=nextTerm;
            }
            Console.Write(nextTerm + " ");
        }
    }
}