
/*
    EP: 008
    OOP - Field and Constant
    - Introduction
    - OOP Definition
    - Class VS. Object
    - Class Modifiers
    - Access Modifiers
    - Field Constant
*/

// The Problem statement

/*
    Company is looking for application to do salary slip calculation for employee based on
    daily bases following the rule total earnings is equal to hours logged times his wage.
    fixed tax is applied 3% on all.user need to enter input and salary will be shown accordingly 
*/


// var str = Console.Read(); // This read an character from the user
// var str = Console.Read(); // This read an Line of character from the user


// Old School Approach
// const double TAX = .03;
/*
Console.Write("First Name: ");
var firstName = Console.ReadLine();

Console.Write("Last Name: ");
var lastName = Console.ReadLine();

Console.Write("Wage: ");
var wage = Convert.ToDouble(Console.ReadLine());

Console.Write("LoggedHours: ");
var loggedHours = Convert.ToDouble(Console.ReadLine());

var netSalary = wage * loggedHours - (wage * loggedHours * TAX);

Console.WriteLine($"First Name: {firstName}");
Console.WriteLine($"Last Name: {lastName}");
Console.WriteLine($"wage: {wage}");
Console.WriteLine($"loggedHours: {loggedHours}");
Console.WriteLine($"Net Salary: {netSalary}");
*/
// What if we want to add a new employee ?
// We will copy all these statements and add a new employee (bad way)
// If we want to add 100 employee (this is impossible)
// this is will be messy 

// ----------------------------------------------------------------------------

// OOP => Is a programming paradime that allows you to package together data states and functionallity

// Object (Instance) Syntax
// 1) Declaration <Type> <ObjectName>;
// 2) Assignment <ObjectName> = new <Type> ();
// 3) Initialization <Type> <ObjectName> = new <Type> (); => declaration + assignment

// I am used the namespace because there is an external class
namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class is a Reference Type
            // the object stores in the stack
            // the value of the object stores in the heap
            
            // Now, we can use array esaily as objects, so we can make many objects
            Employee[] emps = new Employee[2];

            Employee emp1 = new Employee();

            Console.WriteLine("=== First Employee ===");
            Console.Write("First Name: ");
            emp1.Fname = Console.ReadLine();

            Console.Write("Last Name: ");
            emp1.Lname = Console.ReadLine();

            Console.Write("Wage: ");
            emp1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            emp1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            // var netSalary = emp1.Wage * emp1.LoggedHours - (emp1.Wage * emp1.LoggedHours * Employee.TAX);

            // Console.WriteLine($"First Name: {emp1.Fname}");
            // Console.WriteLine($"Last Name: {emp1.Lname}");
            // Console.WriteLine($"wage: {emp1.Wage}");
            // Console.WriteLine($"loggedHours: {emp1.LoggedHours}");
            // Console.WriteLine($"Net Salary: {netSalary}");

            emps[0] = emp1;
            Console.WriteLine("----------------------------");

            Console.WriteLine("\n=== Second Employee ===");

            Employee emp2 = new Employee();

            Console.Write("First Name: ");
            emp2.Fname = Console.ReadLine();

            Console.Write("Last Name: ");
            emp2.Lname = Console.ReadLine();

            Console.Write("Wage: ");
            emp2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            emp2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            // var netSalary2 = emp2.Wage * emp2.LoggedHours - (emp2.Wage * emp2.LoggedHours * Employee.TAX);

            // Console.WriteLine($"First Name: {emp2.Fname}");
            // Console.WriteLine($"Last Name: {emp2.Lname}");
            // Console.WriteLine($"wage: {emp2.Wage}");
            // Console.WriteLine($"loggedHours: {emp2.LoggedHours}");
            // Console.WriteLine($"Net Salary: {netSalary2}");

            emps[1] = emp2;

            foreach(var e in emps)
            {
                var netSalary = e.Wage * e.LoggedHours - (e.Wage * e.LoggedHours * Employee.TAX);

                Console.WriteLine($"First Name: {e.Fname}");
                Console.WriteLine($"Last Name: {e.Lname}");
                Console.WriteLine($"wage: {e.Wage}");
                Console.WriteLine($"loggedHours: {e.LoggedHours}");
                Console.WriteLine($"Net Salary: {netSalary}");
            }
            Console.WriteLine("----------------------------");


        }
    }
}
