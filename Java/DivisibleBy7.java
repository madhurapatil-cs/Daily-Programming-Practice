public class DivisibleBy7
{
    public static void main(String args[])
    {
        
        System.out.println("Numbers divisible by 7 between 1 to 50 are:");

        for(int i=1;i<=50;i++)
        {
            if(i%7==0)
            {
                System.out.println(i);
            }
        }
    }
}