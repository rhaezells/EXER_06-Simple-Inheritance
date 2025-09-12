using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_08_Inheritance_with_User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //John Rhaezel C. Atillo
            //IT 306
            //EXER_08: Inheritance with User Input

            Console.WriteLine("-----Choose what type of shoes you want----");
            Console.WriteLine("1. Running Shoes");
            Console.WriteLine("2. Sports Shoes");
            Console.WriteLine("---Enter your choice 1 or 2----");
            string choice = Console.ReadLine();


            if (choice == "1")
            {
                Console.WriteLine("---Enter the Sneakers Brand:");
                string Brand = Console.ReadLine();

                Console.WriteLine("---Enter size---:");
                int Size = int.Parse(Console.ReadLine());

                Console.WriteLine("---Enter SportType---");
                string SportType = Console.ReadLine();

                //Show info
                Sneakers sneakers = new Sneakers(Brand, Size, SportType);
                sneakers.BasicInfo();
                sneakers.SneakerInfo();
                Console.WriteLine("----Thank you for Buying----");
            }


            else if (choice == "2")
            {
                Console.WriteLine("---Enter the Boots Brand:");
                string Brand = Console.ReadLine();

                Console.WriteLine("---Enter size---:");
                int Size = int.Parse(Console.ReadLine());

                Console.WriteLine("---Enter BootType---");
                string BootType = Console.ReadLine();

                //Show info
                Sneakers sneakers = new Sneakers(Brand, Size, BootType);
                sneakers.BasicInfo();
                sneakers.SneakerInfo();
                Console.WriteLine("----Thank you for Buying----");
            }



            else
            {
                Console.WriteLine("----Please input 1 for sneakers or 2 for boots----");
            }

            Console.ReadKey();
        }
    }
    
}
