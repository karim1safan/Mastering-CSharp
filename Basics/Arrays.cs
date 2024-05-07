// Array is a reference type 
// Sigle Dimentional Array

// 1. Declaration
string[] friends = new string[5];

// 2. Accessing Element
friends[0] = "ahmed";
friends[1] = "ali";
friends[2] = "mohamed";
friends[3] = "mona";
friends[4] = "karim";

// 3. Intialization
string[] names = new string[3] { "ahmed", "mohamed", "ali" };
string[] names2 = {"ahmed", "mohamed", "ali" };
// var names3 = {"ahmed", "mohamed", "ali" }; // ERROR
var names3 = new string[3] {"ahmed", "ali", "mona"}; // object intializer


// Multi-Dimentional Array OR (Rectangluar Array)
int[,] suduko = 
{
    {1, 2, 3},
    {4, 5, 6},
    {5, 6, 7},
    {6, 7, 8},
    {7, 8, 9}
};

// Juagged Array (array of array)
// Such a multi-dimention array, but the performance is better
var Juagged = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 5},
    new int[] {6, 7},
    new int[] { 8 }
};

// Indices and Ranges
var Friends = new string[] {"ali", "mona", "noha", "karim", "Menna"};

var first = Friends[0];
// Console.WriteLine(first); // ali

var slice1 = Friends[..2]; // give me the first 2 element from 0 => [ali, mona]

var slice2 = Friends[2..]; // skip the first 2 element from 0   => [noha, karim, Menna]

var slice3 = Friends[2..3]; // starting from 2 taking until 3  => [noha]

// [2..3] => starting inclusive and the ending exclusive [2..3-1] => [2..2]

var slice4Range = 2..^2;
var slice4 = Friends[slice4Range];    // [noha]

// starting from 2 remove the last 2 elements 
// ^ => means the indexing starting from the end
// when the index starting from the end the index start from 1 not 0

// Bound Checking
var names4 = new string[] {"ahmed", "mohamed", "ali", "mona", "noha"};

var item = names4[5];
// Console.WriteLine(item); // Out Of Range , ERROR in the Run-Time 

