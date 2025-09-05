using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER07_Simple_Inheritance
{
    internal class Student
    {
        //Properties for the base class
        public string Name;
        public string Program;

        //Constructor
        public Student(string studentName, string studentProgram)
        {
            Name = studentName;
            Program = studentProgram;
        }

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
        public string Section;

        public  RegularStudent(string studentName,string studentProgram, string studentSection) : base(studentName, studentProgram)
        {
            Section = studentSection;
        }

        //Method to display Regular Student class
        public void SectionEnrolled()
        {
            BasicInfo();
            Console.WriteLine($"Section: {Section}");
        }
    }

    class IrregularStudent : Student //another derived class
    {
        //Additional Property for the Irregular Student class
        public int UnitsEnrolled;

        public IrregularStudent(string studentName, string studentProgram, int unitsEnrolled) : base(studentName, studentProgram)
        {
            UnitsEnrolled = unitsEnrolled;
        }



        //Method to display Irregular Student class
        public void EnrolledSemUnits()
        {
            BasicInfo();
            Console.WriteLine($"Units Enrolled: {UnitsEnrolled}");
        }
    }
}
