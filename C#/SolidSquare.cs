using System;
class SolidSquare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of rows:");
        int n=Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<n;i++)
        {
            for(int j=1;j<n;j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}