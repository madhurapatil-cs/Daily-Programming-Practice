using System;
class PerfectNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number:");
        int n=Convert.ToInt32(Console.ReadLine());
        int sum=0;

        for(int i=1;i<n;i++)
        {
            if(n%i==0)
            {
                sum+=i;
            }
        }

        if(sum==n)
        {
            Console.WriteLine("The Number is Perfect");
        }
        else
        {
            Console.WriteLine("The Number is Not Perfect");
        }

        Console.ReadKey();
    }

}