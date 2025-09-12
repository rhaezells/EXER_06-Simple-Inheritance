using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER_08_Inheritance_with_User_Input
{
    internal class Shoe
    {
        //Fields
        public string Brand;
        public int Size;

        //Constructor
        public Shoe(string aBrand, int aSize)
        {
            Brand = aBrand;
            Size = aSize;
        }

        //Method to display
        public void BasicInfo()
        {
            Console.WriteLine("----Shoe Details----");
            Console.WriteLine($"Brand Name: {Brand}, Size: {Size}");
        }

    }

    class Sneakers : Shoe
    {
        //Field
        public string SportType;

        //Constuctor
        public Sneakers(string aBrand, int aSize, string aSportType) : base(aBrand, aSize)
        {
            SportType = aSportType;
        }

        //Method
        public void SneakerInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Size: {Size}, Sport Type: {SportType}");
        }
    }

    class Boots : Shoe
    {
        //Field
        public string BootType;

        //Constructor
        public Boots(string aBrand, int aSize, string aBootType) : base(aBrand, aSize)
        {
            BootType = aBootType;
        }

        //Method
        public void BootsInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Size: {Size}, Boot Type: {BootType}");
        }
    }
}
