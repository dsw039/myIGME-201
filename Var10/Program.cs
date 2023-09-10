using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Var10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //two variables to hold the numbers we will compare
            int var1 = 0;
            int var2 = 0;

            //tell user to enter a number
            Console.WriteLine("Enter a number");
            //retrieve the user's input
            String firstNum = Console.ReadLine();
            //tell user to enter another number
            Console.WriteLine("Enter another number");
            //retrieves second number from user
            String secondNum = Console.ReadLine();
            //converts the inputs into int
            var1 = Convert.ToInt32(firstNum);
            var2 = Convert.ToInt32(secondNum);

            //boolean var
            Boolean ten = true;

            
            
               if ((var1 > 10 || var2 > 10))
            {
                ten = true;
            }
               else if (!(var1 > 10 && var2 > 10) || (var1 > 10 && var2 > 10))
            {
                ten = false;
            }

            Console.WriteLine(ten);

        }
    }
}
