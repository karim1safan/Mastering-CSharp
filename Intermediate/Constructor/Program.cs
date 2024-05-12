/*
    EP: 10
    OOP - Constructor
    - Implicit Constructor
    - Overloaded Constructor
    - This Keyword
    - Non Public Constructor
    - Object Intializer
    - Readonly Field
*/
using System;
namespace Constructor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Problem Statement
            // dd/mm/yy     dd(int) [01-31] / month(int) [01-12] / year(int) [01-9999]

            Date d1 = new Date(20, 02, 2000);
            Date d2 = new Date(2000);
            Date d3 = new Date(02, 2000);
            Console.WriteLine(d1.GetDate()); // 20/02/2000
            Console.WriteLine(d2.GetDate()); // 01/01/2000
            Console.WriteLine(d3.GetDate()); // 01/02/2000
            Console.WriteLine("---------------------------------------------------------");
            // -------------------------------------------------------------------------
            
            // 1) First Method
            // Employee emp = new Employee();
            // emp.Id = 1001;
            // emp.Fname = "Karim";
            // emp.Lname = "Safan";

            // 2) Second Method
            // Object Intializer (most popular)
            // Employee emp2 = new Employee
            // {
            //     Id = 1002,
            //     Fname = "Karim",
            //     Lname = "Safan"
            // };


            // Employee emp3 = new Employee(1000)
            // {
            //     Fname = "Karim",
            //     Lname = "Safan"
            // };

            Employee e1 = Employee.create(2000, "Karim", "Safan");

            Console.WriteLine(e1.Display());
        }
    }

    public class Date
    {
        // Readonly => can't change it, but in the constructor we can
        //                                   0  1   2   3   4   5   6   7   8   9  10  11   12
        private readonly int[] DaysToMonth365 = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private readonly int[] DaysToMonth366 = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; // in the leap year
        // read-only => layer of security
        // instead make else statement
        private readonly int day = 01;
        private readonly int month = 01;
        private readonly int year = 01;
        public Date(int day, int month, int year)
        {
            var isLeapYear = (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);

            if(year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeapYear ? DaysToMonth366 : DaysToMonth365;
                if(day >= 1 && day <= days[month])
                {
                    this.day = day;
                    this.month = month;
                    this.year = year;
                }
            }
        }
        // Constructor Overlaoded
        public Date(int year) : this(01, 01, year) { }
        public Date(int month, int year) : this(01, month, year) { }

        public string GetDate()
        {
            // day = 20; // error this field is read-only can't change it
            return $"{day.ToString().PadLeft(2, '0')}/{month.ToString().PadLeft(2, '0')}/{year.ToString().PadLeft(4, '0')}";
        }

    }
    
    public class Employee
    {
        private int id;
        private string fname;
        private string lname;

        // public Employee()
        // {

        // }
        // public Employee(int id)
        // {
        //     Id = id;
        // }

        // Factory Method and Private Constructor
        private Employee(int id, string fname, string lname)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
        }

        public static Employee create(int id, string fname, string lname)
        {
            return new Employee(id, fname, lname);
        }
        public string Display()
        {
            return $"ID: {id}\tFirst Name: {fname}\tLast Name: {lname}";
        }
    }
}
