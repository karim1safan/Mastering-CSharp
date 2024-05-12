using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Methods
{
    public class Employee
    {
        // Static and Constant are stored in the place called High Frequancy Heap
        public static double TAX = 0.03;
        public string Fname;
        public string Lname;
        public double Wage;
        public double LoggedHours;

        // Refactor salary slip application

        // All these method we don't use it in the main so we will make it encapsulation
        private double Calculate() => Wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();

        public string PrintSlip()
        {
            return $"\nFirst Name: {Fname}" + 
            $"\nLast Name: {Lname}" + 
            $"\nWage: {Wage}" + 
            $"\nLoggedHours: {LoggedHours}" + 
            "\n----------------------------" + 
            $"\nSalary: ${Calculate()}" + 
            $"\nDeductble Tax ({TAX * 100}%) Amount: ${CalculateTax()}" +
            $"\nnetSalary: {CalculateNet()}\n";
        }
    }
}
