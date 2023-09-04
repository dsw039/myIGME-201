using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: Daniel Wright
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0   Syntax error. Missing ;
            int i = 0;
            string allNumbers = null;
            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i) logical error. causes 10 to be skipped.
            for (i = 1; i <= 10; ++i)
            {

                // declare string to hold all numbers
                //string allNumbers = null; Syntax error. Since this string is declared in the loop, it can't be used outside of it.
                //statement hs been moved to line 25 so that the string can be used outside the loop.

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); Syntax error. Missing () around i -1.
                Console.Write(i + "/" + (i - 1) + " = ");

                //if else statement to prevent 1 from actually being divided by 0
                if (i == 1)
                {
                    Console.WriteLine("can't divide by zero");


                }

                else
                {
                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));
                }
                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; logical error. this line causes every other number to be skipped
                
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); Syntax error. Missing :+"
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

