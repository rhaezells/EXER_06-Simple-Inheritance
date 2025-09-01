using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atillo_SimpleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //Section: IT-306
            //EXER_06: Simple Inheritance

            //Create an Instance of the Student class
            Student student = new Student
            {
                Name = "John Rhaezel C. Atillo",
                Program = "BSIT"
            };
            student.BasicInfo(); //Call the method to display student info

            //Create an instance of the Irregular student class
            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Jack Antony Yagonia",
                Program = "BSIT"
            };
            student.BasicInfo();
            student.
            

        }
    }
}
