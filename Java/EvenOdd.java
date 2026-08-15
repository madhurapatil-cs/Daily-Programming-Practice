import java.util.*;
public class EvenOdd

{
    public static void main(String args[])
    {
        System.out.println("To check whether a number is even or odd");

        Scanner sc=new Scanner(System.in);
        System.out.println("Enter a number:");
        int n=sc.nextInt();

        if(n%2==0)
        {
            System.out.println(n+" is an even number");
        }
        else
        {
            System.out.println(n+" is an odd number");
        }
    }


    
}