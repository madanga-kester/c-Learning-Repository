



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
using System.CodeDom;
using System.Threading.Tasks;

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




using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1–7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        string dayName = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid input! Please enter 1–7."
        };

        Console.WriteLine(dayName);
    }
}









using System;

class Program
{
    static void Main()
    {
        string grade = "A";

        string message = grade switch
        {
            "A" or "a" => "Excellent!",
            "B" or "b" => "Good job!",
            "C" or "c" => "Fair effort.",
            _ => "Needs improvement."
        };

        Console.WriteLine(message);
    }
}










/*Write a switch expression for this real-world scenario:

 A simple restaurant ordering system.

If user enters 1 → "Burger"

If user enters 2 → "Pizza"

If user enters 3 → "Pasta"

Anything else → "Invalid choice"*/


using System;

namespace Restaurant
{
    class Orders
    {
        static void main();

        Console.Write("Enter any order:");
            int x = Convert.ToInt32(Console.ReadLine());

        string Order = x switch

        {
            "1" => "Burger"
            "2" => "Pizza"
            "3" => "Pasta"
            - => "Invalid chice"

         Console.writeline(order)


        }


    }
}










// sol



using System;

namespace Restaurant
{
    class Orders
    {
        static void Main()
        {
            Console.Write("Enter your order (1=Burger, 2=Pizza, 3=Pasta): ");
            int x = Convert.ToInt32(Console.ReadLine());

            string order = x switch
            {
                1 => "Burger",
                2 => "Pizza",
                3 => "Pasta",
                _ => "Invalid choice"
            };

            Console.WriteLine(order);
        }
    }
}






// test 2


/* Write a C# program using a switch expression that works as a simple calculator.

The program should:

Ask the user for two numbers.

Ask the user for an operator (+, -, *, /).

Use a switch expression to calculate and display the result.

If the operator is invalid, display "Invalid operator".

*/




using System;

namespace Calculation

{
    class Calculate
    {
        static void Main(string[] args)
        
        Console.Write(" Enter first number:");
            int x = Convert.ToInt32(Console.readline);

        Console.Write( "Enter second number:");
            int y= Convert.ToInt32(Console.readline);



        Console.Write(" Enter any operator ( 1= +,  2= -, 3= *, 4= / ):");
            int Operator = Convert.ToInt32(Console.readline);

        string Number = Operator switch

        {


            "1" => " x + y ",
            "2" => " x - y ",
            "3" => " x  * y ",
            "4" => " x / y ",
            _ ==> " Ivalid Operator"


            Console.WriteLine(number);



        }


    }

}



// soll



using System;

namespace Calculation
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            double result = op switch
            {
                "+" => x + y,
                "-" => x - y,
                "*" => x * y,
                "/" => y != 0 ? x / y : double.NaN, // avoid divide by zero
                _ => double.NaN // default case
            };

            if (double.IsNaN(result))
                Console.WriteLine("Invalid operator or division by zero.");
            else
                Console.WriteLine($"Result: {result}");
        }
    }
}
