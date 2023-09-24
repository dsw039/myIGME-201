using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDelegate
{
    delegate string ConsoleFunction(string input);
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConsoleFunction fakeRead;

            fakeRead = new ConsoleFunction(Read);

            String readLine = fakeRead(input);
        }

        static string Read(string lineInput) {
        
            return Console.ReadLine();
        }
    }
}
