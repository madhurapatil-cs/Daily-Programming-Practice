using System;
class SumOfDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n=Convert.ToInt32(Console.ReadLine());

        int sum=0;
        while(n>0)
        {
            int digit=n%10;
            sum=sum+digit;
            n=n/10;

            Console.WriteLine("The sum of digits is: "+sum);
            Console.ReadKey();
        }
    }
    
}