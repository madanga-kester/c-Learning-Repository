/* Write a C# program that:

Declares two integers a = 12 and b = 7.

Prints their sum, difference, product, and quotient.





Q2. If–Else

Write a program that:

Asks the user to input their age.

If the age is 18 or above, print "You are eligible to vote."

Otherwise, print "You are not eligible to vote." */








using System;

namespace MyCalculations
{
    class Calculations
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 12;

            Console.WriteLine("Sum = " + (a + b));
            Console.WriteLine("Difference = " + (a - b));
        }
    }
}







class UserInfo
{
    static void Main(string[] args)
    {

        Console.Write("Enter your Age; ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >=18)
        { Console.WriteLine("You are eligible to Vote"); 
        }
        else
        {
            Console.WriteLine("You are not eligible to vote");
        }

    }
}


/* Maximum of Two Numbers

Write a program that takes two integers x and y from the user and prints
which one is larger, or "Both are equal" if they’re the same. */










namespace TestQuize
{
    class Tests
    {
        static void Main (string[] args)
        {
            Console.Write("Enter first No; ");
            int x= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second NO; ");
            int y = Convert.ToInt32((Console.ReadLine());

            if (x !=y) { Console.WriteLine("is Larger")}

            else
            { Console.WriteLine("Both are Equal")}
        }
    }
}








namespace TestQuiz
{
    class Tests
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + " is larger");
            }
            else if (y > x)
            {
                Console.WriteLine(y + " is larger");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }
        }
    }
}


/* Write a program that asks the user for a number.

If the number is even, print "Even Number".

Otherwise, print "Odd Number". */ 



namespace EvenOdd
{
    class Calculations
    {
        static void Main(string[] args)
        {

            Console.Write(" Enter any Number")
                int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0) { Console.WriteLine("Even Number")}
            else
            { Console.WriteLine("Odd Number")}
        }
    }

}



// sol 





namespace EvenOdd
{
    class Calculations
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
