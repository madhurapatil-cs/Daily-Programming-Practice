using System;

class StudentInfo
{
    static void Main(string[] args)
    {
        string fname, lname, clgname;
        int age, rollno;

        Console.WriteLine("Enter Your First Name:");
        fname = Console.ReadLine();

        Console.WriteLine("Enter Your Last Name:");
        lname = Console.ReadLine();

        Console.WriteLine("Enter Your Age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Your College Name:");
        clgname = Console.ReadLine();

        Console.WriteLine("Enter Your Roll Number:");
        rollno = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello Miss " + fname + " " + lname);
        Console.WriteLine("Your Age is: " + age);
        Console.WriteLine("Your College Name is: " + clgname);
        Console.WriteLine("Your Roll Number is: " + rollno);

        Console.ReadKey();
    }
}