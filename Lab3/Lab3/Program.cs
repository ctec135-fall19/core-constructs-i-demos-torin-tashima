using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar myCar = new SportsCar();
            myCar.PetName = "Miles";
            Console.WriteLine("My favorite car {0}.\n{1}", myCar.getPetName(), myCar.PetName);
        }
    }
}
