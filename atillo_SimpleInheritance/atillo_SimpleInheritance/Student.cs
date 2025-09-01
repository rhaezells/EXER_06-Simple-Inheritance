using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace atillo_SimpleInheritance
{
    internal class Student
    {
        //Properties for the base class
        public string Name { get; set; }
        public string Program { get; set; }

        //Method to display student information
        public void BasicInfo()
        {
            Console.WriteLine("\n-----Student Information-----\n");
            Console.WriteLine($"Name: {Name}, \nProgram: {Program}");
        }
    }

    class RegularStudent : Student //Derived Class
    {
        //Additional Property for the Regular Student class
        public string Section { get; set; }

        //Method to display Regular Student class
        public void SectionEnrolled()
        {
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //another derived class
    {
        //Additional Property for the Irregular Student class
        public string UnitsEnrolled { get; set; }

        //Method to display Irregular Student class
        public void EnrolledSemUnits()
        {
            Console.WriteLine($"Units Enrolled: {UnitsEnrolled}");
        }
        
    }

}
    