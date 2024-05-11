/*
    EP: 009
    OOP Methods
    - Instance VS. Static Member
    - Method Signetures
    - Expressions Bodied Method
    - Method Overload
    - Pass Parameter Value and Ref.
    - Local Method

*/
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            emps[0] = e1;
            emps[1] = e2;

            // const doesn't change, we can read it from user so we will use static variable 
            Console.Write("TAX: ");
            Employee.TAX = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("==== First Employee ====");
            Console.Write("First Name: ");
            e1.Fname = Console.ReadLine();

            Console.Write("Last Name: ");
            e1.Lname = Console.ReadLine();

            Console.Write("Wage: ");
            e1.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e1.LoggedHours = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("---------------------");

            Console.WriteLine("==== Second Employee ====");
            Console.Write("First Name: ");
            e2.Fname = Console.ReadLine();

            Console.Write("Last Name: ");
            e2.Lname = Console.ReadLine();

            Console.Write("Wage: ");
            e2.Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("LoggedHours: ");
            e2.LoggedHours = Convert.ToDouble(Console.ReadLine());

            foreach(var e in emps)
            {
                var salary = e.Wage * e.LoggedHours;
                var taxAmount = salary * Employee.TAX;
                var netSalary = salary - (taxAmount);

                Console.WriteLine($"\nFirst Name: {e.Fname}");
                Console.WriteLine($"Last Name: {e.Lname}");
                Console.WriteLine($"Wage: {e.Wage}");
                Console.WriteLine($"LoggedHours: {e.LoggedHours}");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Salary: ${salary}");
                Console.WriteLine($"Deductble Tax ({Employee.TAX * 100}%) Amount: ${taxAmount}");
                Console.WriteLine($"netSalary: {netSalary}\n");
            }
        }
    }
}
