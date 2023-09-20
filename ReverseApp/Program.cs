using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseApp
{
    //Daniel Wright 9-20-23
    // This program takes a user given string and prints it out in reverse
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program will first ask the user for a String
            Console.WriteLine("Please input a word.");
            //The String is taken from the user and stored in a value
            String userWord = Console.ReadLine();
            //Turns our user's string into a char array for ease of manipulation
            char[] userChars = userWord.ToCharArray();
            //Create a new array to hold our chars in reverse order
            char[] reversedChars = new char[userChars.Length];
            //For loop to reverse the order of our new char array
            for(int i = 0; i < userChars.Length; i++)
            {
                //This places the values of userChars into those of reversedChars
                //The first value of reversedChars is the last value of userChars
                reversedChars[reversedChars.Length -1  - i] = userChars[i];
            }
            //This prints our newly reversed array made from the user given string
            Console.WriteLine(reversedChars);
        }
    }
}
