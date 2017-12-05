using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CheckOut
    {
        public static void checkOut()
        {
            string Another;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("With a loud pop and a ploom of smoke Wizbolt hold out his hand.");
            Console.WriteLine("Sitting on top of his palm is your cupcake.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Well that was fun! One " + Size + " " + Kind + ". Wana get another(Y/N)?");

            Another = Console.ReadLine();

            switch(Another)
            {

                case "y"+"Y":
                    {
                        Menu.menu();
                        break;
                    }
            }

            //if they get to here they dont want another
            Console.Clear();
            Console.WriteLine("Well then, this is where you give me your money! $" + Total + " please!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to pay the man.");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("And with that, I must bid you adieu!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wizbolt says pushing out the door and slamming it behind you");
            Console.WriteLine("You sand for a moment, a bit confused as to what just happened to you.");
            Console.WriteLine("You then shrug, taking a bight of cupcake and walk up the stairs.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to end the game.");
            Console.ReadKey();
        }
    }
}
