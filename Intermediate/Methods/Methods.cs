using System;

namespace Methods2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // if the method not static we can call it using the obj
            Demo d = new Demo();
            // Caller
            d.DoSomeThing();  
            // -------------------------------------------
            var fun = 100 + d.DoSomeThing2(); // Primary Expression (return a value)
            Console.WriteLine(fun);
            // -------------------------------------------
            // When we send the variable we must make an intialization
            // if the variable hasn't initial value we can use out keyword

            // var age = 18;
            int age;
            d.DoSomeThing3(out age);
            Console.WriteLine(age); // 21

            // -------------------------------------------

            var numberString = "1234";
            int number;
            if(!int.TryParse(numberString, out number))
            {
                Console.WriteLine("Invalid Number...");
            }
            else
            {
                Console.WriteLine("You provided a valid number " + number);
            }

            // -------------------------------------------

            d.Promote(100, "egypt", "cairo");

            // -------------------------------------------

            var result = d.IsEven(6);
            Console.WriteLine(result); // true

            // -------------------------------------------

            // We must access the static method using class name 
            Demo.PrintOdds(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13});

            // -------------------------------------------



        }
    }
    public class Demo
    {
        // Methods

        // Method syntax (simple)
        // <AccessModifier> <DataType>/void <MethodName> (<ParameterList>) { Method Body }

        // Callee
        public void DoSomeThing()
        {
            Console.WriteLine("Do Somethings....");
        }

        public int DoSomeThing2()
        {
            return 10;
        }

        public void DoSomeThing3(out int age)
        {
            age = 18;
            age = age + 3;
        }

        // Methods Signiture (Name + Param type + param order)

        // This called method overload
        // Method Overloading (A common way of implementing Polymorphism)
        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a pormotion of ${amount}");
        }

        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a pormotion of ${amount} and a trip {trip}");
        }
        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a pormotion of ${amount} and a trip {trip} with {hotel}");
        }

        // Expression Bodied Methods
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // public bool IsEven(int number) => return number % 2 == 0;

        // Local Methods
        // if we use the method in 1 reference we can make it local in another method
        // if we put another method inside the static method => 2 methods must be a static 
        public static void PrintOdds(int[] original)
        {
            foreach(var n in original)
            {
                if(IsOdd(n))
                {
                    Console.WriteLine(n + " ");
                }
            }
            // if we use the local method outside the parent metnod we must put static keyword
            bool IsOdd(int number) => number % 2 == 1; // we can't show it in the outside of this method
        }

    }
}
