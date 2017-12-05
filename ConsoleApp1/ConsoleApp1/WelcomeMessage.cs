using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WelcomeMessage
    {
        public static void welcomeMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You walk into a dark ally.");
            Console.WriteLine("Checking over your shoulder you open a steel door in the shadows.");
            Console.WriteLine("As you walk down a dark staircase you see a light at the bottom.");
            Console.WriteLine("Strange music tickles your ears and you are drawn in.");
            Console.WriteLine("Walking through the door at the bottom, you are met by a strange looking man.");
            Console.WriteLine("His beard somehow manages to allways have a small trickle of smoke");
            Console.WriteLine("gently wisping out of it. He grins and says:\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to Wizbolts Discount CupCake Shop!");
            Console.WriteLine("I'm William Wizbolt, I shall be the guide on your cupcake adventure today.");
            Console.WriteLine("You can call me Wizbolt though. Lets get you a menu!\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wizbolt turns around and as he walks behind the counter");
            Console.WriteLine("you see a massive pile of grey matted hair tied up on the back of his head.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Your not one of those adventurer tipes are you?\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wizbolt squints at you skeptically.");
            Console.WriteLine("He pulls a massive book from behind the counter \nwith the title 'Cover Businesses'");
            Console.WriteLine("You walk over as he flips through the pages muttering to himself.");
            Console.WriteLine("While you walk, you turn and look through a gap in the curtan to the back room");
            Console.WriteLine("but before your eyes could focus a force caused your head to snap forward.\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Ah! Here it is!\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to read the menu.");
            Console.ReadKey();
        }
    }
}
