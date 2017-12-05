using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        public static void menu()
        {
            String Flavor;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("As you read the words the book, they somehow begin to narrate itself.\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Lets begin with what flavor your in the mood for");
            Console.WriteLine("We have:");
            Console.WriteLine("1. Original Vanilla");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Deluxe Red Velvet");
            Console.WriteLine("4. Limited Edition Espresso Supreme/n");
            Console.WriteLine("Just say the number you want, I'm magic, I can hear you.");

            Flavor = Console.ReadLine();
            switch(Flavor)
            {
                case "1":
                    {
                        Flavor = "Original Vanilla";
                    break;
                    }
                case "2":
                    {
                        Flavor = "Chocolate";
                        break;
                    }
                case "3":
                    {
                        Flavor = "Deluxe Red Velvet";
                        break;
                    }
                case "4":
                    {
                        Flavor = "Limited Edition Espresso Supreme";
                        break;
                    }
            }
        }
    }
}