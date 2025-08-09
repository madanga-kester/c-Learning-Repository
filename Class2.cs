using System;

public class Class1
{
	public Class1()
	{
	}
}




//getting user inputs
// use console.readline()- returns a string only


console.writeline("Enter username");

string username = console.ReadLine();

console.writeline("Usename is:" + username);









using system;

namespace gettinguserinputs

{
	class program
	{
		console.writeline("Enter your age");
			int age = Convert.ToInt32(Console.Readline());
		Console.writeline("Your age is ;" + age);
	}
}










using System;

namespace UserInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRING input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            // INT input
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old.");

            // DOUBLE input
            Console.Write("Enter your GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your GPA is " + gpa);

            // BOOL input
            Console.Write("Are you a student? (true/false): ");
            bool isStudent = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Student status: " + isStudent);
        }
    }
}





//operators- perform operations on variables and values.

int x = 20 + 30;
console.writeline(x);


//include 

// + addition
// - subtraction
// * multilication
//  / division
// % modulus 
// ++ increement
// -- decrement






using System;
 
namespace Operator
{
    class ArithmeticOperator
    {
        public static void Main(string[] args)
        {
            double firstNumber = 14.40, secondNumber = 4.60, result;
            int num1 = 26, num2 = 4, rem;

            // Addition operator
            result = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

            // Subtraction operator
            result = firstNumber - secondNumber;
            Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);

            // Multiplication operator
            result = firstNumber * secondNumber;
            Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);

            // Division operator
            result = firstNumber / secondNumber;
            Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);

            // Modulo operator
            rem = num1 % num2;
            Console.WriteLine("{0} % {1} = {2}", num1, num2, rem);
        }
    }
}



// output 


14.4 + 4.6 = 19
14.4 - 4.6 = 9.8
14.4 * 4.6 = 66.24
14.4 / 4.6 = 3.1304347826087
26 % 4 = 2


    //relational operators



// Relational operators are used to check the relationship between two operands. If the relationship is true the result will be true, otherwise it will result in false.

Relational operators are used in decision making and loops.

C# Relational Operators
Operator	Operator Name	Example
==	Equal to	6 == 4 evaluates to false
>	Greater than	3 > -1 evaluates to true
<	Less than	5 < 3 evaluates to false
>=	Greater than or equal to	4 >= 4 evaluates to true
<=	Less than or equal to	5 <= 3 evaluates to false
!=	Not equal to	10 != 2 evaluates to true




using System;
 
namespace Operator
{
    class RelationalOperator
    {
        public static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            result = (firstNumber == secondNumber);
            Console.WriteLine("{0} == {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber > secondNumber);
            Console.WriteLine("{0} > {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber < secondNumber);
            Console.WriteLine("{0} < {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber >= secondNumber);
            Console.WriteLine("{0} >= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber <= secondNumber);
            Console.WriteLine("{0} <= {1} returns {2}", firstNumber, secondNumber, result);

            result = (firstNumber != secondNumber);
            Console.WriteLine("{0} != {1} returns {2}", firstNumber, secondNumber, result);
        }
    }
}





//output


10 == 20 returns False
10 > 20 returns False
10 < 20 returns True
10 >= 20 returns False
10 <= 20 returns True
10 != 20 returns True







    // Logical Operators
Logical operators are used to perform logical operation such as and, or. Logical operators operates on boolean expressions (true and false) and returns boolean values. Logical operators are used in decision making and loops.


C# Logical operators
Operand 1	Operand 2	OR (||)	AND (&&)
true	true	true	true
true	false	true	false
false	true	true	false
false	false	false	false
// In simple words, the table can be summarized as:

If one of the operand is true, the OR operator will evaluate it to true.
If one of the operand is false, the AND operator will evaluate it to false.







using System;
 
namespace Operator
{
    class LogicalOperator
    {
        public static void Main(string[] args)
        {
            bool result;
            int firstNumber = 10, secondNumber = 20;

            // OR operator
            result = (firstNumber == secondNumber) || (firstNumber > 5);
            Console.WriteLine(result);

            // AND operator
            result = (firstNumber == secondNumber) && (firstNumber > 5);
            Console.WriteLine(result);
        }
    }
}


// on my free time ,cover- unaary operators
//        post and pre increment operators
//        ternary operators
//        bitwise and bitshift operators
//        compound assignment operators
//  




//math

// The Math.Max(x, y) method can be used to find the highest value of x and y:



Math.Max(x, y)



    static void Main(string[] args)
{
    Console.WriteLine(Math.Max(5, 10));
}
  }







Math.Min(x, y) // used to find the lowest value of of x and y










Math.Sqrt(x)  // returns the square root of x




using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(64));
        }
    }
}









Math.Abs(x)   //  returns the absolute (positive) value of x

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-4.7));
        }
    }
}








Math.Round() // rounds a number to the nearest whole number












// String Length
//  A string in C# is actually an object, which contain properties and methods that can perform certain operations on strings. For example, the length of a string can be found with the Length property:

// Example
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);

//  Other Methods


//  for example ToUpper() and ToLower(), which returns a copy of the string converted to uppercase or lowercase:

// Example
string txt = "Hello World";
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"




//string interpolation 
// $ "..." syntax



//string acess

string myString = "Hello";
Console.WriteLine(myString[0]);  // Outputs "H"


string myString = "Hello";
Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"


