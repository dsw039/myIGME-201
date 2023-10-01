using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiseItUp
{
    internal class Program
    {
        //This programs grabs a string from the user and procceeds adds to a double value if the string matches "Daniel"
        static void Main(string[] args)
        {
            //variables
            string sName;
            double dSalary = 30000;

            //prompt user for name(string)
            Console.WriteLine("What is your name?");
           
           //gives the sName string the value of the user's string
                sName = Console.ReadLine();
            
           
            //call to function
            GiveRaise(sName, ref dSalary);
        }

        //this function compares the user's string to "Daniel". If it matches, salary is increased by 19999.99.
        static bool GiveRaise( string name, ref double salary)
        {
            if (name == "Daniel")
            {
                salary += 19999.99;
                Console.WriteLine("Congrats! You got a raise!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
