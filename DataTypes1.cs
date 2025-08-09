using System;

public class Class1
{
	public Class1()
	{
	}
}



// datatypes specifies the type of data that a variable can store.

// <data_type> <variable_name> = <value> this is the syntax

//intager (whole number)
// floating point number- numbers with fractional parts /one or more decimals/
//character
//booleen
//string


int MyWholeNumber = 5;
double MyFloatingPointNumber = 10.33;
char Mycharacter = 'w';
bool MyBool = true;
string MyString = "KESTER"


	//Datatypes specifies the size and types of variables values
	int MyWholeNumber= 1000;
Console.writeline(MyWholeNumber); //output to be 1000 


//long whole numbers 
long Mylong = 10000000000l;
Console.writeline(Mylong);

//Float and double

float myfloat = 1.0f;

douable mydouble = 19.88d;


// floating point scientific numbrs.

float f1 = 89e3f // e to indicate power of 10
	double mydouble = 12E23D;


// booleans - gives true or false

bool IamFun = true;
bool Iamcool = false;

Consol.writeline(IamFun); //output = true
Console.Writeline(Iamcool); // output= falase



//char -character -stores sinle character
char mychar = 'r';

//string - stores sequence of characters
string mygreeting = "niaje mkuu";

console.writeline(mygreeting);



// e.g employee data



class program
{
	static void Main()
	{
		string employeename = "kesteramadanga";
	    int employeeage = 20;
		double employeemarks = 67.8;
		char employeegrade = 'A';
		bool isemployed = trues;

		console.writeline("Employee Name:" + employeename);
		console.writeline(" Employee Age:" + employeeage);
		console.writeline("Grade" + employeegrade);
		console.writeline("Eployee Marks:" + employeemarks + "%");
		console.writeline("Employed:" + isemployed);


	}
}





 // enumerations (enum)- special dataypes used for defining named constant values

using system;
 class program

{
	enum JobLevel{Intern, Junior, Mid, Senior, Manager }


	static void main()
	{
		JobLevel currentLevel = JobLevel.Mid;
		console.writeline("Current Job Level:" + currentLevel);
	}
}







//struct - used to encapsulate related data.-restricting access, private , public , protected

public class Person
{
    private string name;  // Private variable - can't be accessed directly

    // Public method to set name
    public void SetName(string newName)
    {
        name = newName;
    }

    // Public method to get name
    public string GetName()
    {
        return name;
    }
}






//example 2 


using System;

struct Employee
{
    public int ID;
    public string Name;
    public double Salary;
}

class Program
{
    static void Main()
    {
        Employee emp; // declare a variable emp of type Employee.
        emp.ID = 101;
        emp.Name = "Zoya";
        emp.Salary = 60000.50;

        Console.WriteLine("Employee ID: " + emp.ID);
        Console.WriteLine("Employee Name: " + emp.Name);
        Console.WriteLine("Employee Salary: $" + emp.Salary);
    }
}

//refference types
// 1. array type
// 2. object type
// 3. Dynamic types
// 4. string types
// 5. pointer types


//Array types- stores values of the same type in a single variable

using System;

class Program
{
    static void Main()
    {
        // array with 3 numbers
        int[] numbers = { 5, 10, 15 };

        // Print each number
        Console.WriteLine(numbers[0]); // prints 5
        Console.WriteLine(numbers[1]); // prints 10
        Console.WriteLine(numbers[2]); // prints 15
    }
}






//object types-


using System;

class Program
{
    static void Main()
    {
        // Declare object variables
        object myNumber = 100;         
        object myText = "Hello world";  

        // Print the object values
        Console.WriteLine(myNumber);  // Output: 100
        Console.WriteLine(myText);    // Output: Hello world
    }
}









//dynamic types -stores any types of value 

using System;

class Program
{
    static void Main()
    {
        dynamic value;

        value = 10;           // now value is an int
        Console.WriteLine(value);

        value = "Hello";      // now value is a string
        Console.WriteLine(value);

        value = true;         // now value is a bool
        Console.WriteLine(value);
    }
}






//string types- used to store text- a sequence of characters like words

using System;

class Program
{
    static void Main()
    {
        string name = "Alice";
        string greeting = "Hello, " + name + "!";

        Console.WriteLine(greeting); // Output: Hello, Alice!
    }
}









//pointer types- stores the memory address of another variable 



using System;

class Program
{
    unsafe static void Main()
    {
        int number = 10;
        int* ptr = &number;  // pointer to the variable 'number'

        Console.WriteLine("Value: " + number);       // Output: 10
        Console.WriteLine("Address: " + (int)ptr);   // Memory address
        Console.WriteLine("Value via pointer: " + *ptr); // Dereferencing
    }
}











//c# typecasting


//assigning one value of one data type to another
// imlicit casting and explicit

//implicit casting

// automatically- convert a smaller type to a larger type size

// char to int to long to float todouble e,g

int myint = 6;
double mydouble = myint;

Console.writeline(myint); //outputs 6
console.writeline(mydouble); // ouputs 6

//eexplicit casting

//done manualy by placing parenthesis in front of the value type 




  





night






//type conversions
//allows convertion of data from one type to anothother
// 1. implicit conversions,
// 2. explicit conversions



// 1. implicit - occurs oautomaticaly when there is no risc of loosing data
//Common Scenarios:
int → long

float → double

char → int





using System;

class Program
{
    static void Main()
    {
        int num = 100;         // int (32-bit)
        long bigNum = num;     // Implicit conversion to long (64-bit)

        float rate = 12.5f;    // float (32-bit)
        double preciserate = rate;  // Implicit conversion to double (64-bit)

        char letter = 'A';
        int ascii = letter;    // Implicit conversion from char to int

        Console.WriteLine("Long value: " + bigNum);
        Console.WriteLine("Double value: " + preciserate);
        Console.WriteLine("ASCII value of 'A': " + ascii);
    }
}




//explicit

//Explicit conversion must be done manually using a cast because there's a risk of data loss or the conversion might fail at runtime. It’s used when converting between incompatible types or from a larger to a smaller data type.

// Common Scenarios:
double → int

long → int

object → specific type

string → numeric type (using methods like int.Parse())





//e.g

using System;

class Program
{
    static void Main()
    {
        double preciseValue = 123.456;
        int intValue = (int)preciseValue;  // Explicit conversion (data loss)

        long bigNumber = 10000000000;
        int smallNumber = (int)bigNumber;  // May overflow

        string text = "50";
        int number = int.Parse(text);      // Explicit conversion using Parse()

        Console.WriteLine("After casting double to int: " + intValue);
        Console.WriteLine("After casting long to int: " + smallNumber);
        Console.WriteLine("Parsed string to int: " + number);
    }
}



//output inakua 

After casting double to int: 123
After casting long to int: 1410065408
Parsed string to int: 50





double myDouble = 9.78;
int myInt = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9






Choose the right data type: Using the correct data type helps save memory and makes your program efficient.
Use var when the type is obvious: It improves readability and makes the code cleaner.
Avoid unnecessary type conversions: Converting data types too often can slow down performance.
Use const or readonly for fixed values: These help prevent accidental changes to important values.
Use decimal for money-related calculations: It provides more accuracy for financial transactions.