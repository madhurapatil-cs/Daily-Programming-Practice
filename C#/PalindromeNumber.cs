using System;
class PalindromeNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int num=Convert.ToInt32(Console.ReadLine());

        int temp=num;
        int rev=0;

        while(num>0)
        {
            int rem=num%10;
            rev=rev*10+rem;
            num=num/10;
        }
        if(temp==rev)
        {
            Console.WriteLine("The number is a palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not a palindrome.");
        }
        Console.ReadKey();
    }
}