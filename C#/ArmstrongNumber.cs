using System;
class ArmstrongNumber
{
    static void Main(string[] args)
    {
        int num,sum=0,temp,rem;
        Console.WriteLine("Enter a Number:");
        num=Convert.ToInt32(Console.ReadLine());
        temp=num;

        while(num>0)
        {
            rem=num%10;
            sum=sum+rem*rem*rem;
            num=num/10;

        }
        if(sum==temp)
        {
            Console.WriteLine("It is an Armstrong Number");
        }
        else
        {
            Console.WriteLine("It is not an Armstrong Number");
        }
    }
}