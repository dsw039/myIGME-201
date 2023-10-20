using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classy
{
    interface Anime
    {
        void dragonBall();

    }

    // Goku implements Anime
    class Goku : Anime
    {
        public void dragonBall()
        {
            Console.WriteLine("Goku is an anime character in Dragon ball");
        }
    }

    class Naruto : Anime
    {
        public void dragonBall()
        {
            Console.WriteLine("Naruto is anime character who isn't in Dragon ball");
        }
    }

  
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates objects of both class
            Goku myGoku = new Goku();
            myGoku.dragonBall();

            Naruto myNaruto = new Naruto();
            myNaruto.dragonBall();
        }
        public static void MyMethod(object myObject)
        {

        }
    }
}
