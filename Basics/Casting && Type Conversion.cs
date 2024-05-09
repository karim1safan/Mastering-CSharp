/*
    EP: 007
    Casting and Type Conversions
    - Data Types Are Objects
    - Implicit and Explicit Casting 
    - Boxing / Unboxing 
    - Convert class VS. Parse
    - Try parse
    - Bit Converter and Value Types
*/

// C# strongly type language

// anything in c# are object and the root of this is Object Class
// Object Class

// all this types are equal 
// the types with numbers called alias 
Int16 s; // equal to short s; => 16 bits
Int32 i; // equal to int x; => 32 bits
Int64 l; // equal to long x; => 64 bits
short sh; // -32767 - 32768
ushort us; // 0 - 65535
UInt16 a;

// Int32 (int) - Int64 (long)

// Implicit Conversion
int numberInt = 100;
long numberLong = numberInt; // Implicit

// Explicit
// Data is losting
// numberInt = numberLong; // Error (we can't store big int in the small int)
numberInt = (int)numberLong; // Explicit

long nL = 1000;
if(nL <= Int32.MaxValue)
{
    int mI = (int)numberInt;
}

double dd = 1234.56;
int ii = (int)dd;
Console.WriteLine(ii); // 1234 

// Boxing and Unboxing => Inerview Question
// Convert from Value Type to Reference Type and this is done implicitly

int x = 10; // Value Type
object obj; // Reference Type
obj = x;    // Convert done implicitly [Boxing]
// Boxing => convert from value type to reference type

// int y = obj; // Give me an error
int y = (int)obj; // Unboxing
// Unboxing => convert from reference type to value type

// Parse() => Convert from string to numbers
string stringValue = "120";
// int number = stringValue; // error

// 1) type.Pares() => int.Parse(), double.Pares(), ...
int number = int.Parse(stringValue);
Console.WriteLine(number + 1); // 121

// string stringValue2 = "w120";
string stringValue3 = "999999999999999999";

// int number2 = int.Parse(stringValue2);
// int number3 = int.Parse(stringValue3);

// Console.WriteLine(number2); // error in the run-time [Format Exception Error]
// Console.WriteLine(number2); // error in the run-time [Overflow Exception Error]
// in this case we must check


// TryParse
if(int.TryParse(stringValue3, out int n))
{
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Invald Number Conversion"); // this is will print
}

// Convert Class => Convert.ToInt32(), Convert.ToDecimal(), ....

Console.WriteLine("----------------");

// Bit Converter
var num = 255;
var bytes = BitConverter.GetBytes(num);

foreach (var b in bytes)
{
    // Console.WriteLine(b);
    var binary = Convert.ToString(b, 2).PadLeft(8, '0');
    // PadLeft(8, '0') => this mean the number will be printed must be 8 places
    Console.WriteLine(binary); // Conver 255 to Binary
}

Console.WriteLine("----------------");

// How to Convert from string to binary or hexadecimal
var myName = "Karim";
char[] letters = myName.ToCharArray();

foreach (var letter in letters)
{
    int ascii = Convert.ToInt32(letter);
    var output = $"'{letter}' => ASCII: {ascii}, Binary: {Convert.ToString(ascii, 2).PadLeft(8, '0')}, Hexadecimal: {ascii:x}";
    Console.WriteLine(output);
}

Console.WriteLine("----------------");

string[] hexValues = {"49", "73", "73", "61", "6D"};
foreach (var hex in hexValues)
{
    int values = Convert.ToInt32(hex, 16); // Convert from the hexadecimal to int
    var stringValues = char.ConvertFromUtf32(values); // Convert int value to string value
    var ch = (char)values; // to get the char of string

    Console.WriteLine(ch);
}

Console.WriteLine("----------------");

// Covert this from hexadecimal to interge
var hexx = "BE2";
int num2 = Int32.Parse(hexx, System.Globalization.NumberStyles.HexNumber);
Console.WriteLine(num2);
