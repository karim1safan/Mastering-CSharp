using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fields
{
    // Class is a blueprint
    // <ClassModifier> Class <ClassName> {   class block    }
    // <ClassModifier> => public, internal (deafult), protected 
    public class Employee
    {
        // this is a block of class

        // Constant ->  <AccessModifier> const <DateType> <constantName> = <Value>;
        // <AccessModifier> -> public, private, protected, 
        public const double TAX = 0.03;

        // States or Fields ->  <AccessModifier> <DateType> <FieldName> = <InitialValue>;
        // <AccessModifier> -> public, private, protected, 

        public string Fname;
        public string Lname;
        public double Wage;
        public double LoggedHours;



    }
}
