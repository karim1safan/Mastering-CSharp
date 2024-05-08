/*
    EP: 006
    Expressions and Iterations
    - Expression Types
    - Binary Operators
    - NULL (Coalescing, Condeitional)
    - Statement / Statement Blocks
    - Selection (IF, Switch)
    - Iteration (For, While, Do-While, Foreach)
    - Jumb Statements
*/

// Primary Expression => Expression has a value (return a value)
var amount = Math.Cos(30) + 1;
Console.WriteLine(amount);

// Void Expression => Not return a value
Console.WriteLine("Karim");
// Console.WriteLine("Karim") + 1; // ERROR => this is not primary expression

// Assignment Statement
var x = 2;
x = x + 10; // 12

// Binary Operators
// Evaluation from left to right
// in the conditional operators such &&, || => evaluation from right to left
var a = 5;
var b = 2;

Console.WriteLine($"a + b = {a+b}");
Console.WriteLine($"a - b = {a-b}");
Console.WriteLine($"a * b = {a*b}");
Console.WriteLine($"a / b = {a/b}");
Console.WriteLine($"a % b = {a%b}");

var z = 8 / 4 / 2; // 1
var w = 8 / (4 / 2); // 4

Console.WriteLine(z);
Console.WriteLine(w);

// Assignment Statement
// Evaluation From Right To Left
var s1 = "";
var s2 = "";
var s3 = s1 = s2 = "Karim";

// first assign the value to s2 and then s1 

// Null Operator
// var s = null; // This is an error
string s = null;

// if s1 is null put the value of karim in s1
s1 = s1 ?? "karim";
Console.WriteLine(s1); // Karim

// s1 is not null
s1 = s1 ?? "ahmed"; 
Console.WriteLine(s1); // Karim

// ?? => this is called null coalescing


// Conditional NULL
string ss = null; // in the heap doesn't point to anything
string cc = ""; // in the heap points to an empty string

// empty string not null so null != "" 
// null in the heap doesn't point to anything 
// empty string in the heap points to an empty string

// var nullString = ss.ToUpper(); // NullReferenceException because the string is null not points to anything in the heap
var emptyString = cc.ToUpper(); // This run correctly

// to solve this problem we will use null conditional operator
var nullString = ss?.ToUpper(); // this mean if not null call the method 
// above statement is equal to
var nullString2 = ss is null ? null : ss.ToUpper();

Console.WriteLine(nullString); // empty
Console.WriteLine(emptyString); // empty
Console.WriteLine(nullString2); // empty 

// Single Statement 
Console.WriteLine("I am single statement");

// Block Statement
{
    Console.WriteLine("I am in block statement");
    Console.WriteLine("I am in block statement");
    Console.WriteLine("I am in block statement");
}

// Kinds Of Expressions

// 1. Declaration Statement
int v;
v = 2;

// 2. Expression Statement
// 1) // Change State
var name = "karim";
name = name + " Safan"; 

// 2) Call something that change the state
name = name.ToUpper();

// 3) Assignment 
name = name + " Safan"; 

// 4) Increment / Decrement
var totalFriends = 150;
++totalFriends; // 151
Console.WriteLine(totalFriends);

--totalFriends; // 150
Console.WriteLine(totalFriends);

var n = 2;
Console.WriteLine(n++); // 2 and if use n after this line will be 3
Console.WriteLine(n); // 3

// 5) Object Instansiation
object o = new object();

// if statement, else, nested if 

// -------------------------
// switch
var amountJOD = 100;
var currType = "CAD";
var output = 0d;

var JODTOUSD = 1.41d;
var JODTOEUR = 1.19d;
var JODTOCAD = 1.78d;

switch(currType)
{
    case "USD":
        output = amountJOD * JODTOUSD;
        Console.WriteLine($"{amountJOD} JOD = {output} USD");
        break;
    case "EUR":
        output = amountJOD * JODTOEUR;
        Console.WriteLine($"{amountJOD} JOD = {output} EUR");
        break;
    case "CAD":
        output = amountJOD * JODTOCAD;
        Console.WriteLine($"{amountJOD} JOD = {output} CAD");
        break;
    default:
        Console.WriteLine("unknown currency type");
        break;
}
// -------------------------
var number = 3;
switch(number)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 9:
        Console.WriteLine("Odd");
        break;
    case 2:
    case 4:
    case 6:
    case 8:
        Console.WriteLine("Even");
        break;
}
// -------------------------
// object can be anything
object variable = "karim";
switch(variable)
{
    case int i: 
        Console.WriteLine("int"); 
        break;
    case string: 
        Console.WriteLine("string"); 
        break;
}
// -------------------------
bool isVip = true;
switch(isVip)
{
    case bool i when i == true: // this excute only if the isVip == true
        Console.WriteLine("YES");
        break;
    case bool i:
        Console.WriteLine("NO");
        break;
}
// -------------------------
// Switch in .Net 8
var cardNo = 13;
string cardName = cardNo switch
{
    1 => "ACE",
    13 => "King",
    12 => "Queen",
    10 => "Jack",
    _ => cardNo.ToString()
};

Console.WriteLine(cardName); // King
// -------------------------


// Iteration

// Fibonaci [0 1 1 2 3 5 8 13 ..... ]
for(int counter = 0, prev = 0, curr = 1; counter < 10; counter++)
{
    Console.Write(prev + " ");
    int newFib = prev + curr;
    prev = curr;
    curr = newFib;
}
Console.WriteLine();

// -------------------------

// for( ; ; ) // while(true)
// {
//     Console.WriteLine("Infinte Loop...");
// }

// -------------------------

// foreach => easy, readable
// in the performance for is better than foreach

foreach(char c in "Full Stack developer course")
{
    Console.Write(c + " ");
}
Console.WriteLine();

// -------------------------

var arr = new int[] { 1, 2, 3 };
foreach(var item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");
foreach(var item in new int[] { 1, 2, 4, 5, 6, 7})
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");

// Jumb Statement [break, continue, goto, return]

// goto
var j = 0;
start:  // Lable
if(j <= 5)
{
    Console.WriteLine(j + " ");
    j++;
    goto start;
    // After goto statement we ca't implement it
    Console.Write("This message doesn't print");
}
