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

            //Create an instance of the Irregular student class
            RegularStudent regularStudent = new RegularStudent
            {
                Name = "Jack Antony Yagonia",
                Program = "BSIT",
                Section = "IT306"
            };
            regularStudent.BasicInfo();
            regularStudent.SectionEnrolled();


            IrregularStudent irreggularstudent = new IrregularStudent
            {
                Name = "Okay",
                Program = "BSIT",
                UnitsEnrolled = "20 Units"
            };
            irreggularstudent.BasicInfo();
            irreggularstudent.EnrolledSemUnits();
        }
    }
}
