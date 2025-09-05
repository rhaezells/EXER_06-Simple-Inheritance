using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER07_Simple_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //Section: IT-306
            //EXER_07: Simple Inheritance with Constructor

            //Create an instance of the Irregular student class
            RegularStudent regularStudent = new RegularStudent("John Rhaezel C. Atillo", "BSIT", "IT306");
            regularStudent.SectionEnrolled();

            IrregularStudent irregularStudent = new IrregularStudent("Carls Kevin", "BSIT", 15);
            irregularStudent.EnrolledSemUnits();

           
        }
    }
}
