using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwoNum14
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();
            
            // change friend to Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            
            enemy = friend;

            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
