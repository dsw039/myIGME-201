using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteFood = "spaghetti";
            switch ("spaghetti")
            {
                case ("spaghetti"):
                    Console.WriteLine("You seem to really like spaghetti.");
                    break;
                case ("cake"):
                    Console.WriteLine("Wrong. Spaghetti is the best food.");
                    default:  
          Console.WriteLine("You should like spaghetti.");
            }


        }
    }
}
