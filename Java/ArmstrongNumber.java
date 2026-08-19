import java.util.*;
public class ArmstrongNumber
{
    public static void main(String argd[])
    {
        Scanner sc=new Scanner(System.in);
        System.out.println("Enter a number");
        int num=sc.nextInt();
        int sum=0;
        int temp=num;
        int digit;

        while(temp>0)
        {
            digit=temp%10;
            sum=sum+(digit*digit*digit);
            temp=temp/10;
        }
        if(sum==num)
        {
            System.out.println(num+" is an Armstrong number");
        }
        else
        {
            System.out.println(num+" is not an Armstrong number");
        }
    }
}