// 1. Declaration [ <DateType> <Identifier>; ]
int num;

// 2. Assignment [ <Identifier> = <Value>; ]
num = 5;

// 3. Initialization [ <DateType> = <Initial Value>; ]
int num2 = 5;

// string reference type
string s1;

s1 = "karim";

string s2 = "safan";

// regular concatenation (plus sign)
string s3 = s1 + " " + s2;
Console.WriteLine(s3); // karim safan

// string interpolation
string s4 = $"{s1} {s2}";
Console.WriteLine(s4); // karim safan

// Value Type has a limit, but Reference Type doesn't
Console.WriteLine($"int: [{int.MinValue} ~ {int.MaxValue}]");

// var => Resolve at compile-time
var s5 = "karim";
// f, d, m, u, l, ul => is called litteral suffix
var f = 0f; // float
var d = 0d; // double
var m = 0m; // decimal
var u = 0u; // unint
var l = 0l; // long
var ul = 0ul; // ulong

int oneMillion = 1_000_000; 

var result1 = 200 / 3; // int
var result2 = 200 / 3.0; // double

// result2 = "karim safan";     // ERROR

// dynamic => Resolve at run-time
dynamic x = 9;
x = "abc";
x = 10m;

char letter = 'a';
Console.WriteLine(letter);

// Summary of the video [end of the video]
var id = 1000;
var fname = "karim";
var lname = "safan";
var salary = 1000d;
var gender = 'M';
var address = "Egypt";

Console.WriteLine("Employee");
Console.WriteLine("---------");
Console.WriteLine($"Id: {id}");
Console.WriteLine($"name: {fname} {lname}");
Console.WriteLine($"salary: {salary}");
Console.WriteLine($"gender: {gender}");
Console.WriteLine($"address: {address}");
