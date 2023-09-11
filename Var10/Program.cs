using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Var10
{
    //This program takes two numbers(provided by the user) and compares them with 10. If one(but not both) are greater than 10, they are displayed
    internal class Program
    {
        //if one(but not both) of the user provided numbers are greater than 10, they are both displayed, otherwise they are rejected.
        static void Main(string[] args)
        {
            //two variables to hold the numbers we will compare
            int? var1 = null;
            int? var2 = null;

            //tell user to enter a number
            Console.WriteLine("Enter a number");
            //retrieve the user's input
            String firstNum = Console.ReadLine();
            //tell user to enter another number
            Console.WriteLine("Enter another number");
            //retrieves second number from user
            String secondNum = Console.ReadLine();
            //tries to convert the input into int while the int is null
            while (var1 == null)
            {
                try
                {
                    var1 = Convert.ToInt32(firstNum);
                }
                catch
                {
                    Console.WriteLine("Enter a number");
                    firstNum = Console.ReadLine();
                }
            }
            
            while (var2 == null)
            {
                try
                {
                    var2 = Convert.ToInt32(secondNum);
                }
                catch
                {
                    Console.WriteLine("Enter a number");
                     secondNum = Console.ReadLine();
                }
            }

            

            
            //boolean var to check if our inputs work
            bool ten = false;

            
            
               if (var1 > 10 ^ var2 > 10) {
                ten = true;
            }

            //if it works then the numbers are displayed
            if (ten)
            {
                Console.WriteLine(var1);
                Console.WriteLine(var2);
            }
            //if not then they are rejected
            else
            {
                Console.WriteLine("Rejected!");
            }

        }
    }
}
