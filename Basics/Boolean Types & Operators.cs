/*
    EP: 004
    Boolean Type and Operator
    - Expression
    - Equality Operators
    - Comparision Operators
    - Equality and Ref. Type
    - Conditional Operator
    - Short Circit && ||
    - Ternary Operator
*/

bool isVip = true;
// bool isVip2 = 1; // ERROR

int x = 10; // assignment 10 to variable x
int y = 10;

// This is Good in the Performance 
Console.WriteLine(x == y); // x is equal to y? => true  

// Expression 1 + 2 = 3 => after the evaluation the results are a single value 
var z = (x == y); // bool

// This is Good in the Readability
Console.WriteLine(z); // true

// Comparsion Operator
var total = 1000;
var vipThreshold = 900;
var _isVip = (total >= vipThreshold); // bool
Console.WriteLine(_isVip); // true

// Negation
isVip = !true;
Console.WriteLine(isVip);

Console.WriteLine("---------------");
// Conditional Operator && ||
// Logical AND &&
Console.WriteLine(true && true); // true
Console.WriteLine(true && false); // false
Console.WriteLine(false && false); // false
Console.WriteLine(false && true); // false
Console.WriteLine("---------------");

// Logical OR ||
Console.WriteLine(true || true); // true
Console.WriteLine(true || false); // true
Console.WriteLine(false || false); // false
Console.WriteLine(false || true); // true
Console.WriteLine("---------------");

// Logical XOR ^
// if the same value => false
Console.WriteLine(true ^ true); // false
Console.WriteLine(true ^ false); // true
Console.WriteLine(false ^ false); // false
Console.WriteLine(false ^ true); // true
Console.WriteLine("---------------");

var isFirstFive = true;
var GPA = 3.5;

var isElegibleToSchoolarship = GPA >= 3.5 && isFirstFive;
Console.WriteLine(isElegibleToSchoolarship); // true

Console.WriteLine("---------------");

// Short Circuit & |
// && => make a short circuit
Console.WriteLine(true & true); // true
Console.WriteLine(true & false); // false
Console.WriteLine(false & false); // false
Console.WriteLine(false & true); // false

Console.WriteLine("---------------");

Console.WriteLine((true & true) == (true && true)); // true
Console.WriteLine((true & false) == (true && false)); // true
Console.WriteLine((false & false) == (false && false)); // true
Console.WriteLine((false & true) == (false && true)); // true

Console.WriteLine("---------------");
// ||, && makes the short circuit evaluation => takes time less than |, &
// |, & => makes evaluation to all expression
// If make evaluation to check() method will print the message
bool value1 = true | check(); // checking...
bool value2 = true || check(); // not print because evalute the first only

static bool check()
{
    Console.WriteLine("checking....");
    return true;
}

Console.WriteLine("---------------");

// == Reference Type
var a = 1;
var b = 1;

// compare the values (value type)
var c = a == b;
Console.WriteLine(z); // true

// compare the references (reference type)
var s1 = "hello";
var s2 = "hello";

var s3 = s1 == s2;

// CLR internally calls IsEqual() thats why the result is true
Console.WriteLine(s3); // true

// Ternary Operator
total = 900;
vipThreshold = 1000;
isVip = total >= vipThreshold ? true : false;
var discount = total >= vipThreshold ? 0.05m : 0.0m;
