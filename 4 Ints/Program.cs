using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Ints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int cant be 0 because anything times 0 is 0
            int product = 1;
            //tell user to give numbers
            Console.WriteLine("enter 4 numbers.");
            //grabs a number and multiplies it with our first number 4 times.
            for (int i = 0; i < 4; i++)
            {
                //grabs the input
                string r = Console.ReadLine();
                //turns the string into an int var
                int tempNum = Convert.ToInt32(r);
                //mutiplies it
                product *= tempNum;
            }
            //displays final product
            Console.WriteLine("product is "+product);
        }
    }
}
