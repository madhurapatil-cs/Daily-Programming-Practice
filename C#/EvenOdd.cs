using System;
class EvenOdd
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number:");
        int n=Convert.ToInt32(Console.ReadLine());

        if(n%2==0)
        {
            Console.WriteLine("The Number is Even");
        }
        else
        {
            Console.WriteLine("The Number is Odd");
        }

        Console.ReadKey();
    }
}
