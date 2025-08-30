



/* switch statement in C# is used when you want to compare one variable or expression against multiple possible values.
Instead of writing many if...else if...else, you use switch to make the code cleaner. */





/*
switch (expression)
{
    case value1:
        // code block
        break;

    case value2:
        // code block
        break;

    default:
        // code block (executes if no case matches)
        break;
}




*/







/*

expression → the variable or value you are checking.

case → each possible match.

break → tells the program to exit the switch once a match is found.

default → (optional) runs if no case matches.




*/


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1–7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input! Please enter 1–7.");
                break;
        }
    }
}


// If the user enters 3, output will be Wednesday.
 //If the user enters 9, output will be Invalid input.